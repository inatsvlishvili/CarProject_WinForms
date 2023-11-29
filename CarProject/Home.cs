using CarProject.Data;
using CarProject.Models;
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
    public partial class Home : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContext();
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars Car = new Cars();
            Car.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rental rent = new Rental();
            rent.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Return returns = new Return();
            returns.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.Show();
            this.Hide();
        }

        private void AddRemoveCarBTN_Click(object sender, EventArgs e)
        {
            AddCarPanel addcar = new AddCarPanel();
            addcar.Show();
            this.Hide();
        }

        private void AddRemoveClientsBTN_Click(object sender, EventArgs e)
        {
            AddClientPanel addclient = new AddClientPanel();
            addclient.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            History hist = new History();
            hist.Show();
            this.Hide();
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            Carlbl.Text = _dbcontext.Car.Count().ToString();
            Clientlbl.Text = _dbcontext.Client.Count().ToString();
            Rentallbl.Text = _dbcontext.Rentals.Count().ToString();

        }
    }
}
