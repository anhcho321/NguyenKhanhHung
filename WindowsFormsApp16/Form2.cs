using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = temp;
        }
        public string temp;
        public delegate void GETDATA(string data);
        public GETDATA mydata;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
             
        }
        
        private void bnt1_Click_1(object sender, EventArgs e)
        {
          
            mydata(textBox1.Text);
            
            this.Close();
          }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
