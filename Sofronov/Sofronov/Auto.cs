using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sofronov
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }
        private void Auto_FormClosing(object sender, FormClosingEventArgs e) //Код на закрытие программы
        {
            Application.Exit();
        }
        private void guna2Button2_Click(object sender, EventArgs e) //Код на кнопку клиент
        {
            MessageBox.Show("Добро пожаловать клиент", "Приветсвие");
            this.Hide();
            Client cl = new Client();
            cl.ShowDialog();
        }
        private void guna2Button1_Click(object sender, EventArgs e) //Код на кнопку Менеджер
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1FDLUB9\SQLEXPRESS;Initial Catalog=sofronov; Integrated Security=True;");
            try
            {
                string comand = string.Format("SELECT * FROM \"User\" WHERE Login = '" + Logtxt.Text + "' AND Password = '" + Pastxt.Text + "' AND Role = 'Клиент';");
                SqlCommand check = new SqlCommand(comand, con);
                con.Open();
                if (check.ExecuteScalar() != null)
                {
                    MessageBox.Show("Добро пожаловать пользователь", "Приветсвие");
                    Menager man = new Menager(); 
                    man.Show(); 
                    this.Hide(); }
                else {
                    MessageBox.Show("Введены неправильные данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally { }
        }
    }
}