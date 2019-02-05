using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_LynnetteWarnberg
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
        private void ViewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewAllQuotesForm = new ViewAllQuotes();
            addViewAllQuotesForm.Tag = this;
            addViewAllQuotesForm.Show(this);
            Hide();
        }

        private void SearchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes addSearchQuotesForm = new SearchQuotes();
            addSearchQuotesForm.Tag = this;
            addSearchQuotesForm.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
