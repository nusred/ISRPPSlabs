using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChainRespons_lab
{
    using ChainRespons_lab.Model;
    public partial class Form1 : Form
    {

       private Encoding digits;

       private Encoding upperchar; //new EncodeUpper();

       private Encoding lowerchar;


        public Form1()
        {

           InitializeComponent();

           digits = new EncodingDigits();

           upperchar = new EncodingUpper();

           lowerchar = new EncodingLower();

            // связывание объектов

           digits.LinkToObject(upperchar);

           upperchar.LinkToObject(lowerchar);

           
        }

        /// <summary>
        /// закодировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (char token in this.textBox1.Text)
            {
                try
                {
                    this.textBox2.Text += digits.Requre(token);
                }
                catch (ArgumentException exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
                    return;
                }
                
            }
        }

        /// <summary>
        /// очистка кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }
    }
}
