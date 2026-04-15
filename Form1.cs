using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Market : Form
    {
        
        
        
        public Market()
        {
            InitializeComponent();
        }

        private void Head_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            string Text = TextInput.Text;

            foreach (char c in Text)
            {
               
                result.Append(System.Convert.ToString((int)c, 2).PadLeft(8, '0'));
                result.Append(" "); 
            }

            TextOutput.Text = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextOutput.Clear();
            TextInput.Clear();
        }

        private void Desible_Click(object sender, EventArgs e)
        {
            TextInput.Enabled = false;
            TextOutput.Enabled = false;
        }

        private void Enable_Click(object sender, EventArgs e)
        {
            TextInput.Enabled = true;
            TextOutput.Enabled = true;
        }

        private void TextOutput_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
