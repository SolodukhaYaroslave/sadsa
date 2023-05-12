using System.Windows.Forms;
using System.Xml;
using System.IO;
using System;
using System.Data;

namespace Завдання
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("XML.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int age = int.Parse(node["Age"].InnerText);
                bool programmer = bool.Parse(node["Programmer"].InnerText);
                listBox1.Items.Add(new Employee(name, age, programmer));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }

        private void btAdd_Click(object sender, System.EventArgs e)
        {
            if (tBox.Text == "")
            {
                MessageBox.Show("Заповниит всі поля", "Помилка");
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = tBox.Text;
                dataGridView1.Rows[n].Cells[1].Value = numAge.Value;
                dataGridView1.Rows[n].Cells[2].Value = cBoxPr.Text;
            }
        }

        private void btChange_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int n = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[n].Cells[0].Value = tBox.Text;
                dataGridView1.Rows[n].Cells[1].Value = numAge.Value;
                dataGridView1.Rows[n].Cells[2].Value = cBoxPr.Text;
            }
            else
            {
                MessageBox.Show("Виберіть строку для редагування.", "Помилка.");
            }
        }

        private void btDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Виберіть строку для видалення.", "Помилка.");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            tBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int n = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            numAge.Value = n;
            cBoxPr.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btSaveXML_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Employee";
                dt.Columns.Add("Name");
                dt.Columns.Add("Age");
                dt.Columns.Add("Programmer");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row = ds.Tables["Employee"].NewRow();

                    row["Name"] = r.Cells[1].Value;
                    row["Age"] = r.Cells[1].Value;
                    row["Programmer"] = r.Cells[2].Value;
                    ds.Tables["Employee"].Rows.Add(row);
                }
                ds.WriteXml("C:\\Data.xml");
                MessageBox.Show("XML файл успішно збережений.", "Виповнено.");
            }
            catch
            {
                MessageBox.Show("Неможливо зберегти XML файл.","Помилка.");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Очищення поля перед загрузкою нового файлу.", "Помилка.");
            }
            else
            {
                if (File.Exists("C:\\Data.xml"))
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml("C:\\Data.xml");
                    foreach (DataRow item in ds.Tables)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item["Name"];

                        dataGridView1.Rows[n].Cells[1].Value = item["Age"];
                        dataGridView1.Rows[n].Cells[2].Value = item["Programmer"];
                    }
                }
                else
                    MessageBox.Show("XML файн не найден", "Помилка.");
            }
        }

        private void btDowXML_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблиця пуста.", "Помилка.");
            }
        }
    }
}
