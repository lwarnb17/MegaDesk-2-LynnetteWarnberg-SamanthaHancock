namespace MegaDesk_3_LynnetteWarnberg
{
    partial class SearchQuotes
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelQuoteSearch = new System.Windows.Forms.Button();
            this.dataSearchAllQuotes = new System.Windows.Forms.DataGridView();
            this.quoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterialValues = new System.Windows.Forms.ComboBox();
            this.getQuotes = new System.Windows.Forms.Button();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelQuoteSearch
            // 
            this.CancelQuoteSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelQuoteSearch.Location = new System.Drawing.Point(266, 360);
            this.CancelQuoteSearch.Name = "CancelQuoteSearch";
            this.CancelQuoteSearch.Size = new System.Drawing.Size(299, 78);
            this.CancelQuoteSearch.TabIndex = 0;
            this.CancelQuoteSearch.Text = "Cancel";
            this.CancelQuoteSearch.UseVisualStyleBackColor = true;
            this.CancelQuoteSearch.Click += new System.EventHandler(this.CancelQuoteSearch_Click);
            // 
            // dataSearchAllQuotes
            // 
            this.dataSearchAllQuotes.AllowUserToAddRows = false;
            this.dataSearchAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quoteDate,
            this.custName,
            this.depth,
            this.width,
            this.NumberOfDrawers,
            this.surfaceMaterial,
            this.deliveryType,
            this.quoteAmount});
            this.dataSearchAllQuotes.Location = new System.Drawing.Point(12, 110);
            this.dataSearchAllQuotes.Name = "dataSearchAllQuotes";
            this.dataSearchAllQuotes.RowTemplate.Height = 28;
            this.dataSearchAllQuotes.Size = new System.Drawing.Size(1029, 244);
            this.dataSearchAllQuotes.TabIndex = 1;
            // 
            // quoteDate
            // 
            this.quoteDate.HeaderText = "Date";
            this.quoteDate.Name = "quoteDate";
            // 
            // custName
            // 
            this.custName.HeaderText = "Customer";
            this.custName.Name = "custName";
            // 
            // depth
            // 
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            // 
            // width
            // 
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            // 
            // NumberOfDrawers
            // 
            this.NumberOfDrawers.HeaderText = "Drawers";
            this.NumberOfDrawers.Name = "NumberOfDrawers";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.HeaderText = "Surface Material";
            this.surfaceMaterial.Name = "surfaceMaterial";
            // 
            // deliveryType
            // 
            this.deliveryType.HeaderText = "Delivery Type";
            this.deliveryType.Name = "deliveryType";
            // 
            // quoteAmount
            // 
            this.quoteAmount.HeaderText = "Quote Amount";
            this.quoteAmount.Name = "quoteAmount";
            // 
            // surfaceMaterialValues
            // 
            this.surfaceMaterialValues.FormattingEnabled = true;
            this.surfaceMaterialValues.Location = new System.Drawing.Point(255, 35);
            this.surfaceMaterialValues.Name = "surfaceMaterialValues";
            this.surfaceMaterialValues.Size = new System.Drawing.Size(243, 28);
            this.surfaceMaterialValues.TabIndex = 2;
            // 
            // getQuotes
            // 
            this.getQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.getQuotes.Location = new System.Drawing.Point(527, 27);
            this.getQuotes.Name = "getQuotes";
            this.getQuotes.Size = new System.Drawing.Size(154, 42);
            this.getQuotes.TabIndex = 3;
            this.getQuotes.Text = "Find Quote";
            this.getQuotes.UseVisualStyleBackColor = true;
            this.getQuotes.Click += new System.EventHandler(this.getQuotes_Click);
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(46, 34);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(193, 29);
            this.SurfaceMaterialLabel.TabIndex = 4;
            this.SurfaceMaterialLabel.Text = "Surface Material:";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 584);
            this.Controls.Add(this.SurfaceMaterialLabel);
            this.Controls.Add(this.getQuotes);
            this.Controls.Add(this.surfaceMaterialValues);
            this.Controls.Add(this.dataSearchAllQuotes);
            this.Controls.Add(this.CancelQuoteSearch);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchAllQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelQuoteSearch;
        private System.Windows.Forms.DataGridView dataSearchAllQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn custName;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteAmount;
        private System.Windows.Forms.ComboBox surfaceMaterialValues;
        private System.Windows.Forms.Button getQuotes;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
    }
}