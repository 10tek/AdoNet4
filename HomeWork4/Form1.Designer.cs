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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetCustomers
            // 
            this.GetCustomers.Location = new System.Drawing.Point(264, 85);
            this.GetCustomers.Name = "GetCustomers";
            this.GetCustomers.Size = new System.Drawing.Size(97, 23);
            this.GetCustomers.TabIndex = 0;
            this.GetCustomers.Text = "Get Сustomers";
            this.GetCustomers.UseVisualStyleBackColor = true;
            // 
            // GetSellers
            // 
            this.GetSellers.Location = new System.Drawing.Point(264, 114);
            this.GetSellers.Name = "GetSellers";
            this.GetSellers.Size = new System.Drawing.Size(97, 23);
            this.GetSellers.TabIndex = 1;
            this.GetSellers.Text = "Get Sellers";
            this.GetSellers.UseVisualStyleBackColor = true;
            // 
            // GetSales
            // 
            this.GetSales.Location = new System.Drawing.Point(264, 143);
            this.GetSales.Name = "GetSales";
            this.GetSales.Size = new System.Drawing.Size(97, 23);
            this.GetSales.TabIndex = 2;
            this.GetSales.Text = "Get Sales";
            this.GetSales.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 347);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetSales);
            this.Controls.Add(this.GetSellers);
            this.Controls.Add(this.GetCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetCustomers;
        private System.Windows.Forms.Button GetSellers;
        private System.Windows.Forms.Button GetSales;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

