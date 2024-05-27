using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(aAmount.Text);
            if (aFromCombo1.SelectedItem == "Zlote")
            {
                switch (aToCombo2.SelectedItem)
                {
                    case "Qar":
                        aDisplay.Text = "Converted Amount : " + i * 0.86 + "\t Qar";
                        break;
                    case "Euro":
                        aDisplay.Text = "Converted Amount : " + i * 0.22 + "\t Euro";
                        break;
                    case "USD":
                        aDisplay.Text = "Converted Amount : " + i * 0.26 + "\t USD";
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }
            }
            else if (aFromCombo1.SelectedItem == "Qar")
            {
                switch (aToCombo2.SelectedItem)
                {
                    case "Zlote":
                        aDisplay.Text = "Converted Amount : " + i / 0.86 + "\t Zlote";
                        break;
                    case "Euro":
                        aDisplay.Text = "Converted Amount : " + i * 0.26 + "\t Euro";
                        break;
                    case "USD":
                        aDisplay.Text = "Converted Amount : " + i * 0.27 + "\t USD";
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }
            }
            else if (aFromCombo1.SelectedItem == "Euro")
            {
                switch (aToCombo2.SelectedItem)
                {
                    case "Qar":
                        aDisplay.Text = "Converted Amount : " + i / 0.26 + "\t Qar";
                        break;
                    case "Zlote":
                        aDisplay.Text = "Converted Amount : " + i / 0.22 + "\t Zlote";
                        break;
                    case "USD":
                        aDisplay.Text = "Converted Amount : " + i * 0.92 + "\t USD";
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }
            }
            else if (aFromCombo1.SelectedItem == "USD")
            {
                switch (aToCombo2.SelectedItem)
                {
                    case "Qar":
                        aDisplay.Text = "Converted Amount : " + i / 0.27 + "\t Qar";
                        break;
                    case "Zlote":
                        aDisplay.Text = "Converted Amount : " + i / 0.26 + "\t Zlote";
                        break;
                    case "Euro":
                        aDisplay.Text = "Converted Amount : " + i * 0.92 + "\t Euro";
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }
            }
            else { MessageBox.Show("ERROR"); }
            }
        }
    }

