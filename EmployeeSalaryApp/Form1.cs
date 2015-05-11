using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SalaryCal calculator = new SalaryCal();


        private void showButton_Click(object sender, EventArgs e)
        {
            calculator.EmployeeName = empNameTextBox.Text;
            calculator.Amount = Convert.ToDouble(basicAmoTextBox.Text);
            calculator.HouseRent = Convert.ToDouble(houseRentTextBox.Text);
            calculator.MedicalAllowance = Convert.ToDouble(medAllTextBox.Text);

            calculator.HouseRent = (calculator.Amount*calculator.HouseRent)/100;
            calculator.MedicalAllowance = (calculator.Amount*calculator.MedicalAllowance)/100;

            calculator.Amount = calculator.Amount - (calculator.HouseRent + calculator.MedicalAllowance);

            MessageBox.Show(calculator.EmployeeName + " your salary is:" + calculator.Amount);
        }
    }
}
