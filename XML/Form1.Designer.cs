namespace Завдання
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPr = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.tBox = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDowXML = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btSaveXML = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tBoxCompany = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProgrammer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxGender = new System.Windows.Forms.ComboBox();
            this.nUpDoAge = new System.Windows.Forms.NumericUpDown();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDoAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.propertyGrid1);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 465);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Завдання 1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 190);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(768, 275);
            this.propertyGrid1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(-4, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(772, 184);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.cBoxPr);
            this.tabPage4.Controls.Add(this.numAge);
            this.tabPage4.Controls.Add(this.tBox);
            this.tabPage4.Controls.Add(this.btDelete);
            this.tabPage4.Controls.Add(this.btChange);
            this.tabPage4.Controls.Add(this.btAdd);
            this.tabPage4.Controls.Add(this.btDowXML);
            this.tabPage4.Controls.Add(this.btClear);
            this.tabPage4.Controls.Add(this.btSaveXML);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 465);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Завдання 2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Programmer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // cBoxPr
            // 
            this.cBoxPr.FormattingEnabled = true;
            this.cBoxPr.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cBoxPr.Location = new System.Drawing.Point(626, 68);
            this.cBoxPr.Name = "cBoxPr";
            this.cBoxPr.Size = new System.Drawing.Size(121, 28);
            this.cBoxPr.TabIndex = 9;
            this.cBoxPr.Text = "True";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(378, 68);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(106, 26);
            this.numAge.TabIndex = 8;
            this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(60, 67);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(236, 26);
            this.tBox.TabIndex = 7;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(588, 136);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(180, 35);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Видалити";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(289, 136);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(180, 35);
            this.btChange.TabIndex = 5;
            this.btChange.Text = "Редактувати";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(0, 136);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(180, 35);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Додати";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDowXML
            // 
            this.btDowXML.Location = new System.Drawing.Point(588, 420);
            this.btDowXML.Name = "btDowXML";
            this.btDowXML.Size = new System.Drawing.Size(180, 35);
            this.btDowXML.TabIndex = 3;
            this.btDowXML.Text = "Загрузити XML";
            this.btDowXML.UseVisualStyleBackColor = true;
            this.btDowXML.Click += new System.EventHandler(this.btDowXML_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(289, 420);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(180, 35);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Очистити таблицю";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSaveXML
            // 
            this.btSaveXML.Location = new System.Drawing.Point(0, 420);
            this.btSaveXML.Name = "btSaveXML";
            this.btSaveXML.Size = new System.Drawing.Size(180, 35);
            this.btSaveXML.TabIndex = 1;
            this.btSaveXML.Text = "Зберегти XML";
            this.btSaveXML.UseVisualStyleBackColor = true;
            this.btSaveXML.Click += new System.EventHandler(this.btSaveXML_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Age,
            this.Programmer});
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(765, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Programmer
            // 
            this.Programmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Programmer.HeaderText = "Programmer";
            this.Programmer.MinimumWidth = 8;
            this.Programmer.Name = "Programmer";
            this.Programmer.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tBoxCompany);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.cbProgrammer);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.gender);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.cBoxGender);
            this.tabPage5.Controls.Add(this.nUpDoAge);
            this.tabPage5.Controls.Add(this.tBoxName);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 465);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Завдання 3";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tBoxCompany
            // 
            this.tBoxCompany.FormattingEnabled = true;
            this.tBoxCompany.Items.AddRange(new object[] {
            "(none)"});
            this.tBoxCompany.Location = new System.Drawing.Point(85, 78);
            this.tBoxCompany.Name = "tBoxCompany";
            this.tBoxCompany.Size = new System.Drawing.Size(211, 28);
            this.tBoxCompany.TabIndex = 30;
            this.tBoxCompany.Text = "(none)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(588, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 35);
            this.button4.TabIndex = 29;
            this.button4.Text = "Загрузити XML";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(289, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 35);
            this.button5.TabIndex = 28;
            this.button5.Text = "Очистити таблицю";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 408);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 35);
            this.button6.TabIndex = 27;
            this.button6.Text = "Зберегти XML";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Programmer";
            // 
            // cbProgrammer
            // 
            this.cbProgrammer.FormattingEnabled = true;
            this.cbProgrammer.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbProgrammer.Location = new System.Drawing.Point(626, 77);
            this.cbProgrammer.Name = "cbProgrammer";
            this.cbProgrammer.Size = new System.Drawing.Size(121, 28);
            this.cbProgrammer.TabIndex = 25;
            this.cbProgrammer.Text = "True";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Company";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(524, 37);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(63, 20);
            this.gender.TabIndex = 22;
            this.gender.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name";
            // 
            // cBoxGender
            // 
            this.cBoxGender.FormattingEnabled = true;
            this.cBoxGender.Items.AddRange(new object[] {
            "M",
            "W",
            "(none)"});
            this.cBoxGender.Location = new System.Drawing.Point(626, 34);
            this.cBoxGender.Name = "cBoxGender";
            this.cBoxGender.Size = new System.Drawing.Size(121, 28);
            this.cBoxGender.TabIndex = 19;
            this.cBoxGender.Text = "(none)";
            // 
            // nUpDoAge
            // 
            this.nUpDoAge.Location = new System.Drawing.Point(378, 34);
            this.nUpDoAge.Name = "nUpDoAge";
            this.nUpDoAge.Size = new System.Drawing.Size(106, 26);
            this.nUpDoAge.TabIndex = 18;
            this.nUpDoAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(85, 27);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(211, 26);
            this.tBoxName.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Видалити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Редактувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Додати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Sex,
            this.Company});
            this.dataGridView2.Location = new System.Drawing.Point(0, 172);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.Size = new System.Drawing.Size(765, 230);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Age";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Programmer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex.HeaderText = "Gender";
            this.Sex.MinimumWidth = 8;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 8;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.tabControl1);
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDoAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPr;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDowXML;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSaveXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programmer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxGender;
        private System.Windows.Forms.NumericUpDown nUpDoAge;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.ComboBox tBoxCompany;
        public System.Windows.Forms.ComboBox cbProgrammer;
    }
}

