using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormGame : Form
    {
        ServiceReferenceGame.GameUser myUser;
        ServiceReferenceGame.GameUser myEnemy;
        ServiceReferenceGame.Match myMatch = new ServiceReferenceGame.Match();
        ServiceReferenceGame.ServiceGameSoapClient myClient = new ServiceReferenceGame.ServiceGameSoapClient();

        public FormGame(ServiceReferenceGame.GameUser myUser,ServiceReferenceGame.GameUser myEnemy, ServiceReferenceGame.Match myMatch)
        {
            InitializeComponent();
            this.myUser = myUser;
            this.myEnemy = myEnemy;
            lbYou.Text = myUser.Username;
            lbEnemy.Text = myEnemy.Username;

        }

        private void btSasso_Click(object sender, EventArgs e)
        {
            myClient.Get_move(myUser.Username, Convert.ToString(btSasso.Tag));      // se il button viene premuto, prendo il nome del button e lo aggiungo alla lista
            btSasso.Enabled = false;
            btForbici.Enabled = false;
            btCarta.Enabled = false;
            btSasso.BackgroundImage = Properties.Resources.rockB;           // cambio immagine per farla diventare piu' scura
            btCarta.BackgroundImage = Properties.Resources.paperB;
            btForbici.BackgroundImage = Properties.Resources.scissorsB;
            timer.Enabled = true;       // abilito il timer che fa i controlli delle round
        }
        private void btCarta_Click(object sender, EventArgs e)
        {
            myClient.Get_move(myUser.Username, Convert.ToString(btCarta.Tag));
            btSasso.Enabled = false;
            btForbici.Enabled = false;
            btCarta.Enabled = false;
            btSasso.BackgroundImage = Properties.Resources.rockB;
            btCarta.BackgroundImage = Properties.Resources.paperB;
            btForbici.BackgroundImage = Properties.Resources.scissorsB;
            timer.Enabled = true;
        }

        private void btForbici_Click(object sender, EventArgs e)
        {
            myClient.Get_move(myUser.Username, Convert.ToString(btForbici.Tag));
            btSasso.Enabled = false;
            btForbici.Enabled = false;
            btCarta.Enabled = false;
            btSasso.BackgroundImage = Properties.Resources.rockB;
            btCarta.BackgroundImage = Properties.Resources.paperB;
            btForbici.BackgroundImage = Properties.Resources.scissorsB;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)     
        {
            myMatch = myClient.GetMatchByUser(myUser.Username); // attribuisco a mymatch i dettagli della partita
            if (myMatch.MovesList.Count == 2)  // controllo se entrambi gli utenti hanno cliccato un button 
            {                
                myMatch.Winner = myClient.Game_winner(myUser.Username); // ritorno il vincitore del round
                timer.Enabled = false;      // disabilito il timer.
                if (myMatch.Winner == null)     // se il winner e' null, vuol dire che entrambi gli utenti hanno premuto lo stesso button, e quindi e' pareggio
                {
                    lbGameStatus.ForeColor = Color.White;
                    lbGameStatus.Text = "Tie!";
                    timerRisultato.Enabled = true;
                }
                else if ((myMatch.Winner.Username == myUser.Username) && (myUser.Points != 3) && (myEnemy.Points != 3))     // controllo del vincitore della round, se sono uguali vuol dire che l'utente ha vinto
                {
                    lbGameStatus.ForeColor = Color.Green;
                    lbGameStatus.Text = "You Won";
                    myUser.Points++;        // incremento il punteggio dell'utente
                    timerRisultato.Enabled = true;  // abilito un timer di "cooldown" tra le partite
                }
                else if((myMatch.Winner.Username == myEnemy.Username) && (myUser.Points != 3) && (myEnemy.Points != 3))     // se invece il vincitore e' l'opponente, allora...
                {
                    lbGameStatus.ForeColor = Color.Red;
                    myEnemy.Points++;       // incremento il punteggio dell'opponente
                    lbGameStatus.Text = "You lost!";
                    timerRisultato.Enabled = true;
                }


                if ((myUser.Points == 3) && (myEnemy.Points != 3))  // l'utente ha vinto 3 round allora ha vinto la partita
                {
                    lbGameStatus.ForeColor = Color.Green;
                    lbGameStatus.Text = "Hai vinto, sei quasi come Cadel Evans!";
                    timer.Enabled = false;
                    myClient.WinIncrement(myUser);  // aggiorno gli stats nell'xml
                    myUser.Win_match++;             // aggiorno gli stats nella corrente sessione
                    myUser.Total_match_played++;
                    timerRisultato.Enabled = true;
                }
                else if ((myUser.Points != 3) && (myEnemy.Points == 3))     // se invece e' l'opponente che ha vinto i 3 round, allora...
                {
                    lbGameStatus.ForeColor = Color.Red;
                    lbGameStatus.Text = "Potevi e dovevi far meglio.";
                    timer.Enabled = false;
                    myClient.TotMIncrement(myUser);
                    myUser.Total_match_played++;
                    timerRisultato.Enabled = true;
                }

                lbPunteggio.Text = myUser.Points + " - " + myEnemy.Points;      // stampo i punteggi dei 2 giocatori
            }
        }

        private void timerRisultato_Tick(object sender, EventArgs e)        // il timer di cooldown tra le round
        {
            if ((myUser.Points == 3) || (myEnemy.Points == 3))      // se si e' arrivato alla fine della partita allora...
            {
                FormMenu f = new FormMenu(myUser);
                f.Show();
                this.Hide();
            }
            btSasso.Enabled = true;
            btForbici.Enabled = true;
            btCarta.Enabled = true;
            btSasso.BackgroundImage = Properties.Resources.rock;
            btCarta.BackgroundImage = Properties.Resources.paper;
            btForbici.BackgroundImage = Properties.Resources.scissors;

            myMatch.Winner = null;
            lbGameStatus.ForeColor = Color.White;
            lbGameStatus.Text = "Waiting for Opponent's response";
            timerRisultato.Stop();
        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void minimiseGame_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //----------------------------------------------------DROP SHADOW DEL WINDOWS FORM (presa da internet)------------------------------------------------

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }


        //-------------------------------------------------------------------------------------------------------------------------------------------
    }
}
