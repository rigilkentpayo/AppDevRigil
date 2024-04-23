using Acrylicbusiness.connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acrylicbusiness
{
    public partial class Form1 : Form
    {
        public static string sendtext = "";

        public Form1()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 200)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Hide();

                progressBar1.Value = 0;
                sendtext = textBox1.Text;
                Form2 s = new Form2();
                s.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //retrieving username and password from the database
            try
            {
                connection.connection.DB();
                DBHelper.DBHelper.gen = "Select * from users where [users] = '" + textBox1.Text + "' and [password] = '" + textBox1.Text + "'";
                DBHelper.DBHelper.command = new OleDbCommand(DBHelper.DBHelper.gen, connection.connection.conn);
                DBHelper.DBHelper.reader = DBHelper.DBHelper.command.ExecuteReader();

                if (DBHelper.DBHelper.reader.HasRows)
                {
                    DBHelper.DBHelper.reader.Read();
                    //database  
                    textBox1.Text = (DBHelper.DBHelper.reader["users"].ToString());
                    textBox2.Text = (DBHelper.DBHelper.reader["password"].ToString());
                    // open a next form  
                    //  Stocks s = new Stocks ();
                    //  s.Show();
                    //   this.Visible =false;//cosing the form
                    //   sale.Show();l

                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1;
                    progressBar1.Maximum = 200;
                    timer1.Tick += new EventHandler(timer1_Tick);


                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");

                }
                connection.connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.connection.conn.Close();
                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
