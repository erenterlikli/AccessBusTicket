using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace AccessOtobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Eren\\Documents\\Yolcu.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void Goruntule()
        {
            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = ("Select * from Yolcu");
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Seferno"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Koltukno"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox3.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Insert into Yolcu(Seferno,Tarih,Saat,Adsoyad,Telefon,Koltukno,Ucret,Cinsiyet,Binis) Values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            Goruntule();
            temizle();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=8; i<22; i=i+2)
            {
                comboBox3.Items.Add(i+"TL");
            }
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "1";
            button4.Enabled = false;
            button4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "2";
            button5.Enabled = false;
            button5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "3";
            button6.Enabled = false;
            button6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text = "4";
            button7.Enabled = false;
            button7.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "5";
            button8.Enabled = false;
            button8.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.Text = "6";
            button9.Enabled = false;
            button9.BackColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "7";
            button10.Enabled = false;
            button10.BackColor = Color.Green;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox6.Text = "8";
            button11.Enabled = false;
            button11.BackColor = Color.Green;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox6.Text = "9";
            button12.Enabled = false;
            button12.BackColor = Color.Green;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox6.Text = "10";
            button13.Enabled = false;
            button13.BackColor = Color.Green;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox6.Text = "11";
            button14.Enabled = false;
            button14.BackColor = Color.Green;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button4.BackColor = DefaultBackColor;
            button5.BackColor = DefaultBackColor;
            button6.BackColor = DefaultBackColor;
            button7.BackColor = DefaultBackColor;
            button8.BackColor = DefaultBackColor;
            button9.BackColor = DefaultBackColor;
            button10.BackColor = DefaultBackColor;
            button11.BackColor = DefaultBackColor;
            button12.BackColor = DefaultBackColor;
            button13.BackColor = DefaultBackColor;
            button14.BackColor = DefaultBackColor;
        

        }

        private void button16_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText= "Delete from Yolcu where Adsoyad='"+textBox7.Text+"'";
            komut.ExecuteNonQuery();
            baglan.Close();
            Goruntule();
            textBox7.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText= ("Update Yolcu set Seferno='"+textBox1.Text+"',Tarih='"+textBox2.Text+"',Saat='"+textBox3.Text+"',Telefon='"+textBox5.Text+"',Koltukno='"+textBox6.Text+"',Ucret='"+comboBox3.Text+"',Cinsiyet='"+comboBox1.Text+ "',Binis='" + comboBox2.Text + "'where Adsoyad='" +textBox4.Text+"'");
            komut.ExecuteNonQuery();
            baglan.Close();
            Goruntule();
            temizle();
        }
    }
}
