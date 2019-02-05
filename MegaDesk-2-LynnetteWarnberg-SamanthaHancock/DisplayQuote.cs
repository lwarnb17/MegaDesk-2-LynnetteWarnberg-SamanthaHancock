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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            txtCustomerName.Text = deskQuote.CustomerName.ToString();
            widthAnswer.Text = deskQuote.Desk.Width.ToString();
            depthAnswer.Text = deskQuote.Desk.Depth.ToString();
            surfaceMaterial.Text = deskQuote.Desk.SurfaceMaterial.ToString();
            delivery.Text = deskQuote.DeliveryType.ToString();
            numOfDrawers.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            quoteAmount.Text = deskQuote.QuoteAmount.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
