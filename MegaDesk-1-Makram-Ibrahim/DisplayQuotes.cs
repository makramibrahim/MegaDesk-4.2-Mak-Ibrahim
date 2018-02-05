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
    public partial class DisplayQuotes : Form
    {
        public DisplayQuotes()
        {
            InitializeComponent();

            DeskQuote deskQuote = new DeskQuote();

            DisplayQuoteList.Text = "Hello There!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var addnewQuotes = (AddNewQuote)Tag;
            addnewQuotes.Show();
            Hide();
        }

    }
}
