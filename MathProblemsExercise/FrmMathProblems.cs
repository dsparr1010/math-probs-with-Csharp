using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProblemsExercise
{
    public partial class FrmMathProblems : Form
    {

        public FrmMathProblems()
        {
            InitializeComponent();
        }

        //FIND VOLUME:
        //Solve for volume formula:
        // V = w h l
        int length;
        int width;
        int height;
        double volume;

        //FIND MARKUP
        float sellingprice;
        float cost;
        double markup;

        //FIND EMP PAY



        private void BtnFindVol1_Click(object sender, EventArgs e)
        {
            length = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the LENGTH:", "Find the Volume of a Rectangular Solid", "", 200, 200));
            width = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the WIDTH:", "Find the Volume of a Rectangular Solid", "", 200, 200));
            height = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the HEIGHT:", "Find the Volume of a Rectangular Solid", "", 200, 200));

            volume = (double) width * height * length;

            MessageBox.Show("The volume of this rectangular solid is : " + volume);
        }

        private void BtnSellingPrice_Click(object sender, EventArgs e)
        {
            sellingprice = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("What is the selling price?", "Determine the percentage markup of a store item", "", 200, 200));
            cost = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("What is th actual cost?", "Determine the percentage markup of a store item", "", 200, 200));

            markup = (double)((sellingprice - cost) / cost) * 100;

            MessageBox.Show("Markup percentage for item : " + markup + "%");
        }

        private void BtnEmpPay_Click(object sender, EventArgs e)
        {
            string emp_name;
            float pay_rate;
            float hours_worked;
            double net_pay;
            float gross_pay;

            emp_name = Microsoft.VisualBasic.Interaction.InputBox("What is the Employee's Name", "Find Net Pay for an Employee", "", 200, 200);
            pay_rate = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("What is employee's rate of pay hourly?", "Find Net Pay for an Employee", "", 200, 200));
            hours_worked = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("How many hours did " + emp_name + " work?", "Find Net Pay for an Employee", "", 200, 200));

            double tax_rate = .2;
            double amount_deducted;

            gross_pay = pay_rate * hours_worked;
            amount_deducted = gross_pay * tax_rate;
            net_pay = gross_pay - amount_deducted;

            MessageBox.Show(
                "The Gross Pay for " + emp_name + " is : " + gross_pay.ToString("c") + "\n" + "The Net Pay is : " + net_pay.ToString("c")
                );
        }
    }
}
