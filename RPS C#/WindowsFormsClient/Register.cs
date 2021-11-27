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
    public partial class Register : Form
    {
        Point lastPoint;
        public Register()
        {
            m_aeroEnabled = false;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
        }      

        private void lbLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void minimiseGame_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                tbPass.PasswordChar = Convert.ToChar(00);
            else
                tbPass.PasswordChar = Convert.ToChar("•");
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "USERNAME")
                tbUser.Text = "";
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
                tbUser.Text = "USERNAME";
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "PASSWORD")
            {
                tbPass.Text = "";
                tbPass.PasswordChar = Convert.ToChar("•");
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.Text = "PASSWORD";
                tbPass.PasswordChar = Convert.ToChar(00);
            }
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "NAME")
                tbName.Text = "";
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
                tbName.Text = "NAME";
        }

        private void tbSurname_Leave(object sender, EventArgs e)
        {
            if (tbSurname.Text == "")
                tbSurname.Text = "SURNAME";
        }

        private void tbSurname_Enter(object sender, EventArgs e)
        {
            if (tbSurname.Text == "SURNAME")
                tbSurname.Text = "";
        }

        private void ilru_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/fabianjrt.h/");
        }

        private void marti_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/marti0198/");
        }

        private void gio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/suagiovanni/");
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            ServiceReferenceGame.ServiceGameSoapClient myClient = new ServiceReferenceGame.ServiceGameSoapClient();
            ServiceReferenceGame.GameUser myUser = new ServiceReferenceGame.GameUser();
            if (tbName.Text != "NAME" && tbPass.Text != "PASSWORD" && tbUser.Text != "USERNAME" && tbSurname.Text != "SURNAME" && tbName.Text != "" && tbPass.Text != "" && tbUser.Text != "" && tbSurname.Text != "")
            {
                if (myClient.CercaTipo(tbUser.Text) == false)
                {
                      myUser.Name = tbName.Text;
                      myUser.Surname = tbSurname.Text;
                      myUser.Username = tbUser.Text;
                      myUser.Password = tbPass.Text;
                      myClient.Register(myUser);
                      lbStatus.Text = "The account has been added to our Databases";
                }
                else
                    lbStatus.Text = "Username already taken";
            }
            else
                lbStatus.Text = "Some of the fields weren't compailed";
        }

        //----------------------------------------------------DROP SHADOW DEL WINDOWS FORM --------------------------------------------------------

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
