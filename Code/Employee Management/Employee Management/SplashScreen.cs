using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (panelLoading.Width >= 500 && panelLoading.Width <= 535)
            {
                timerLoad.Interval = 700;
                panelLoading.Width += 10;
            }
            else
            {
                timerLoad.Interval = 15;
                panelLoading.Width += 3;
            }
            if (panelLoading.Width >= 700)
            {
                timerLoad.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
