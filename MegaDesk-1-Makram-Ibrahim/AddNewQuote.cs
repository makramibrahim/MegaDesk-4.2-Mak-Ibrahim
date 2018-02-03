using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_1_Makram_Ibrahim
{
    public partial class AddNewQuote : Form
    {
        private void AddNewQuote_Load(object sender, EventArgs e){}
        private void Material_SelectedIndexChanged(object sender, EventArgs e){ }

        double matPrice = 0;

        public AddNewQuote()
        {
            InitializeComponent();

            DeskQuote getTime = new DeskQuote();
            OrderDate.Text = Convert.ToString(getTime.geDate());

            
        }
 
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;

            mainMenu.Show();

            Close();
        }

      

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            DisplayClientData();
        }

        public double PriceList()
        {
            string material = DeskMaterial.Text;

            if (material == "Oak")
            {
                matPrice = 200;
            }
            else if (material == "Lanimate")
            {
                matPrice = 100;
            }
            else if (material == "Pine")
            {
                matPrice = 50;
            }
            else if (material == "Rosewood")
            {
                matPrice = 300;
            }
            else if (material == "Veneer")
            {
                matPrice = 125;
            }

            return matPrice;

        }

        public void DisplayClientData()
        {
            string clientName = ClientName.Text;
            double width = Convert.ToDouble(DeskWidth.Text);
            double depth = Convert.ToDouble(DeskDepth.Text);
            int numOfDrawers = Convert.ToInt32(DeskDrawers.Text);
            string material = DeskMaterial.Text;
            int rushDays = Convert.ToInt32(RushDays.Text);

            double getPriceList = PriceList();

           

            DeskQuote clientOrder = new DeskQuote(clientName, width, depth, numOfDrawers, material, rushDays);


            DisplayQuote.Text = "Customer Name: " + clientName + Environment.NewLine +
                                "Desk Width: " + width + Environment.NewLine +
                                "Desk Depth: " + depth + Environment.NewLine +
                                "Desk Drawers: " + numOfDrawers + Environment.NewLine +
                                "Desk Material: " + material + Environment.NewLine +
                                "Rush Days: " + rushDays + Environment.NewLine +
                                "Desk Suraface" + clientOrder.getSurfaceArea().ToString();



            TotalPrice.Text = "$" + getPriceList.ToString();


        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            ClientName.Text = "";
            DeskWidth.Text = "";
            DeskDepth.Text = "";
            DeskDrawers.Text = "";
            DeskMaterial.Text = "";
            RushDays.Text = "";
            DisplayQuote.Text = "";

            TotalPrice.Text = "";
        }
    }
}
