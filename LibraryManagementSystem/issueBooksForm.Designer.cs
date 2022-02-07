
namespace LibraryManagementSystem
{
    partial class issueBooksForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.issueDateTBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNameTBox = new System.Windows.Forms.TextBox();
            this.emailTBox = new System.Windows.Forms.TextBox();
            this.contactTBox = new System.Windows.Forms.TextBox();
            this.semTBox = new System.Windows.Forms.TextBox();
            this.departmentTBox = new System.Windows.Forms.TextBox();
            this.studentNameTBox = new System.Windows.Forms.TextBox();
            this.enrollmentTBox = new System.Windows.Forms.TextBox();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.issueDateTBox);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bookNameTBox);
            this.panel1.Controls.Add(this.emailTBox);
            this.panel1.Controls.Add(this.contactTBox);
            this.panel1.Controls.Add(this.semTBox);
            this.panel1.Controls.Add(this.departmentTBox);
            this.panel1.Controls.Add(this.studentNameTBox);
            this.panel1.Controls.Add(this.enrollmentTBox);
            this.panel1.Controls.Add(this.searchStudentButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 556);
            this.panel1.TabIndex = 0;
            // 
            // issueDateTBox
            // 
            this.issueDateTBox.Location = new System.Drawing.Point(388, 261);
            this.issueDateTBox.Name = "issueDateTBox";
            this.issueDateTBox.Size = new System.Drawing.Size(200, 23);
            this.issueDateTBox.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(388, 333);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 109);
            this.listBox1.TabIndex = 18;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Book Issue Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter Student Enrollment No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Books Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Sem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Name";
            // 
            // bookNameTBox
            // 
            this.bookNameTBox.Location = new System.Drawing.Point(388, 304);
            this.bookNameTBox.Name = "bookNameTBox";
            this.bookNameTBox.Size = new System.Drawing.Size(200, 23);
            this.bookNameTBox.TabIndex = 7;
            this.bookNameTBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.bookNameTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bookNameTBox_KeyDown);
            this.bookNameTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bookNameTBox_KeyUp);
            // 
            // emailTBox
            // 
            this.emailTBox.Location = new System.Drawing.Point(388, 213);
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.Size = new System.Drawing.Size(200, 23);
            this.emailTBox.TabIndex = 6;
            // 
            // contactTBox
            // 
            this.contactTBox.Location = new System.Drawing.Point(388, 167);
            this.contactTBox.Name = "contactTBox";
            this.contactTBox.Size = new System.Drawing.Size(200, 23);
            this.contactTBox.TabIndex = 5;
            // 
            // semTBox
            // 
            this.semTBox.Location = new System.Drawing.Point(388, 122);
            this.semTBox.Name = "semTBox";
            this.semTBox.Size = new System.Drawing.Size(200, 23);
            this.semTBox.TabIndex = 4;
            // 
            // departmentTBox
            // 
            this.departmentTBox.Location = new System.Drawing.Point(388, 78);
            this.departmentTBox.Name = "departmentTBox";
            this.departmentTBox.Size = new System.Drawing.Size(200, 23);
            this.departmentTBox.TabIndex = 3;
            // 
            // studentNameTBox
            // 
            this.studentNameTBox.Location = new System.Drawing.Point(388, 38);
            this.studentNameTBox.Name = "studentNameTBox";
            this.studentNameTBox.Size = new System.Drawing.Size(200, 23);
            this.studentNameTBox.TabIndex = 2;
            // 
            // enrollmentTBox
            // 
            this.enrollmentTBox.Location = new System.Drawing.Point(27, 73);
            this.enrollmentTBox.Name = "enrollmentTBox";
            this.enrollmentTBox.Size = new System.Drawing.Size(134, 23);
            this.enrollmentTBox.TabIndex = 1;
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Location = new System.Drawing.Point(53, 106);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(76, 39);
            this.searchStudentButton.TabIndex = 0;
            this.searchStudentButton.Text = "Search Student";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // issueBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 593);
            this.Controls.Add(this.panel1);
            this.Name = "issueBooksForm";
            this.Text = "Book Issue";
            this.Load += new System.EventHandler(this.issueBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookNameTBox;
        private System.Windows.Forms.TextBox emailTBox;
        private System.Windows.Forms.TextBox contactTBox;
        private System.Windows.Forms.TextBox semTBox;
        private System.Windows.Forms.TextBox departmentTBox;
        private System.Windows.Forms.TextBox studentNameTBox;
        private System.Windows.Forms.TextBox enrollmentTBox;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox issueDateTBox;
    }
}