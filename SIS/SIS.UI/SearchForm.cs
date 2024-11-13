using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS.UI
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Dummy data for demonstration
            string[,] sampleData = new string[,]
            {
                {"John Doe", "Hypertension", "Beta Blockers"},
                {"Jane Smith", "Diabetes", "Insulin Therapy"},
                {"Sam Wilson", "Asthma", "Inhalers"}
            };

            // Clear previous results
            this.ResultsGridView.Rows.Clear();

            // Fetch search term
            string searchTerm = this.SearchTextBox.Text.ToLower();

            // Populate DataGridView with matching data
            for (int i = 0; i < sampleData.GetLength(0); i++)
            {
                if (sampleData[i, 0].ToLower().Contains(searchTerm))
                {
                    this.ResultsGridView.Rows.Add(sampleData[i, 0], sampleData[i, 1], sampleData[i, 2]);
                }
            }
        }
    }
}
