using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

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
            try
            {
                tBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int n = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                numAge.Value = n;
                cBoxPr.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch { }
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

                    row["Name"] = r.Cells[0].Value;
                    row["Age"] = r.Cells[1].Value;
                    row["Programmer"] = r.Cells[2].Value;
                    ds.Tables["Employee"].Rows.Add(row);
                }
                ds.WriteXml("C:\\Users\\Acer\\Downloads\\Data1.xml");
                MessageBox.Show("XML файл успішно збережений.", "Виповнено.");
            }
            catch
            {
                MessageBox.Show("Неможливо зберегти XML файл.", "Помилка.");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
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

        private void btDowXML_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\Acer\\Downloads\\";
            openFileDialog1.Filter = "Text Files (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (dataGridView1.Rows.Count > 0)
            {
                btClear_Click(sender, e);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(openFileDialog1.FileName);
                foreach (DataRow item in ds.Tables["Employee"].Rows)
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

        public string none = "(none)";
        private void button3_Click(object sender, EventArgs e)
        {
            if (tBoxName.Text.Length == 0)
            {
                MessageBox.Show("Заповниит всі поля", "Помилка");
            }
            else
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = tBoxName.Text;
                dataGridView2.Rows[n].Cells[1].Value = nUpDoAge.Value;
                dataGridView2.Rows[n].Cells[2].Value = cbProgrammer.Text;
                dataGridView2.Rows[n].Cells[3].Value = cBoxGender.Text;
                dataGridView2.Rows[n].Cells[4].Value = tBoxCompany.Text == "" ? "(none)" : tBoxCompany.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int n = dataGridView2.SelectedRows[0].Index;
                dataGridView2.Rows[n].Cells[0].Value = tBoxName.Text;
                dataGridView2.Rows[n].Cells[1].Value = nUpDoAge.Value;
                dataGridView2.Rows[n].Cells[2].Value = cbProgrammer.Text;
                dataGridView2.Rows[n].Cells[3].Value = cBoxGender.Text;
                dataGridView2.Rows[n].Cells[4].Value = tBoxCompany.Text == "" ? "(none)" : tBoxCompany.Text;
            }
            else
            {
                MessageBox.Show("Виберіть строку для редагування.", "Помилка.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Виберіть строку для видалення.", "Помилка.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\Acer\\Downloads\\";
            openFileDialog1.Filter = "Text Files (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Employee";
                dt.Columns.Add("Name");
                dt.Columns.Add("Age");
                dt.Columns.Add("Programmer");
                dt.Columns.Add("Sex");
                dt.Columns.Add("Company");
                ds.Tables.Add(dt);
                foreach (DataGridViewRow R in dataGridView2.Rows)
                {
                    DataRow row = ds.Tables["Employee"].NewRow();
                    row["Name"] = R.Cells[0].Value;
                    row["Age"] = R.Cells[1].Value;
                    row["Programmer"] = R.Cells[2].Value;
                    row["Sex"] = R.Cells[3].Value;
                    row["Company"] = R.Cells[4].Value;
                    ds.Tables["Employee"].Rows.Add(row);
                }
                ds.WriteXml("C:\\Users\\Acer\\Downloads\\Data2.xml");
                MessageBox.Show("XML файл успішно збережений.", "Виповнено.");
            }
            catch
            {
                MessageBox.Show("Неможливо зберегти XML файл.", "Помилка.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\Acer\\Downloads\\";
            openFileDialog1.Filter = "Text file (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (dataGridView2.Rows.Count > 0)
            {
                button5_Click(sender, e);
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(openFileDialog1.FileName);
                foreach (DataRow row in ds.Tables["Employee"].Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = row["Name"];
                    dataGridView2.Rows[n].Cells[1].Value = row["Age"];
                    dataGridView2.Rows[n].Cells[2].Value = row["Programmer"];
                    try { dataGridView2.Rows[n].Cells[3].Value = row["Sex"]; }
                    catch { dataGridView2.Rows[n].Cells[3].Value = none; }
                    try { dataGridView2.Rows[n].Cells[4].Value = row["Company"]; }
                    catch { dataGridView2.Rows[n].Cells[4].Value = none; }
                }
            }
            else
                MessageBox.Show("XML файн не найден", "Помилка.");
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tBoxName.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                tBoxCompany.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString() == null ? dataGridView2.SelectedRows[0].Cells[4].Value.ToString() : none;
                nUpDoAge.Value = Convert.ToDecimal((string)dataGridView2.SelectedRows[0].Cells[1].Value);
                cbProgrammer.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                cBoxGender.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }
        }
    }
}
