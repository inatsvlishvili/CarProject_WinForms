using CarProject.Models;
using CarProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProject
{
    public partial class AddClientPanel : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContext();

        public AddClientPanel()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            datagdwClients.DataSource = _dbcontext.Client.ToList();
        }


        private void refreshbtn_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }



        private void datagdwClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FirstNameTXT.Text = datagdwClients.Rows[datagdwClients.CurrentRow.Index].Cells[1].Value.ToString();
            LastNameTXT.Text = datagdwClients.Rows[datagdwClients.CurrentRow.Index].Cells[2].Value.ToString();
            PasportNumberTXT.Text = datagdwClients.Rows[datagdwClients.CurrentRow.Index].Cells[3].Value.ToString();
            PhoneTXT.Text = datagdwClients.Rows[datagdwClients.CurrentRow.Index].Cells[4].Value.ToString();
            Phone2TXT.Text = datagdwClients.Rows[datagdwClients.CurrentRow.Index].Cells[5].Value.ToString();
            AddressTXT.Text = datagdwClients.Rows[datagdwClients.CurrentRow.Index].Cells[6].Value.ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {
            History hist = new History();
            hist.Show();
            this.Hide();
        }


        private void FilterGrid()
        {

            if (searchclient.Text != string.Empty)
            {
                var search = _dbcontext.Client.Where(s => s.FirstName.Contains(searchclient.Text)
                || s.LastName.Contains(searchclient.Text)
                || s.PasportID.Contains(searchclient.Text)
                || s.Phone.Contains(searchclient.Text)
                || s.Phone2.Contains(searchclient.Text)
                || s.Address.Contains(searchclient.Text));


                datagdwClients.DataSource = search.ToList();
            }
            else
            {
                RefreshGrid();
            }
        }

        private void searchTXT_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void editbtn_Click_1(object sender, EventArgs e)
        {
            var clientedit = _dbcontext.Client.FirstOrDefault();
            if (clientedit != null)
            {
                clientedit.FirstName = FirstNameTXT.Text;
                clientedit.LastName = LastNameTXT.Text;
                clientedit.PasportID = PasportNumberTXT.Text;
                clientedit.Phone = PhoneTXT.Text;
                clientedit.Phone2 = Phone2TXT.Text;
                clientedit.Address = AddressTXT.Text;

                _dbcontext.Client.Update(clientedit);
                _dbcontext.SaveChanges();
                RefreshGrid();
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                DBClients Clients = new DBClients();
                Clients.FirstName = FirstNameTXT.Text;
                Clients.LastName = LastNameTXT.Text;
                Clients.PasportID = PasportNumberTXT.Text;
                Clients.Phone = PhoneTXT.Text;
                Clients.Phone2 = Phone2TXT.Text;
                Clients.Address = AddressTXT.Text;

                _dbcontext.Client.Add(Clients);
                _dbcontext.SaveChanges();

                MessageBox.Show("Successfully Saved Client");

                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {

            var selIndex = datagdwClients.CurrentCell.RowIndex;
            var id = (int)datagdwClients.Rows[selIndex].Cells[0].Value;

            var ClientToDelete = _dbcontext.Client.SingleOrDefault(x => x.ID == id);
            if (ClientToDelete != null)
            {
                _dbcontext.Client.Remove(ClientToDelete);
                _dbcontext.SaveChanges();
                MessageBox.Show("Client Successfully Deleted");
                RefreshGrid();
            }

        }

        private void resetbtn_Click_1(object sender, EventArgs e)
        {

            FirstNameTXT.Text = string.Empty;
            LastNameTXT.Text = string.Empty;
            PasportNumberTXT.Text = string.Empty;
            PhoneTXT.Text = string.Empty;
            Phone2TXT.Text = string.Empty;
            AddressTXT.Text = string.Empty;
        }

        private void AddClientPanel_Load(object sender, EventArgs e)
        {
            Clientlbl.Text = _dbcontext.Client.Count().ToString();
        }
    }
}


