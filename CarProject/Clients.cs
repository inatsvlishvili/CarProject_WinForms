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
    public partial class Clients : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContext();
        public Clients()
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

        private void button4_Click(object sender, EventArgs e)
        {
            Return returns = new Return();
            returns.Show();
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
            datagridclient.DataSource = _dbcontext.Client.ToList();
        }

        //private void datagridclient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Rental rent = new Rental();

        //    rent.ReFirstNameTXT.Text = datagridclient.Rows[datagridclient.CurrentRow.Index].Cells[1].Value.ToString();
        //    rent.ReLastNameTXT.Text = datagridclient.Rows[datagridclient.CurrentRow.Index].Cells[2].Value.ToString();
        //    rent.RePasportNumberTXT.Text = datagridclient.Rows[datagridclient.CurrentRow.Index].Cells[3].Value.ToString();
        //    rent.RePhoneTXT.Text = datagridclient.Rows[datagridclient.CurrentRow.Index].Cells[4].Value.ToString();
        //    rent.RePhone2TXT.Text = datagridclient.Rows[datagridclient.CurrentRow.Index].Cells[5].Value.ToString();
        //    rent.ReAddressTXT.Text = datagridclient.Rows[datagridclient.CurrentRow.Index].Cells[6].Value.ToString();
        //    rent.Show();
            
        //}

        private void SearchClient_TextChanged(object sender, EventArgs e)
        {
            if (SearchClient.Text != string.Empty)
            {
                var search = _dbcontext.Client.Where(s => s.FirstName.Contains(SearchClient.Text)
                || s.LastName.Contains(SearchClient.Text)
                || s.PasportID.Contains(SearchClient.Text)
                || s.Phone.Contains(SearchClient.Text)
                || s.Phone2.Contains(SearchClient.Text)
                || s.Address.Contains(SearchClient.Text));


                datagridclient.DataSource = search.ToList();
            }
            else
            {
                RefreshGrid();
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            Clientlbl.Text = _dbcontext.Client.Count().ToString();
        }
    }
}
