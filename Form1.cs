using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string Constring ="Data Source=DESKTOP-BLGNBAB\\;Initial Catalog = hayvanlar; Integrated Security = True
         SqlConnection connect= new SqlConnection();


        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                if(connect.State == ConnectionState.Closed)
                    connect.Open();
                string  kayit= "insert into koyun(koyun_sayı,cins) values(@koyun_sayı,@cins)";
                SqlCommand komut= new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@koyun_sayı",txtkoyun.txt);

                komut.Parameters.AddWithValue("cins.txtcins".text);
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("kayıt eklendi");
                               {
                }
                
catch (Exception.exe)
            {
            }