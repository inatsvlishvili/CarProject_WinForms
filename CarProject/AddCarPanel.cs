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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarProject
{
    public partial class AddCarPanel : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContext();
        public AddCarPanel()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.Show();
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
            datagdwCar.DataSource = _dbcontext.Car.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }


        private void Reset()
        {
            BrandTXT.Text = string.Empty;
            ModelTXT.Text = string.Empty;
            RegNumberTXT.Text = string.Empty;
            QuantityTXT.Text = string.Empty;
            PriceTXT.Text = string.Empty;
        }


        private void FilterGrid()
        {

            if (searchTXT.Text != string.Empty)
            {
                var search = _dbcontext.Car.Where(s => s.Brand.Contains(searchTXT.Text)
                || s.Model.Contains(searchTXT.Text)
                || s.RegNumber.Contains(searchTXT.Text));
                //|| s.Quantity.Contains(searchTXT.Text)
                //|| s.Price.Contains(searchTXT.Text));


                datagdwCar.DataSource = search.ToList();
            }
            else
            {
                RefreshGrid();
            }
        }
        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                DBCars car = new DBCars();
                car.Brand = BrandTXT.Text;
                car.Model = ModelTXT.Text;
                car.RegNumber = RegNumberTXT.Text;
                car.Quantity = Convert.ToInt32(QuantityTXT.Text);
                car.Price = Convert.ToInt32(PriceTXT.Text);


                _dbcontext.Car.Add(car);
                _dbcontext.SaveChanges();

                MessageBox.Show("Successfully Saved Car");

                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click_1(object sender, EventArgs e)
        {
            var caredit = _dbcontext.Car.FirstOrDefault();
            if (caredit != null)
            {
                caredit.Brand = BrandTXT.Text;
                caredit.Model = ModelTXT.Text;
                caredit.RegNumber = RegNumberTXT.Text;
                caredit.Quantity = Convert.ToInt32(QuantityTXT.Text);
                caredit.Price = Convert.ToInt32(PriceTXT.Text);

                _dbcontext.Car.Update(caredit);
                _dbcontext.SaveChanges();
                RefreshGrid();
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

            var selIndex = datagdwCar.CurrentCell.RowIndex;
            var id = (int)datagdwCar.Rows[selIndex].Cells[0].Value;

            var carToDelete = _dbcontext.Car.SingleOrDefault(x => x.ID == id);
            if (carToDelete != null)
            {
                _dbcontext.Car.Remove(carToDelete);
                _dbcontext.SaveChanges();
                MessageBox.Show("Car Successfully Deleted");
                RefreshGrid();
            }

        }
        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void datagdwCar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BrandTXT.Text = datagdwCar.Rows[datagdwCar.CurrentRow.Index].Cells[1].Value.ToString();
            ModelTXT.Text = datagdwCar.Rows[datagdwCar.CurrentRow.Index].Cells[2].Value.ToString();
            RegNumberTXT.Text = datagdwCar.Rows[datagdwCar.CurrentRow.Index].Cells[3].Value.ToString();
            QuantityTXT.Text = datagdwCar.Rows[datagdwCar.CurrentRow.Index].Cells[4].Value.ToString();
            PriceTXT.Text = datagdwCar.Rows[datagdwCar.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void AddCarPanel_Load(object sender, EventArgs e)
        {
            Carlbl.Text = _dbcontext.Car.Count().ToString();
        }

        //bool sidebarExpand;
        //bool settingColapsed;
        //private void sidebartimer_Tick(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        sidebar.Width -= 40;
        //        if (sidebar.Width == sidebar.MinimumSize.Width)
        //        {
        //            sidebarExpand = false;
        //            sidebarmenutimer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        sidebar.Width += 40;
        //        if (sidebar.Width == sidebar.MaximumSize.Width)
        //        {
        //            sidebarExpand = true;
        //            sidebarmenutimer.Stop();
        //        }
        //    }
        //}

        //private void settingtimer_Tick(object sender, EventArgs e)

        //if (settingColapsed)
        //{
        //    settingpanel.Width -= 40;
        //    if (settingpanel.Width == settingpanel.MinimumSize.Width)
        //    {
        //        AddRemoveCarBTN.Hide();
        //        AddRemoveClientsBTN.Hide();
        //        settingColapsed = false;
        //        settingtimer.Stop();
        //    }
        //}
        //else
        //{
        //    settingpanel.Width += 40;
        //    if (settingpanel.Width == settingpanel.MaximumSize.Width)
        //    {
        //        AddRemoveCarBTN.Show();
        //        AddRemoveClientsBTN.Show();
        //        settingColapsed = true;
        //        settingtimer.Stop();
        //    }
        //}
    }
}
