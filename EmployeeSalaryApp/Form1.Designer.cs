namespace EmployeeSalaryApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.basicAmoTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.medAllTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.Location = new System.Drawing.Point(111, 31);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.empNameTextBox.TabIndex = 4;
            // 
            // basicAmoTextBox
            // 
            this.basicAmoTextBox.Location = new System.Drawing.Point(117, 72);
            this.basicAmoTextBox.Name = "basicAmoTextBox";
            this.basicAmoTextBox.Size = new System.Drawing.Size(100, 20);
            this.basicAmoTextBox.TabIndex = 5;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(117, 120);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(100, 20);
            this.houseRentTextBox.TabIndex = 6;
            // 
            // medAllTextBox
            // 
            this.medAllTextBox.Location = new System.Drawing.Point(117, 173);
            this.medAllTextBox.Name = "medAllTextBox";
            this.medAllTextBox.Size = new System.Drawing.Size(100, 20);
            this.medAllTextBox.TabIndex = 7;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(60, 214);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(172, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show Me Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.medAllTextBox);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.basicAmoTextBox);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.TextBox basicAmoTextBox;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.TextBox medAllTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

