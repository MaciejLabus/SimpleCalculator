using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            main_num_label.Text = String.Empty;
            first_num_label.Text = String.Empty;
        }


        // Method for number buttons to reset text after clicking equality button
        public void Button_Click(object sender, EventArgs e)
        {
            this.main_num_label.ResetText();

            var button = sender as Button;

            var currentNumber = button.Name[button.Name.Length - 1];

            this.first_num_label.Text += currentNumber;

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.main_num_label.ResetText();
            this.first_num_label.ResetText();
        }


        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var operation = first_num_label.Text;

            if (ContainsOperation(operation))
            {
                first_num_label.Text = CalculateResult(operation).ToString();
            }

            first_num_label.Text += "+";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            var operation = first_num_label.Text;

            if (ContainsOperation(operation))
            {
                first_num_label.Text = CalculateResult(operation).ToString();
            }

            first_num_label.Text += "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            var operation = first_num_label.Text;

            if (ContainsOperation(operation))
            {
                first_num_label.Text = CalculateResult(operation).ToString();
            }

            first_num_label.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            var operation = first_num_label.Text;

            if (ContainsOperation(operation))
            {
                first_num_label.Text = CalculateResult(operation).ToString();
            }

            first_num_label.Text += "/";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            this.first_num_label.Text += ",";
        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            var operation = first_num_label.Text;


            main_num_label.Text = CalculateResult(operation).ToString();

            first_num_label.Text = String.Empty;
        }

        private bool ContainsOperation(string operation)
        {
            return operation.Contains('+') || operation.Contains('-') || operation.Contains('*') || operation.Contains('/');
        }


        private double CalculateResult(string operation)
        {
            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

                return double.Parse(elements[0]) + double.Parse(elements[1]);
            }

            if (operation.Contains('-'))
            {
                var elements = operation.Split('-');

                return double.Parse(elements[0]) - double.Parse(elements[1]);
            }

            if (operation.Contains('*'))
            {
                var elements = operation.Split('*');

                return double.Parse(elements[0]) * double.Parse(elements[1]);
            }

            if (operation.Contains('/'))
            {
                var elements = operation.Split('/');

                return double.Parse(elements[0]) / double.Parse(elements[1]);
            }

            return default;

    }




    }


}
