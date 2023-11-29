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
    public partial class Rental : Form
    {
        ApplicationDbContext _dbcontext = new ApplicationDbContext();
        public Rental()
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

        private void Rental_Load(object sender, EventArgs e)
        {
            Rentallbl.Text = _dbcontext.Rentals.Count().ToString();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            FilterGridCar();
        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {
            FilterGridClient();
        }
        private void RefreshGrid()
        {
            datagridCar.DataSource = _dbcontext.Car.ToList();
            datagridClient.DataSource = _dbcontext.Client.ToList();

        }
        private void FilterGridCar()
        {

            if (SearchCar.Text != string.Empty)
            {
                var search = _dbcontext.Car.Where(s => s.Brand.Contains(SearchCar.Text)
                || s.Model.Contains(SearchCar.Text)
                || s.RegNumber.Contains(SearchCar.Text));
                //|| s.Quantity.Contains(searchTXT.Text)
                //|| s.Price.Contains(searchTXT.Text));


                datagridCar.DataSource = search.ToList();
            }
            else
            {
                FilterGridCar();
            }
        }
        private void FilterGridClient()
        {

            if (SearchClient.Text != string.Empty)
            {
                var search = _dbcontext.Client.Where(s => s.FirstName.Contains(SearchClient.Text)
                || s.LastName.Contains(SearchClient.Text)
                || s.Phone.Contains(SearchClient.Text)
                || s.PasportID.Contains(SearchClient.Text));
                //|| s.Quantity.Contains(searchTXT.Text)
                //|| s.Price.Contains(searchTXT.Text));


                datagridClient.DataSource = search.ToList();
            }
            else
            {
                FilterGridClient();
            }
        }

        private void datagridCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarIDTxt.Text = datagridCar.Rows[datagridCar.CurrentRow.Index].Cells[0].Value.ToString();
            ReBrandTXT.Text = datagridCar.Rows[datagridCar.CurrentRow.Index].Cells[1].Value.ToString();
            ReModelTXT.Text = datagridCar.Rows[datagridCar.CurrentRow.Index].Cells[2].Value.ToString();
            ReRegNumberTXT.Text = datagridCar.Rows[datagridCar.CurrentRow.Index].Cells[3].Value.ToString();
            ReQuantityTXT.Text = datagridCar.Rows[datagridCar.CurrentRow.Index].Cells[4].Value.ToString();
            RePriceTXT.Text = datagridCar.Rows[datagridCar.CurrentRow.Index].Cells[5].Value.ToString();



        }

        private void datagridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientIDTXT.Text = datagridClient.Rows[datagridClient.CurrentRow.Index].Cells[0].Value.ToString();
            ReFirstNameTXT.Text = datagridClient.Rows[datagridClient.CurrentRow.Index].Cells[1].Value.ToString();
            ReLastNameTXT.Text = datagridClient.Rows[datagridClient.CurrentRow.Index].Cells[2].Value.ToString();
            RePasportNumberTXT.Text = datagridClient.Rows[datagridClient.CurrentRow.Index].Cells[3].Value.ToString();
            RePhoneTXT.Text = datagridClient.Rows[datagridClient.CurrentRow.Index].Cells[4].Value.ToString();
            RePhone2TXT.Text = datagridClient.Rows[datagridClient.CurrentRow.Index].Cells[5].Value.ToString();
            ReAddressTXT.Text = datagridClient.Rows[datagridClient.CurrentRow.Index].Cells[6].Value.ToString();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            int totalDays = Convert.ToInt32((DateInCar.Value.Date - DateTime.UtcNow.Date).TotalDays);
            DBCars car = new DBCars();
            DBRental Rental = new DBRental();
            Rental.CarID = Convert.ToInt32(CarIDTxt.Text);
            Rental.ClientID = Convert.ToInt32(ClientIDTXT.Text);
            Rental.OutDate = DateOutCar.Value.Date;            /*dateOUT.Value.Date.ToString("yyyy-MM-dd");*/
            Rental.ReturnDate = DateInCar.Value.Date;         /*datein.Value.Date.ToString("yyyy-MM-dd");*/
            var price = Convert.ToInt32(datagridCar.Rows[datagridCar.CurrentRow.Index].Cells[5].Value.ToString());


            Rental.Fee = totalDays * price;
            //Rental.Fee = Convert.ToInt32(totalDays) * Convert.ToInt32(Price);


            _dbcontext.Add(Rental);
            _dbcontext.SaveChanges();
            MessageBox.Show("Successfully Added Rental");

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            CarIDTxt.Text = string.Empty;
            ReBrandTXT.Text = string.Empty;
            ReModelTXT.Text = string.Empty;
            ReRegNumberTXT.Text = string.Empty;
            ReQuantityTXT.Text = string.Empty;
            RePriceTXT.Text = string.Empty;

            ClientIDTXT.Text = string.Empty;
            ReFirstNameTXT.Text = string.Empty;
            ReLastNameTXT.Text = string.Empty;
            RePasportNumberTXT.Text = string.Empty;
            RePhoneTXT.Text = string.Empty;
            RePhone2TXT.Text = string.Empty;
            ReAddressTXT.Text = string.Empty;



        }
    }
}