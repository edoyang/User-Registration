using System.Data;
using System.Data.SqlClient;

namespace userregistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtMName = new TextBox();
            intPhone = new TextBox();
            txtLName = new TextBox();
            txtAdd = new TextBox();
            txtEmail = new TextBox();
            submit = new Button();
            clear = new Button();
            exit = new Button();
            label7 = new Label();
            dateBdayPicker = new DateTimePicker();
            txtConnectionString = new TextBox();
            label8 = new Label();
            txtDatabaseName = new TextBox();
            label9 = new Label();
            txtCollectionName = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(52, 53);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(32, 96);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Middle Name :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(53, 133);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.TopRight;
            label4.Location = new Point(70, 295);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.TopRight;
            label5.Location = new Point(86, 255);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImageAlign = ContentAlignment.TopRight;
            label6.Location = new Point(25, 173);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 3;
            label6.Text = "Phone Number :";
            label6.Click += label6_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(165, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 27);
            txtName.TabIndex = 6;
            // 
            // txtMName
            // 
            txtMName.Location = new Point(165, 93);
            txtMName.Name = "txtMName";
            txtMName.Size = new Size(296, 27);
            txtMName.TabIndex = 7;
            // 
            // intPhone
            // 
            intPhone.Location = new Point(165, 173);
            intPhone.Name = "intPhone";
            intPhone.Size = new Size(296, 27);
            intPhone.TabIndex = 9;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(165, 133);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(296, 27);
            txtLName.TabIndex = 8;
            txtLName.TextChanged += txtLName_TextChanged;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(165, 295);
            txtAdd.Multiline = true;
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(296, 100);
            txtAdd.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 255);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 27);
            txtEmail.TabIndex = 10;
            // 
            // submit
            // 
            submit.Location = new Point(367, 413);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 12;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // clear
            // 
            clear.Location = new Point(165, 413);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 13;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.Location = new Point(45, 413);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 14;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImageAlign = ContentAlignment.TopRight;
            label7.Location = new Point(68, 213);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 15;
            label7.Text = "Birthday :";
            label7.Click += label7_Click;
            // 
            // dateBdayPicker
            // 
            dateBdayPicker.CustomFormat = "yyyy/MM/dd";
            dateBdayPicker.Location = new Point(165, 213);
            dateBdayPicker.Name = "dateBdayPicker";
            dateBdayPicker.Size = new Size(296, 27);
            dateBdayPicker.TabIndex = 17;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(165, 12);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(296, 27);
            txtConnectionString.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImageAlign = ContentAlignment.TopRight;
            label8.Location = new Point(5, 9);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 18;
            label8.Text = "Connection String :";
            label8.Click += label8_Click;
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Location = new Point(654, 12);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new Size(115, 27);
            txtDatabaseName.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImageAlign = ContentAlignment.TopRight;
            label9.Location = new Point(495, 15);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 20;
            label9.Text = "Database Name  :";
            // 
            // txtCollectionName
            // 
            txtCollectionName.Location = new Point(654, 51);
            txtCollectionName.Name = "txtCollectionName";
            txtCollectionName.Size = new Size(115, 27);
            txtCollectionName.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ImageAlign = ContentAlignment.TopRight;
            label10.Location = new Point(495, 54);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 22;
            label10.Text = "Collection Name :";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCollectionName);
            Controls.Add(label10);
            Controls.Add(txtDatabaseName);
            Controls.Add(label9);
            Controls.Add(txtConnectionString);
            Controls.Add(label8);
            Controls.Add(dateBdayPicker);
            Controls.Add(label7);
            Controls.Add(exit);
            Controls.Add(clear);
            Controls.Add(submit);
            Controls.Add(txtAdd);
            Controls.Add(txtEmail);
            Controls.Add(intPhone);
            Controls.Add(txtLName);
            Controls.Add(txtMName);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "UserRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtMName;
        private TextBox intPhone;
        private TextBox txtLName;
        private TextBox txtAdd;
        private TextBox txtEmail;
        private Button submit;
        private Button clear;
        private Button exit;
        private Label label7;
        private DateTimePicker dateBdayPicker;
        private TextBox txtConnectionString;
        private Label label8;
        private TextBox txtDatabaseName;
        private Label label9;
        private TextBox txtCollectionName;
        private Label label10;
    }
}