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
            this.dataViewAllQuotes.Location = new System.Drawing.Point(2, 3);
            this.dataViewAllQuotes.Name = "dataViewAllQuotes";
            this.dataViewAllQuotes.RowTemplate.Height = 28;
            this.dataViewAllQuotes.Size = new System.Drawing.Size(973, 372);
            this.dataViewAllQuotes.TabIndex = 1;
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
    }
}