using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameLibrary
{
    public class Match
    {
        private List<GameUser> userList;
        private int round;
        private DateTime matchStart;
        private DateTime? matchFinish;
        private GameUser winner;
        public static int userNumber = 2;

        private List<string> usersList = new List<string>(2);
        private List<string> movesList = new List<string>(2);

        public Match() { }

        public Match(List<GameUser> userList)
        {
            this.userList = userList;
            this.round = 0;
            matchStart = DateTime.Now;
            matchFinish = null;
            winner = null;

            foreach(GameUser g in userList)
            {
                g.IsPlaying = true;
            }          
        }


        public List<GameUser> UserList { get => userList; set => userList = value; }
        public int Round { get => round; set => round = value; }
        public DateTime MatchStart { get => matchStart; set => matchStart = value; }
        public DateTime? MatchFinish { get => matchFinish; set => matchFinish = value; }
        public GameUser Winner { get => winner; set => winner = value; }
        public List<string> MovesList { get => movesList; set => movesList = value; }
        public List<string> UsersList { get => usersList; set => usersList = value; }

        public void GetMove(string username, string move)   // aggiungo in 2 liste diverse i valori delle mosse degli utenti(username) per dopo usarle nel GameWinner()
        {
            //se movelist contiene 2 elementi, allora puliscila
            if (movesList.Count == 2)
            {
                movesList = new List<string>(2);
                usersList = new List<string>(2);
            }
            
            movesList.Add(move);
            usersList.Add(username);
        }
        
        public GameUser GameWinner()            // funzione che stabilisce il vincitore della partita
        {
            if (movesList[0] == movesList[1])   // se i 2 valori sono uguali allora e' pareggio
                return null;

            if (movesList[0]=="sasso") {
                if (movesList[1] == "carta")
                {
                    return userList.FirstOrDefault(u => u.Username == usersList.ElementAt(1));
                }
                if (movesList[1] == "forbici")
                {
                    return userList.FirstOrDefault(u => u.Username == usersList.ElementAt(0));
                }
            }
            if (movesList[0] == "forbici")
            {
                if (movesList[1] == "sasso")
                {
                    return userList.FirstOrDefault(u => u.Username == usersList.ElementAt(1));
                }
                if (movesList[1] == "carta")
                {
                    return userList.FirstOrDefault(u => u.Username == usersList.ElementAt(0));
                }
            }
            if (movesList[0] == "carta")
            {
                if (movesList[1] == "forbici")
                {
                    return userList.FirstOrDefault(u => u.Username == usersList.ElementAt(1));
                }
                if (movesList[1] == "sasso")
                {
                    return userList.FirstOrDefault(u => u.Username == usersList.ElementAt(0));
                }
            }
            return null;    // non dovrebbe mai arrivare qua, pero' di default deve ritornare qualcosa, quindi se per caso qualcosa non dovesse funzionare ritorniamo "pareggio"
        }



    }
}
