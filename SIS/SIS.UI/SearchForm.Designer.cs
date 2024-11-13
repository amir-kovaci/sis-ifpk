namespace SIS.UI
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ResultsGridView;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultsGridView = new System.Windows.Forms.DataGridView();

            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(20, 20);
            this.SearchLabel.Size = new System.Drawing.Size(80, 25);
            this.SearchLabel.Text = "Search:";

            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(100, 20);
            this.SearchTextBox.Size = new System.Drawing.Size(300, 25);

            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(420, 20);
            this.SearchButton.Size = new System.Drawing.Size(100, 30);
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new EventHandler(this.SearchButton_Click);

            // 
            // ResultsGridView
            // 
            this.ResultsGridView.Location = new System.Drawing.Point(20, 70);
            this.ResultsGridView.Size = new System.Drawing.Size(750, 350);
            this.ResultsGridView.ColumnCount = 3;
            this.ResultsGridView.Columns[0].Name = "Patient Name";
            this.ResultsGridView.Columns[1].Name = "Current Diagnosis";
            this.ResultsGridView.Columns[2].Name = "Current Therapy";
            this.ResultsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add controls to the form
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResultsGridView);

            // Form settings
            this.Text = "Patient Search";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
        }

        #endregion
    }
}