namespace HomeWork4
{
    partial class Form1
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
            this.GetCustomers = new System.Windows.Forms.Button();
            this.GetSellers = new System.Windows.Forms.Button();
            this.GetSales = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetCustomers
            // 
            this.GetCustomers.Location = new System.Drawing.Point(12, 220);
            this.GetCustomers.Name = "GetCustomers";
            this.GetCustomers.Size = new System.Drawing.Size(97, 23);
            this.GetCustomers.TabIndex = 0;
            this.GetCustomers.Text = "Get Сustomers";
            this.GetCustomers.UseVisualStyleBackColor = true;
            this.GetCustomers.Click += new System.EventHandler(this.GetCustomers_Click);
            // 
            // GetSellers
            // 
            this.GetSellers.Location = new System.Drawing.Point(12, 249);
            this.GetSellers.Name = "GetSellers";
            this.GetSellers.Size = new System.Drawing.Size(97, 23);
            this.GetSellers.TabIndex = 1;
            this.GetSellers.Text = "Get Sellers";
            this.GetSellers.UseVisualStyleBackColor = true;
            this.GetSellers.Click += new System.EventHandler(this.GetSellers_Click);
            // 
            // GetSales
            // 
            this.GetSales.Location = new System.Drawing.Point(12, 278);
            this.GetSales.Name = "GetSales";
            this.GetSales.Size = new System.Drawing.Size(97, 23);
            this.GetSales.TabIndex = 2;
            this.GetSales.Text = "Get Sales";
            this.GetSales.UseVisualStyleBackColor = true;
            this.GetSales.Click += new System.EventHandler(this.GetSales_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(127, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(493, 289);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "Вывод";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 347);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.GetSales);
            this.Controls.Add(this.GetSellers);
            this.Controls.Add(this.GetCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetCustomers;
        private System.Windows.Forms.Button GetSellers;
        private System.Windows.Forms.Button GetSales;
        private System.Windows.Forms.TextBox textBox;
    }
}

