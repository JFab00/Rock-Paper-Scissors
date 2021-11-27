using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GameLibrary;
using System.Xml.Linq;

namespace WebServiceGame
{
    /// <summary>
    /// Descrizione di riepilogo per ServiceGame
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceGame : System.Web.Services.WebService
    {
        private static List<GameUser> gameUserList = new List<GameUser>();
        private static List<Match> gamePlay = new List<Match>();

        public XDocument loadDoc(string url)
        {
            XDocument xDoc = XDocument.Load(getPath(url));
            if (xDoc != null)
                return xDoc;
            return null;
        }

        private string getPath(string url)
        {
            return Server.MapPath(url);
        }

        [WebMethod]
        public GameUser Login(string username, string password)
        {
            if (gameUserList.FirstOrDefault(u => u.Username == username) == null)
            {
                XDocument xDoc = XDocument.Load(Server.MapPath("App_Data/XMLUsers.xml"));
                GameUser gUser = GameUser.Login(username, password, xDoc);
                if(gUser != null)
                    gameUserList.Add(gUser);
                return gUser;

            }return null;
        }

        [WebMethod]
        public void Register(GameUser g)    // registro l'utente
        {
            g.Register(loadDoc("App_Data/XMLUsers.xml"), getPath("App_Data/XMLUsers.xml"));

        }


        [WebMethod]
        public bool Logout(string username)
        {
            GameUser removedUser = gameUserList.FirstOrDefault(u => u.Username == username);
            if(removedUser != null)
            {
                gameUserList.Remove(removedUser);
                return true;
            }return false;
        }

        [WebMethod]
        public GameUser PlayButtoned(string username, string password)
        {
            XDocument xDoc = XDocument.Load(Server.MapPath("App_Data/XMLUsers.xml"));
            GameUser gUser = GameUser.Login(username, password, xDoc);
            //DETERMINO AVVIO PARTITA   
            if (gameUserList.Count(u => !u.IsPlaying) >= Match.userNumber)
            {
                List<GameUser> ltPartita = gameUserList.Where(u => u.IsPlaying == false).ToList().GetRange(0,Match.userNumber);
                Match p = new Match(ltPartita);
                gamePlay.Add(p);
            }
            return gUser;
        }

        [WebMethod]
        public Match GetMatchByUser(string username)
        {
            return gamePlay.FirstOrDefault(g => g.UserList.FirstOrDefault(u => u.Username == username) != null); // per ogni partita cerchiamo la prima che trovi nella propria lista utente un utente con lo username passato  
        }

        [WebMethod]
          public bool CercaTipo(string username)
          {
              XDocument xDoc = XDocument.Load(getPath("App_Data/XMLUsers.xml"));
              foreach (XElement x in xDoc.Descendants("user").ToList())
              {
           
                  if (username == x.Element("username").Value)
                      return true;   // ritorna true se l'username esiste
              }   
              return false;   // false se non esiste
          }



        [WebMethod]
        public void Get_move(string username, string move)
        {
            Match m = gamePlay.FirstOrDefault(partita => partita.UserList.FirstOrDefault(user => user.Username == username) != null);
            m.GetMove(username, move);
        }
        

        [WebMethod]
        public GameUser Game_winner(string username)
        {
            Match m = gamePlay.FirstOrDefault(partita => partita.UserList.FirstOrDefault(user => user.Username == username) != null); 
            return m.GameWinner();
        }

        [WebMethod]
        public void WinIncrement(GameUser g)
        {
            g.WinIncrement(g.Username, g.Password, loadDoc("App_Data/XMLUsers.xml"), getPath("App_Data/XMLUsers.xml"));
        }

        [WebMethod]
        public void TotMIncrement(GameUser g)
        {
            g.MatchIncrement(g.Username, g.Password, loadDoc("App_Data/XMLUsers.xml"), getPath("App_Data/XMLUsers.xml"));
        }
    }
}
