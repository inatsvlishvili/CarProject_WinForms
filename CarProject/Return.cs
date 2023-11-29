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
    public partial class Return : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContext();
        public Return()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hom = new Home();
            hom.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rental rent = new Rental();
            rent.Show();
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

        private void RefreshGrid()
        {
            datagridreturn.DataSource = _dbcontext.Rentals.ToList();
        }
    }
}
