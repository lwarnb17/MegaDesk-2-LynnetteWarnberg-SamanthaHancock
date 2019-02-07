using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_3_LynnetteWarnberg
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }
        private void CancelQuoteButton(object sender, EventArgs e)
        {
            
            Close();
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            string quotesFile = @"quotes.json";

            List<DeskQuote> currentQuotes = new List<DeskQuote>();
            if(File.Exists(quotesFile))
            {
                using (StreamReader streamReader = new StreamReader(quotesFile))
                {
                    string quotes = streamReader.ReadToEnd();
                    currentQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                }
            }

            currentQuotes.Add(deskQuote);
            string newQuotes = JsonConvert.SerializeObject(currentQuotes);

            File.WriteAllText(quotesFile, newQuotes);


        }
        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();

        }

        private void GetQuoteBtn_Click(object sender, EventArgs e)
        {
           var desk = new Desk()

            {
                Depth = depthNumber.Value,
                Width = widthNumber.Value,
                NumberOfDrawers = (int)numDrawerNumber.Value,
                SurfaceMaterial = (Desk.Surface)surfaceMaterialDropDown.SelectedItem
             };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = txtCustomerName.Text, 
                QuoteDate = DateTime.Now,
                DeliveryType = (DeskQuote.Delivery)deliveryTimeDropDown.SelectedValue
            };

            try
            {
                //get quote amount
                var quote = deskQuote.GetQuote();

                //add amount to quote
                deskQuote.QuoteAmount = quote;

                //add quote to file
                AddQuoteToFile(deskQuote);

                //show 'DisplayQuote' form
   
                DisplayQuote frmDisplayQuote = new DisplayQuote(deskQuote);
                frmDisplayQuote.Show();
                Hide();

            }
            catch (Exception err)
            {
                MessageBox.Show("THERE was an error creating the quote. {0}", err.Message);
            }

            
            

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //populate materials combobox
            var materials = new List<Desk.Surface>();

            materials = Enum.GetValues(typeof(Desk.Surface))
                            .Cast<Desk.Surface>()
                            .ToList();

            surfaceMaterialDropDown.DataSource = materials;

            //set default to empy
            surfaceMaterialDropDown.SelectedIndex = -1;


            //populate delivery combobox
            var delivery = new List<DeskQuote.Delivery>();

            delivery = Enum.GetValues(typeof(DeskQuote.Delivery))
                            .Cast<DeskQuote.Delivery>()
                            .ToList();

            deliveryTimeDropDown.DataSource = delivery;

            //set default to empy
            deliveryTimeDropDown.SelectedIndex = -1;

           

        }
    }
}
