using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProject
{
    public partial class DashBoard : Form
    {

        public DashBoard()
        {
            InitializeComponent();
        }


        bool sidebarExpand;
        bool settingColapsed;
        private void sidebarmenutimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 40;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarmenutimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 40;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarmenutimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarmenutimer.Start();
        }

        private void settingtimer_Tick(object sender, EventArgs e)
        {

            if (settingColapsed)
            {
                settingpanel.Width -= 40;
                if (settingpanel.Width == settingpanel.MinimumSize.Width)
                {
                    AddRemoveCarBTN.Hide();
                    AddRemoveClientsBTN.Hide();
                    settingColapsed = false;
                    settingtimer.Stop();
                }
            }
            else
            {
                settingpanel.Width += 40;
                if (settingpanel.Width == settingpanel.MaximumSize.Width)
                {
                    AddRemoveCarBTN.Show();
                    AddRemoveClientsBTN.Show();
                    settingColapsed = true;
                    settingtimer.Stop();
                }
            }
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            settingtimer.Start();
        }

       
    }
}

