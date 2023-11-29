using CarProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ApplicationDbContext dbcontext = new ApplicationDbContext();
       

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            string loguser = userametxt.Text;
            int logpass = Convert.ToInt32(passwordtxt.Text);

            try
            {
                if (dbcontext.User.Where(t => t.UserName == loguser && t.UserPass == logpass).Count() > 0)
                {
                    UserPanel user = new UserPanel();
                    user.Show();
                    this.Hide();
                }
                else if (dbcontext.User.Where(r => r.AdminName == loguser
                && r.AdminPass == logpass).Count() > 0)
                {
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
