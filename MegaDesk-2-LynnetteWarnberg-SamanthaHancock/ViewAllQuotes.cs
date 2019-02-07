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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            loadGrid();
        }
        
        private void loadGrid()
        {
            //try
            //{
            //    string[] deskQuotes = File.ReadAllLines(@"quotes.text");

            //    foreach (string deskQuote in deskQuotes)
            //    {
            //        string[] arrRow = deskQuote.Split(new char[] { ',' });

            //        dataViewAllQuotes.Rows.Add(arrRow);
            //    }
            //}
            //catch (FileNotFoundException)
            //{
            //    MessageBox.Show("No Qoutes have been created.");
            //}

            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataViewAllQuotes.DataSource = allQuotes.Select(d => new
                {
                    QuoteDate = d.QuoteDate,
                    CustomerName = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    NumberOfDrawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.SurfaceMaterial,
                    DeliveryType = d.DeliveryType,
                    QuoteAmount = d.QuoteAmount
                }).ToList();
            }
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();

            
        }
    }
}
