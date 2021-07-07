using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Your_ID {
    public partial class Form1 : Form {
        /*
         * This form application is a simulated program
         * that should use some basic info and create a
         * unique ID that should be used for citizens
         * older than 18 years old
         */
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            // Ask User for Day, Month and Year
            string day = Day.Text;
            string month = Month.Text;
            string year = Year.Text;

            // Generate random 3 digit number
            Random rdm = new Random();
            int rdmNum = rdm.Next(9, 999);

            // Toggle Gender RadioButton
            if (Male.Checked && rdmNum < 100) {
                textBox1.Text = day + month + year.Remove(0, 1) + "450" + "0" + Convert.ToString(rdmNum);
            } else {
                textBox1.Text = day + month + year.Remove(0, 1) + "450" + Convert.ToString(rdmNum);
            }

            if (Female.Checked && rdmNum < 100) {
                textBox1.Text = day + month + year.Remove(0, 1) + "455" + "0" + Convert.ToString(rdmNum);
            }
            else {
                textBox1.Text = day + month + year.Remove(0, 1) + "455" + Convert.ToString(rdmNum);
            }
        }
    }
}
