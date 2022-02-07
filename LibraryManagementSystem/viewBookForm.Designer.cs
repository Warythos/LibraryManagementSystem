
namespace LibraryManagementSystem
{
    partial class viewBookForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.authorTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.quantityTBox = new System.Windows.Forms.TextBox();
            this.priceTBox = new System.Windows.Forms.TextBox();
            this.purchaseTBox = new System.Windows.Forms.TextBox();
            this.publicationTBox = new System.Windows.Forms.TextBox();
            this.authorUpdateTBox = new System.Windows.Forms.TextBox();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(852, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.searchTBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 162);
            this.panel1.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(88, 95);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 36);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTBox
            // 
            this.searchTBox.Location = new System.Drawing.Point(119, 31);
            this.searchTBox.Name = "searchTBox";
            this.searchTBox.Size = new System.Drawing.Size(137, 23);
            this.searchTBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Book Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchButton2);
            this.panel2.Controls.Add(this.authorTBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 162);
            this.panel2.TabIndex = 3;
            // 
            // searchButton2
            // 
            this.searchButton2.Location = new System.Drawing.Point(88, 95);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(98, 36);
            this.searchButton2.TabIndex = 2;
            this.searchButton2.Text = "Search";
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // authorTBox
            // 
            this.authorTBox.Location = new System.Drawing.Point(119, 31);
            this.authorTBox.Name = "authorTBox";
            this.authorTBox.Size = new System.Drawing.Size(137, 23);
            this.authorTBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Author Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updateButton);
            this.panel3.Controls.Add(this.quantityTBox);
            this.panel3.Controls.Add(this.priceTBox);
            this.panel3.Controls.Add(this.purchaseTBox);
            this.panel3.Controls.Add(this.publicationTBox);
            this.panel3.Controls.Add(this.authorUpdateTBox);
            this.panel3.Controls.Add(this.nameTBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(293, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 244);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(607, 47);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 36);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // quantityTBox
            // 
            this.quantityTBox.Location = new System.Drawing.Point(419, 87);
            this.quantityTBox.Name = "quantityTBox";
            this.quantityTBox.Size = new System.Drawing.Size(137, 23);
            this.quantityTBox.TabIndex = 10;
            // 
            // priceTBox
            // 
            this.priceTBox.Location = new System.Drawing.Point(419, 55);
            this.priceTBox.Name = "priceTBox";
            this.priceTBox.Size = new System.Drawing.Size(137, 23);
            this.priceTBox.TabIndex = 9;
            // 
            // purchaseTBox
            // 
            this.purchaseTBox.Location = new System.Drawing.Point(419, 22);
            this.purchaseTBox.Name = "purchaseTBox";
            this.purchaseTBox.Size = new System.Drawing.Size(137, 23);
            this.purchaseTBox.TabIndex = 8;
            // 
            // publicationTBox
            // 
            this.publicationTBox.Location = new System.Drawing.Point(151, 87);
            this.publicationTBox.Name = "publicationTBox";
            this.publicationTBox.Size = new System.Drawing.Size(137, 23);
            this.publicationTBox.TabIndex = 7;
            // 
            // authorUpdateTBox
            // 
            this.authorUpdateTBox.Location = new System.Drawing.Point(151, 55);
            this.authorUpdateTBox.Name = "authorUpdateTBox";
            this.authorUpdateTBox.Size = new System.Drawing.Size(137, 23);
            this.authorUpdateTBox.TabIndex = 6;
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(151, 22);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(137, 23);
            this.nameTBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Publication Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name";
            // 
            // viewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 660);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewBookForm";
            this.Text = "Search Books";
            this.Load += new System.EventHandler(this.viewBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.TextBox authorTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox quantityTBox;
        private System.Windows.Forms.TextBox priceTBox;
        private System.Windows.Forms.TextBox purchaseTBox;
        private System.Windows.Forms.TextBox publicationTBox;
        private System.Windows.Forms.TextBox authorUpdateTBox;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}