namespace MegaDesk_3_LynnetteWarnberg
{
    partial class ViewAllQuotes
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
            this.CancelAllQuotes = new System.Windows.Forms.Button();
            this.dataViewAllQuotes = new System.Windows.Forms.DataGridView();
            this.quoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelAllQuotes
            // 
            this.CancelAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelAllQuotes.Location = new System.Drawing.Point(392, 499);
            this.CancelAllQuotes.Name = "CancelAllQuotes";
            this.CancelAllQuotes.Size = new System.Drawing.Size(232, 72);
            this.CancelAllQuotes.TabIndex = 0;
            this.CancelAllQuotes.Text = "Cancel";
            this.CancelAllQuotes.UseVisualStyleBackColor = true;
            this.CancelAllQuotes.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // dataViewAllQuotes
            // 
            this.dataViewAllQuotes.AllowUserToAddRows = false;
            this.dataViewAllQuotes.AllowUserToDeleteRows = false;
            this.dataViewAllQuotes.AllowUserToOrderColumns = true;
            this.dataViewAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quoteDate,
            this.custName,
            this.depth,
            this.width,
            this.NumberOfDrawers,
            this.surfaceMaterial,
            this.deliveryType,
            this.quoteAmount});
            this.dataViewAllQuotes.Location = new System.Drawing.Point(2, 3);
            this.dataViewAllQuotes.Name = "dataViewAllQuotes";
            this.dataViewAllQuotes.RowTemplate.Height = 28;
            this.dataViewAllQuotes.Size = new System.Drawing.Size(973, 372);
            this.dataViewAllQuotes.TabIndex = 1;
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
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 583);
            this.Controls.Add(this.dataViewAllQuotes);
            this.Controls.Add(this.CancelAllQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAllQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelAllQuotes;
        private System.Windows.Forms.DataGridView dataViewAllQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn custName;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteAmount;
    }
}