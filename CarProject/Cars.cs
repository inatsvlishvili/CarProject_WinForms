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
    public partial class Cars : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContext();
        public Cars()
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
        private void FilterGrid()
        {


            if (searchTXT.Text != string.Empty)
            {
                var search = _dbcontext.Car.Where(s => s.Brand.Contains(searchTXT.Text));
                search = _dbcontext.Car.Where(s => s.Model.Contains(searchTXT.Text));
                search = _dbcontext.Car.Where(s => s.RegNumber.Contains(searchTXT.Text));
                //search = _dbcontext.Car.Where(s => s.Quantity.Contains(searchTXT.Text));
                //search = _dbcontext.Car.Where(s => s.Price.Contains(searchTXT.Text));



                datagridcar.DataSource = search.ToList();
            }
        }
        
        private void RefreshGrid()
        {
            datagridcar.DataSource = _dbcontext.Car.ToList();
        }

        //private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Rental rent = new Rental();
        //    rent.ReBrandTXT.Text = datagridcar.Rows[datagridcar.CurrentRow.Index].Cells[1].Value.ToString();
        //    rent.ReModelTXT.Text = datagridcar.Rows[datagridcar.CurrentRow.Index].Cells[2].Value.ToString();
        //    rent.ReRegNumberTXT.Text = datagridcar.Rows[datagridcar.CurrentRow.Index].Cells[3].Value.ToString();
        //    rent.ReQuantityTXT.Text = datagridcar.Rows[datagridcar.CurrentRow.Index].Cells[4].Value.ToString();
        //    rent.RePriceTXT.Text = datagridcar.Rows[datagridcar.CurrentRow.Index].Cells[5].Value.ToString();

        //}
        public bool formIsExist(Form frmOpen)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == frmOpen.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private void searchTXT_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            Carlbl.Text = _dbcontext.Car.Count().ToString();
        }
    }
}
