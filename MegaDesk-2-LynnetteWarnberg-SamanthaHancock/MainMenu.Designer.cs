namespace MegaDesk_3_LynnetteWarnberg
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuoteButton = new System.Windows.Forms.Button();
            this.SearchQuoteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddQuoteButton.Location = new System.Drawing.Point(61, 42);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(225, 82);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "Add New Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // ViewQuoteButton
            // 
            this.ViewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewQuoteButton.Location = new System.Drawing.Point(60, 143);
            this.ViewQuoteButton.Name = "ViewQuoteButton";
            this.ViewQuoteButton.Size = new System.Drawing.Size(226, 76);
            this.ViewQuoteButton.TabIndex = 1;
            this.ViewQuoteButton.Text = "View Quotes";
            this.ViewQuoteButton.UseVisualStyleBackColor = true;
            this.ViewQuoteButton.Click += new System.EventHandler(this.ViewQuoteButton_Click);
            // 
            // SearchQuoteButton
            // 
            this.SearchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchQuoteButton.Location = new System.Drawing.Point(62, 241);
            this.SearchQuoteButton.Name = "SearchQuoteButton";
            this.SearchQuoteButton.Size = new System.Drawing.Size(224, 78);
            this.SearchQuoteButton.TabIndex = 2;
            this.SearchQuoteButton.Text = "Search Quotes";
            this.SearchQuoteButton.UseVisualStyleBackColor = true;
            this.SearchQuoteButton.Click += new System.EventHandler(this.SearchQuoteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitButton.Location = new System.Drawing.Point(60, 339);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(226, 73);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 297);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuoteButton);
            this.Controls.Add(this.ViewQuoteButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button ViewQuoteButton;
        private System.Windows.Forms.Button SearchQuoteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

