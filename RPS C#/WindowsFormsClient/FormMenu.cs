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
    
    public partial class FormMenu : Form
    {
        ServiceReferenceGame.GameUser myUser;
        ServiceReferenceGame.GameUser myEnemy;
        ServiceReferenceGame.Match myMatch;
        ServiceReferenceGame.ServiceGameSoapClient myClient;


        Point lastPoint;

        public FormMenu(ServiceReferenceGame.GameUser myUser)
        {
            InitializeComponent();
            myClient = new ServiceReferenceGame.ServiceGameSoapClient();
            this.myUser = myUser;
            myUser.IsPlaying = false;
            lbBenvenuto.Text = "WELCOME " + myUser.Name;


            m_aeroEnabled = false;

            this.FormBorderStyle = FormBorderStyle.None;

        }
    

        private void btnLogout_Click(object sender, EventArgs e)
        {
            myClient = new ServiceReferenceGame.ServiceGameSoapClient();
            myClient.Logout(myUser.Username);
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnGetMatch_Click(object sender, EventArgs e)
        {
            btnLogout.Enabled = false;
            
            if (myUser.IsPlaying == true)
            {
                myMatch = myClient.GetMatchByUser(myUser.Username);
                myUser = myMatch.UserList.FirstOrDefault(u => u.Username == myUser.Username);
            }
            myUser = myClient.PlayButtoned(myUser.Username, myUser.Password);
            timerSearching.Start();   
        }

        private void timerSearching_Tick(object sender, EventArgs e)
        {
            myMatch = myClient.GetMatchByUser(myUser.Username);
            if (myMatch != null)
            {
                lbStatus.Text = "Player found!";
                timerSearching.Stop();
                myUser = myMatch.UserList.FirstOrDefault(u => u.Username == myUser.Username);
                myEnemy = myMatch.UserList.FirstOrDefault(u => u.Username != myUser.Username);
                FormGame f = new FormGame(myUser, myEnemy, myMatch);
                f.Show();
                this.Hide();
            }
            else
            {
                lbStatus.Text = "Searching for players...";
            }
        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            myClient = new ServiceReferenceGame.ServiceGameSoapClient();
            myClient.Logout(myUser.Username);
            System.Windows.Forms.Application.ExitThread();
        }

        private void minimiseGame_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPartita_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void FormPartita_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btStats_Click(object sender, EventArgs e)
        {
            FormStats fs = new FormStats(myUser);
            fs.Show();
        }

        //----------------------------------------------------DROP SHADOW DEL WINDOWS FORM------------------------------------------------

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
