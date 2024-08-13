using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route: " + comboBox1.Text+ "- " + comboBox2.Text + " Date: " + dateTimePicker1.Text + 
                " Traveler: " + maskedTextBox3.Text + " " + textBox1.Text + "  " + textBox2.Text + "  " + maskedTextBox1.Text + "  " + 
                maskedTextBox2.Text + "  " + textBox3.Text);
            if(label10.Visible != false)
            {
                listBox1.Items.Add("\n  Return on: " + dateTimePicker2.Text);
            }
            else
            {
                listBox1.Items.Add("\n  One way");
            }
            MessageBox.Show("Registration Completed! \n You won 5% discount!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deger;
            deger = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = deger;
            //bunu visible ı kapalı label ile yapılabilir. Değer ona atılır sonra geri atanır.
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = radioButton2.Checked;
            dateTimePicker2.Visible = radioButton2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
