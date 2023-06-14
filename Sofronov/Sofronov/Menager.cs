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
    public partial class Menager : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1FDLUB9\SQLEXPRESS;Initial Catalog=sofronov; Integrated Security=True;");
        public Menager()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            adapter = new SqlDataAdapter("SELECT * FROM \"Tovar\" ", con);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Menager_FormClosing(object sender, FormClosingEventArgs e) // Код на закрытие программы
        {
            Application.Exit();
        }

        private void Menager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sofronovDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.sofronovDataSet.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sofronovDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.sofronovDataSet.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sofronovDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.sofronovDataSet.Tovar);

        }

        private void guna2Button1_Click(object sender, EventArgs e) //Код на кнопку на скрытие и показ элементов 
        {
            dataGridView1.Show();
            dataGridView2.Hide();
            guna2Button1.Hide();
            guna2Button2.Show();
            textBox1.Show();
            textBox2.Hide();
            comboBox1.Show();
            comboBox2.Show();
            label2.Show();
            pictureBox1.Show();
            guna2Button3.Show();
            guna2Button4.Show();
            guna2Button5.Show();
            guna2Button6.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e) //Код на кнопку скрытие и показ элементов
        {
            dataGridView1.Hide();
            dataGridView2.Show();
            guna2Button1.Show();
            guna2Button2.Hide();
            textBox1.Hide();
            textBox2.Show();
            comboBox1.Hide();
            comboBox2.Hide();
            label2.Hide();
            pictureBox1.Hide();
            guna2Button3.Hide();
            guna2Button4.Hide();
            guna2Button5.Hide();
            guna2Button6.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Код на текс бокс на поиск
        {
            string searchValue = textBox1.Text.Trim();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                    }
                    else
                    {
                        dataGridView1.CurrentCell = null;
                        row.Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Код на текст бокс на поиск
        {
            string searchValue = textBox2.Text.Trim();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                    }
                    else
                    {
                        dataGridView2.CurrentCell = null;
                        row.Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Кол на Комбо бокс фильтрация по процентам
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    break;

                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Max_skidca] <=9";
                    break;

                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Max_skidca] >=10 AND [Max_skidca] <=14";
                    break;

                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Max_skidca] >=15";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //Код на комбо бокс на выбор картинок
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.B111C5;
                    break;

                case 1:
                    pictureBox1.Image = Properties.Resources.E112C6;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.K839K3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.L293S9;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.M112C8;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.M294G9;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.M398S9;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.N283K3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.S384K2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.T238C7;
                    break;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e) //Код на кнопку сортировка по убыванию
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }

        private void guna2Button5_Click(object sender, EventArgs e) //Код на кнопку сортировка по возростанию
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void guna2Button3_Click(object sender, EventArgs e) //Код на кнопку покраску 
        {
            PaintRow();
        }
        private void PaintRow() //Код на покраску
        {
            var c = System.Drawing.ColorTranslator.FromHtml("#7fff00");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (int.Parse(row.Cells[3].Value.ToString()) > 15)
                        row.DefaultCellStyle.BackColor = c;
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
                catch { }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e) //Код на кнопку подсчет строк
        {
            int rowCount = dataGridView1.Rows.Count;
            label2.Text = rowCount.ToString();
        }

        private void guna2Button7_Click(object sender, EventArgs e) //Код на кнопку назад
        {
            this.Hide();
            Auto auto = new Auto();
            auto.ShowDialog();
        }
    }
}