using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_Makram_Ibrahim
{
    public partial class AddNewQuote : Form
    {
        DeskQuote deskQuote = new DeskQuote();

        private void AddNewQuote_Load(object sender, EventArgs e){}
        private void Material_SelectedIndexChanged(object sender, EventArgs e){ }

        /************************************
        * Onload Form, display the following methods
        * ************************************/
        public AddNewQuote()
        {
            InitializeComponent();

            DeskQuote getTime = new DeskQuote();
            OrderDate.Text = getTime.geDate();
        }

        /**************************************************
        * Show Menu page from add new quote 
        * *************************************************/
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;

            mainMenu.Show();

            Close();
        }

       /*************************************************
       *  Order confirmation
       * **********************************************/
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

            //DisplayQuotes displayQuotes = new DisplayQuotes();

            //displayQuotes.Tag = this;

            //displayQuotes.Show(this);

            //Hide();

            DisplayClientData();


        }
        /*************************************
        *  Display order details
        * ***********************************/
        public string DisplayClientData()
        {
            string clientName = ClientName.Text;
            double width = Convert.ToDouble(DeskWidth.Text);
            double depth = Convert.ToDouble(DeskDepth.Text);
            int numOfDrawers = Convert.ToInt32(DeskDrawers.Text);
            string material = DeskMaterial.Text;
            int rushDays = Convert.ToInt32(RushDays.Text);



            DeskQuote clientOrder = new DeskQuote(clientName, width, depth, numOfDrawers, material, rushDays);

          
            DisplayQuote.Text = "Customer Name: " + clientName + Environment.NewLine +
                                "Desk Width: " + width + Environment.NewLine +
                                "Desk Depth: " + depth + Environment.NewLine +
                                "Desk Drawers: " + numOfDrawers + Environment.NewLine +
                                "Desk Material: " + material + Environment.NewLine +
                                "Rush Days: " + rushDays + Environment.NewLine +
                                "Desk Suraface " + clientOrder.SurfaceArea().ToString();

            double getPriceList = deskQuote.QuoteTotal();

            return TotalPrice.Text = "$" + getPriceList.ToString();

        }

        /*************************************
        * Cancel Order event.
        * ***********************************/
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

        private void DeskWidth_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DeskDepth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
