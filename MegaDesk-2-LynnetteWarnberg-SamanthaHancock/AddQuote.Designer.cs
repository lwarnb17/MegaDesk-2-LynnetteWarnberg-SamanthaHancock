namespace MegaDesk_3_LynnetteWarnberg
{
    partial class AddQuote
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
            this.CancelQuote = new System.Windows.Forms.Button();
            this.GetQuoteBtn = new System.Windows.Forms.Button();
            this.NewDesk = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.DeskSize = new System.Windows.Forms.GroupBox();
            this.depthNumber = new System.Windows.Forms.NumericUpDown();
            this.depth = new System.Windows.Forms.Label();
            this.widthNumber = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.Label();
            this.deskSpec = new System.Windows.Forms.GroupBox();
            this.surfaceMaterialDropDown = new System.Windows.Forms.ComboBox();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.numDrawerNumber = new System.Windows.Forms.NumericUpDown();
            this.numberOfDrawers = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.deliveryTimeDropDown = new System.Windows.Forms.ComboBox();
            this.DeskSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumber)).BeginInit();
            this.deskSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelQuote
            // 
            this.CancelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelQuote.Location = new System.Drawing.Point(427, 510);
            this.CancelQuote.Name = "CancelQuote";
            this.CancelQuote.Size = new System.Drawing.Size(187, 55);
            this.CancelQuote.TabIndex = 0;
            this.CancelQuote.Text = "Cancel";
            this.CancelQuote.UseVisualStyleBackColor = true;
            this.CancelQuote.Click += new System.EventHandler(this.CancelQuoteButton);
            // 
            // GetQuoteBtn
            // 
            this.GetQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GetQuoteBtn.Location = new System.Drawing.Point(182, 510);
            this.GetQuoteBtn.Name = "GetQuoteBtn";
            this.GetQuoteBtn.Size = new System.Drawing.Size(224, 55);
            this.GetQuoteBtn.TabIndex = 1;
            this.GetQuoteBtn.Text = "Get Desk Quote";
            this.GetQuoteBtn.UseVisualStyleBackColor = true;
            this.GetQuoteBtn.Click += new System.EventHandler(this.GetQuoteBtn_Click);
            // 
            // NewDesk
            // 
            this.NewDesk.AutoSize = true;
            this.NewDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NewDesk.Location = new System.Drawing.Point(174, 29);
            this.NewDesk.Name = "NewDesk";
            this.NewDesk.Size = new System.Drawing.Size(450, 46);
            this.NewDesk.TabIndex = 2;
            this.NewDesk.Text = "Start Building New Desk";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomerName.Location = new System.Drawing.Point(41, 107);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(200, 29);
            this.CustomerName.TabIndex = 3;
            this.CustomerName.Text = "Customer Name: ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerName.Location = new System.Drawing.Point(235, 101);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(361, 35);
            this.txtCustomerName.TabIndex = 4;
            // 
            // DeskSize
            // 
            this.DeskSize.Controls.Add(this.depthNumber);
            this.DeskSize.Controls.Add(this.depth);
            this.DeskSize.Controls.Add(this.widthNumber);
            this.DeskSize.Controls.Add(this.width);
            this.DeskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeskSize.Location = new System.Drawing.Point(36, 159);
            this.DeskSize.Name = "DeskSize";
            this.DeskSize.Size = new System.Drawing.Size(719, 115);
            this.DeskSize.TabIndex = 6;
            this.DeskSize.TabStop = false;
            this.DeskSize.Text = "Desk Size:";
            // 
            // depthNumber
            // 
            this.depthNumber.AllowDrop = true;
            this.depthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depthNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.depthNumber.Location = new System.Drawing.Point(475, 42);
            this.depthNumber.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNumber.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumber.Name = "depthNumber";
            this.depthNumber.Size = new System.Drawing.Size(91, 35);
            this.depthNumber.TabIndex = 3;
            this.depthNumber.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depth.Location = new System.Drawing.Point(386, 42);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(83, 29);
            this.depth.TabIndex = 2;
            this.depth.Text = "Depth:";
            // 
            // widthNumber
            // 
            this.widthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.widthNumber.Location = new System.Drawing.Point(217, 40);
            this.widthNumber.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumber.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumber.Name = "widthNumber";
            this.widthNumber.Size = new System.Drawing.Size(92, 35);
            this.widthNumber.TabIndex = 1;
            this.widthNumber.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.width.Location = new System.Drawing.Point(131, 42);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(80, 29);
            this.width.TabIndex = 0;
            this.width.Text = "Width:";
            // 
            // deskSpec
            // 
            this.deskSpec.Controls.Add(this.surfaceMaterialDropDown);
            this.deskSpec.Controls.Add(this.surfaceMaterial);
            this.deskSpec.Controls.Add(this.numDrawerNumber);
            this.deskSpec.Controls.Add(this.numberOfDrawers);
            this.deskSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deskSpec.Location = new System.Drawing.Point(36, 280);
            this.deskSpec.Name = "deskSpec";
            this.deskSpec.Size = new System.Drawing.Size(719, 122);
            this.deskSpec.TabIndex = 7;
            this.deskSpec.TabStop = false;
            this.deskSpec.Text = "Desk Specifics ";
            // 
            // surfaceMaterialDropDown
            // 
            this.surfaceMaterialDropDown.BackColor = System.Drawing.SystemColors.Menu;
            this.surfaceMaterialDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.surfaceMaterialDropDown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.surfaceMaterialDropDown.FormattingEnabled = true;
            this.surfaceMaterialDropDown.Location = new System.Drawing.Point(475, 37);
            this.surfaceMaterialDropDown.Name = "surfaceMaterialDropDown";
            this.surfaceMaterialDropDown.Size = new System.Drawing.Size(206, 37);
            this.surfaceMaterialDropDown.TabIndex = 3;
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Location = new System.Drawing.Point(315, 49);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(160, 25);
            this.surfaceMaterial.TabIndex = 2;
            this.surfaceMaterial.Text = "Surface Material:";
            // 
            // numDrawerNumber
            // 
            this.numDrawerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numDrawerNumber.Location = new System.Drawing.Point(217, 42);
            this.numDrawerNumber.Name = "numDrawerNumber";
            this.numDrawerNumber.Size = new System.Drawing.Size(92, 35);
            this.numDrawerNumber.TabIndex = 1;
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.AutoSize = true;
            this.numberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.numberOfDrawers.Location = new System.Drawing.Point(5, 52);
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(202, 25);
            this.numberOfDrawers.TabIndex = 0;
            this.numberOfDrawers.Text = "Number of Drawers:";
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delivery.Location = new System.Drawing.Point(300, 448);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(106, 29);
            this.delivery.TabIndex = 8;
            this.delivery.Text = "Delivery:";
            // 
            // deliveryTimeDropDown
            // 
            this.deliveryTimeDropDown.BackColor = System.Drawing.SystemColors.Menu;
            this.deliveryTimeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryTimeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deliveryTimeDropDown.FormattingEnabled = true;
            this.deliveryTimeDropDown.Items.AddRange(new object[] {
            " "});
            this.deliveryTimeDropDown.Location = new System.Drawing.Point(427, 448);
            this.deliveryTimeDropDown.Name = "deliveryTimeDropDown";
            this.deliveryTimeDropDown.Size = new System.Drawing.Size(290, 37);
            this.deliveryTimeDropDown.TabIndex = 9;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 610);
            this.Controls.Add(this.deliveryTimeDropDown);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.deskSpec);
            this.Controls.Add(this.DeskSize);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.NewDesk);
            this.Controls.Add(this.GetQuoteBtn);
            this.Controls.Add(this.CancelQuote);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.DeskSize.ResumeLayout(false);
            this.DeskSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumber)).EndInit();
            this.deskSpec.ResumeLayout(false);
            this.deskSpec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelQuote;
        private System.Windows.Forms.Button GetQuoteBtn;
        private System.Windows.Forms.Label NewDesk;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox DeskSize;
        private System.Windows.Forms.NumericUpDown depthNumber;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.NumericUpDown widthNumber;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.GroupBox deskSpec;
        private System.Windows.Forms.ComboBox surfaceMaterialDropDown;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.NumericUpDown numDrawerNumber;
        private System.Windows.Forms.Label numberOfDrawers;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.ComboBox deliveryTimeDropDown;
    }
}