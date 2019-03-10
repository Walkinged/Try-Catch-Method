using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace errors1
{
    public partial class Form1 : Form
    {
        int Num1;
        int Num2;
        int Answer;

        public Form1()
        {
            InitializeComponent();
        }

        private void answrBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Num1 = Convert.ToInt32(calcTXT1.Text);
                Num2 = Convert.ToInt32(calcTXT2.Text);
                Answer = Num1 + Num2;
                answrTXT.Text = Answer.ToString();
            }

            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }


        }
    }
}
