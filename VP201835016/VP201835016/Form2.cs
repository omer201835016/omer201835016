using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP201835016
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Pamukkale 120 TL");
            liste.Add("Kamilkoç 130 TL");
            liste.Add("Metro 140 TL");

            
            foreach (var item in liste)
            {
                Console.WriteLine((string)item);

            }

            
        }
    }
}
