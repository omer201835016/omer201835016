using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VP201835016
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-EIPOHM6\SQLEXPRESS;Initial Catalog=prologic;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from Table_1", baglan);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["id"].ToString();
                ekle.SubItems.Add(read["Hvac_DDC_Name"].ToString());
                ekle.SubItems.Add(read["Hvac_DDC_Description"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            int sayac = listView1.Items.Count;
            listView1.Items.Add(textBox1.Text);
            listView1.Items[sayac].SubItems.Add(textBox2.Text);
            listView1.Items[sayac].SubItems.Add(maskedTextBox1.Text);
            if(radioButton1.Checked)
            {
                listView1.Items[sayac].SubItems.Add(radioButton1.Text);
            }
            if(radioButton2.Checked)
            {
                listView1.Items[sayac].SubItems.Add(radioButton2.Text);
            }
            listView1.Items[sayac].SubItems.Add(textBox3.Text);
            listView1.Items[sayac].SubItems.Add(textBox4.Text);

            Form1 f1 = new Form1();
            DialogResult sonuc = f1.ShowDialog();
            if(sonuc == DialogResult.OK)
            {
                listView1.Items[sayac].SubItems.Add(f1.comboBox1.Text);
                listView1.Items[sayac].SubItems.Add(f1.comboBox2.Text);
                listView1.Items[sayac].SubItems.Add(f1.dateTimePicker1.Text);
            }
            
                
            
            



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
