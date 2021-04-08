using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBarMotoCycle_Scroll(object sender, EventArgs e)
        {
            lblMotoCycle.Text = tBarMotoCycle.Value.ToString();
            LoadprogressBarData();
        }

        private void tBarTruck_Scroll(object sender, EventArgs e)
        {
            lblTruck.Text = tBarTruck.Value.ToString();
            LoadprogressBarData();
        }

        private void tBarCar_Scroll(object sender, EventArgs e)
        {
            lblCar.Text = tBarCar.Value.ToString();
            LoadprogressBarData();
        }

        private void tBarTarinCar_Scroll(object sender, EventArgs e)
        {
            lblTarinCar.Text = tBarTarinCar.Value.ToString();
            LoadprogressBarData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadprogressBarData();
            clear();
        }

        private void clear()
        {
            pBarCargo.ForeColor = Color.Goldenrod;
            pBarCargo.Value = default;
            tBarMotoCycle.Value = default;
            tBarTruck.Value = default;
            tBarCar.Value = default;
            tBarTarinCar.Value = default;
            lblMotoCycle.Text = default;
            lblTruck.Text = default;
            lblCar.Text = default;
            lblTarinCar.Text = default;
            lblCapacityAndLoad.Visible = false;
        }

        private void LoadprogressBarData()
        {
            //pBarCargo.ForeColor = Color.Goldenrod;
            lblCapacityAndLoad.Visible = true;
            int total = 0;
            total = Convert.ToInt32(tBarMotoCycle.Value) * 3 + Convert.ToInt32(tBarTruck.Value) * 11 + Convert.ToInt32(tBarCar.Value) *5 + Convert.ToInt32(tBarTarinCar.Value) * 17;
            pBarCargo.Maximum = 239;
            
            if (total == 239)
            {
                pBarCargo.ForeColor = Color.Green;
                pBarCargo.Value = total;
               
            }
            else if(total <239)
            {
                pBarCargo.ForeColor = Color.Goldenrod;
                pBarCargo.Value = total;
            }
            else
            {
                pBarCargo.Value = 239;
                pBarCargo.ForeColor = Color.Red;
                //MessageBox.Show("Maximam capacity crossed");
            }

            lblCapacityAndLoad.Text = "Capacity= 239," + "  CurrentLoad=" + total.ToString();
        }

        private void btnNewBoat_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
