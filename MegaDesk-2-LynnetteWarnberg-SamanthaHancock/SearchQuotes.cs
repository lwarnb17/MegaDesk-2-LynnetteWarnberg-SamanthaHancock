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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            // put enum values in comboBox
            //populate materials combobox
            var materials = new List<Desk.Surface>();

            materials = Enum.GetValues(typeof(Desk.Surface))
                            .Cast<Desk.Surface>()
                            .ToList();

            surfaceMaterialValues.DataSource = materials;

            //set default to empy
            surfaceMaterialValues.SelectedIndex = -1;
        }

        private void loadGrid()
        {
            try
            {
                dataSearchAllQuotes.Rows.Clear();

                string surfaceMaterial = surfaceMaterialValues.SelectedValue.ToString();

                string[] deskQuotes = File.ReadAllLines(@"quotes.text");

                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    if (arrRow[5] == surfaceMaterial) {
                        dataSearchAllQuotes.Rows.Add(arrRow);
                    }

                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Qoutes have been found.");
            }
        }


        private void CancelQuoteSearch_Click(object sender, EventArgs e)
        {

            Close();
        }
        private void getQuotes_Click(object sender, EventArgs e)
        {
            loadGrid();
        }
        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        
       var quotesFile = @"quotes.json"; 

        using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
    List<DeskQuote> allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

    dataSearchAllQuotes.DataSource = allQuotes.Select(d => new
        {
            QuoteDate = d.QuoteDate,
            CustomerName = d.CustomerName,
            Width = d.Desk.Width,
            Depth = d.Desk.Depth,
            NumberOfDrawers = d.Desk.NumberOfDrawers,
            SurfaceMaterial = d.Desk.SurfaceMaterial,
            DeliveryType = d.DeliveryType,
            QuoteAmount = d.QuoteAmount
        })
        .Where(q => q.SurfaceMaterial == (Desk.Surface)surfaceMaterialValues.SelectedValue)
        .ToList();
        }
       }
    }
}