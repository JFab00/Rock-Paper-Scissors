using GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Xml.Linq;

namespace WebAPIserver.Controllers
{

    // visto che senza ci dava un errore tipo "CORS access denied", abbiamo
    // cercato su internet e a quanto pare aggiungendo la riga sotto, insieme
    // alla riga "config.EnableCors();" che si trova in WebApiConfig.cs, da
    // il permesso alla parte client di accedere alla parte server
    // il problema è che non so se la porta sotto varia da pc a pc...
    [EnableCors(origins: "https://localhost:44392", headers: "*", methods: "*")]
    public class RpsController : ApiController
    {

        static private List<GameUser> utentiLoggati = new List<GameUser>();
        private static List<Match> gamePlay = new List<Match>();


        // funzione uguale identica che si trova in ServiceGame.asmx, solo che aggiornata per l'architettura REST
        [HttpPost]
        [Route("api/rps/login")]
        public bool Login([FromBody] Newtonsoft.Json.Linq.JObject source)
        {
            // creo l'xDocument
            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));

            // prendo i valori che l'utnte ha inserito e che si trovano nell'oggetto
            String us = source.GetValue("username").ToString();
            String ps = source.GetValue("password").ToString();

            // collego l'utente al server, se però ritorna null vuol dire che l'account non esiste
            GameUser mioUtente = GameUser.Login(us, ps, xDoc);

            // controllo che non sia null e che non sia già loggato
            if ((mioUtente != null) && (utentiLoggati.FirstOrDefault(u => u.Username == us && u.Password == ps) == null))
            {
                // lo aggiungo alla lista degli utenti loggati
                utentiLoggati.Add(new GameUser(mioUtente.Name, mioUtente.Surname, mioUtente.Username, mioUtente.Password, mioUtente.Total_match_played, mioUtente.Win_match, mioUtente.Registration_date));
                return true;
            }
            return false;
        }


        // un controllo non action in quanto viene utilizzato soltanto qui, serve per cercare se un utente esiste o no dentro il file xml
        [NonAction]
        public bool CercaTipo(string username)
        {
            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));
            foreach (XElement x in xDoc.Descendants("user").ToList())
            {
                if (username == x.Element("username").Value)
                    return true;   // ritorna true se l'username esiste
            }
            return false;   // false se non esiste
        }


        // controller register
        [HttpPost]
        [Route("api/rps/register")]
        public string Register([FromBody] Newtonsoft.Json.Linq.JObject source)
        {
            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));

            // prendo i dati inseriti dall'utente
            String sn = source.GetValue("surname").ToString();
            String na = source.GetValue("name").ToString();
            String us = source.GetValue("username").ToString();
            String ps = source.GetValue("password").ToString();

            GameUser myUser = new GameUser();

            // controllo che non ci siano spazi vuoti
            if (sn != "" && na != "" && us != "" && ps != "")
            {
                // controllo che l'utente non esistà già
                if (CercaTipo(us) == false) /// se non esiste deve crearlo
                {
                    myUser.Name = na;
                    myUser.Surname = sn;    //suriname
                    myUser.Username = us;   //god bless america
                    myUser.Password = ps;
                    myUser.Register(xDoc, HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));
                    return "The account has been added to our Databases";
                }
                else
                    return "Username already taken";
            }
            else
                return "Some of the fields aren't compailed";
        }

        // controllo per il logout
        [HttpGet]
        [Route("api/rps/logout/{username}")]
        public bool Logout(string username)
        {
            GameUser removedUser = utentiLoggati.FirstOrDefault(u => u.Username == username);
            // controllo che l'utente sia loggato
            if(removedUser != null)
            {
                utentiLoggati.Remove(removedUser);
                return true;
            }
            return false;
        }

        // controller che ritorna i dati dell'utente, usata per le statistiche dell'utente
        [HttpGet]
        [Route("api/rps/userDetails/{username}")]
        public GameUser userDetails(string username)
        {
            GameUser user = utentiLoggati.FirstOrDefault(u => u.Username == username);
            return user;
        }

        // controller che viene chiamato quando il pulsante "Play!" viene premuto

        [HttpGet]
        [Route("api/rps/playButtoned/{username}")]
        public void PlayButtoned(string username)
        {
            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));
            GameUser gUser = utentiLoggati.FirstOrDefault(u => u.Username == username);
            gUser.IsSearching = true;
            if (gUser.IsSearching == true)
            {
                if (utentiLoggati.Count(u => u.IsPlaying == false && u.IsSearching == true) >= Match.userNumber)
                {
                    List<GameUser> ltPartita = utentiLoggati.Where(u => u.IsPlaying == false).ToList().GetRange(0, Match.userNumber);
                    Match p = new Match(ltPartita);
                    gamePlay.Add(p);
                }
            }
            //return gUser;
            //return null;

        }

        // controller per trovare la partita in cui si trova un utente
        [HttpGet]
        [Route("api/rps/checkGame/{username}")]
        public Match CheckGame(string username)
        {
            return gamePlay.FirstOrDefault(g => g.UserList.FirstOrDefault(u => u.Username == username) != null);
        }
        
        // controller che incrementa il numero di partite giovate e vinte di un utente
        [HttpGet]
        [Route("api/rps/winIncrement/{username}")]
        public void WinIncrement(string username)
        {
            GameUser gamer= utentiLoggati.FirstOrDefault(u => u.Username == username);
            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));
            gamer.WinIncrement(gamer.Username, gamer.Password, xDoc, HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));
        }

        // controller che incrementa il numero partite giocate
        [HttpGet]
        [Route("api/rps/totMIncrement/{username}")]
        public void TotMIncrement(string username)
        {
            GameUser gamer = utentiLoggati.FirstOrDefault(u => u.Username == username);
            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));
            gamer.MatchIncrement(gamer.Username, gamer.Password, xDoc, HttpContext.Current.Server.MapPath("~/App_Data/XMLUsers.xml"));
        }

        // controller che determina il vincitore di una round
        [HttpGet]
        [Route("api/rps/gameWinner/{username}")]
        public GameUser GameWinner(string username)
        {
            Match m = gamePlay.FirstOrDefault(partita => partita.UserList.FirstOrDefault(user => user.Username == username) != null);
            return m.GameWinner();
        }

        // controller che aggiunge le mosse e chi ha fatto la mossa dentro le liste
        [HttpGet]
        [Route("api/rps/getMove/{move}/{username}")]
        public void GetMove(string move, string username)
        {
            Match m = gamePlay.FirstOrDefault(p => p.UserList.FirstOrDefault(user => user.Username == username) != null);
            m.GetMove(username, move);
        }

        [HttpGet]
        [Route("api/rps/isPlayingOff/{username}")]
        public void IsPlayingOff(string username)
        {
            GameUser gamer = utentiLoggati.FirstOrDefault(u => u.Username == username);
            Match p = gamePlay.FirstOrDefault(partita => partita.UserList.FirstOrDefault(user => user.Username == username) != null);
            gamePlay.Remove(p);
            gamer.IsSearching = false;
            gamer.IsPlaying = false;
        }



        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}