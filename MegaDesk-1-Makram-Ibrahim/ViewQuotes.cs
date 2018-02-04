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
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
            AddNewQuote addNewQuote = new AddNewQuote();

            addNewQuote.DisplayClientData();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;

            mainMenu.Show();

            Close();

        }
    }
}
