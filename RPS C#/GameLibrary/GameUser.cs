using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameLibrary
{
    public class GameUser
    {
        private string name;
        private string surname;
        private string username;
        private string password;
        private int    total_match_played;
        private int    win_match;
        private DateTime registration_date;
        private bool isPlaying;
        private int points;
        
        public GameUser(string name, string surname, string username, string password)
        {
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;

            isPlaying = false;
            registration_date = DateTime.Today;
            win_match = 0;
            total_match_played = 0;
            Points = 0;
        }

        public GameUser()
        {

        }

        //costruttore
        public GameUser(string name, string surname, string username, string password, int total_match_played, int win_match, DateTime registration_date)
        {
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.total_match_played = total_match_played;
            this.win_match = win_match;
            this.registration_date = registration_date;
            isPlaying = false;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Total_match_played { get => total_match_played; set => total_match_played = value; }
        public int Win_match { get => win_match; set => win_match = value; }
        public DateTime Registration_date { get => registration_date; set => registration_date = value; }
        public bool IsPlaying { get => isPlaying; set => isPlaying = value; }
        public int Points { get => points; set => points = value; }

        public static GameUser Login(string username,string password,XDocument xDoc)
        {
            XElement myUser = xDoc.Descendants("user").FirstOrDefault(u => u.Element("username").Value == username && u.Element("password").Value == password);
            if (myUser != null)
            {
                GameUser newUser = new GameUser(myUser.Element("name").Value,
                    myUser.Element("surname").Value,myUser.Element("username").Value,
                    myUser.Element("password").Value, Convert.ToInt32(myUser.Element("totmatch").Value),
                    Convert.ToInt32(myUser.Element("winmatch").Value),
                    Convert.ToDateTime(myUser.Element("regdate").Value));
                return newUser;
            }
            else return null;
        }

        public void Register(XDocument xDoc, string url)        // aggiungo i valori nell'XML
        {
            XElement radice = xDoc.Element("users");
            XElement myUser = new XElement("user");
            myUser.Add(new XElement("name", name));
            myUser.Add(new XElement("surname", surname));
            myUser.Add(new XElement("username", username));
            myUser.Add(new XElement("password", password));
            myUser.Add(new XElement("regdate", DateTime.Now)); // data della registrazione
            myUser.Add(new XElement("totmatch", 0));     // 0 di default
            myUser.Add(new XElement("winmatch", 0));    // 0 di default
            
            radice.Add(myUser);   // salvo i dettagli nell'xml
            xDoc.Save(url);
        }

        public void WinIncrement(string username,string password, XDocument xDoc, string url)
        {
            //XElement myUser = xDoc.Descendants("user").FirstOrDefault(u => u.Element("username").Value == username && u.Element("password").Value == password);
            foreach(XElement User in xDoc.Descendants("user").ToList())
            {
              if (username == User.Element("username").Value && password == User.Element("password").Value)
                {
                    int app = Convert.ToInt32(User.Element("winmatch").Value);
                    app++;
                    User.Element("winmatch").Value = app.ToString();
                    app = Convert.ToInt32(User.Element("totmatch").Value);
                    app++;
                    User.Element("totmatch").Value = app.ToString();
                }
            }
            xDoc.Save(url);
        }

        public void MatchIncrement(string username, string password, XDocument xDoc, string url)
        {
            foreach (XElement User in xDoc.Descendants("user").ToList())
            {
                if (username == User.Element("username").Value && password == User.Element("password").Value)
                {
                    int app = Convert.ToInt32(User.Element("totmatch").Value);
                    app++;
                    User.Element("totmatch").Value = app.ToString();
                }
            }
            xDoc.Save(url);
        }
    }
}
