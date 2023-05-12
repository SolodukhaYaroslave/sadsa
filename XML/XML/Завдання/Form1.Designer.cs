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
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            "true",
            "false"});
            this.cBoxPr.Location = new System.Drawing.Point(626, 68);
            this.cBoxPr.Name = "cBoxPr";
            this.cBoxPr.Size = new System.Drawing.Size(121, 28);
            this.cBoxPr.TabIndex = 9;
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
            this.btDelete.Location = new System.Drawing.Point(588, 143);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(180, 35);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Видалити";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(289, 143);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(180, 35);
            this.btChange.TabIndex = 5;
            this.btChange.Text = "Редактувати";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(0, 143);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(180, 35);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Додати";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDowXML
            // 
            this.btDowXML.Location = new System.Drawing.Point(588, 427);
            this.btDowXML.Name = "btDowXML";
            this.btDowXML.Size = new System.Drawing.Size(180, 35);
            this.btDowXML.TabIndex = 3;
            this.btDowXML.Text = "Загрузити XML";
            this.btDowXML.UseVisualStyleBackColor = true;
            this.btDowXML.Click += new System.EventHandler(this.btDowXML_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(289, 427);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(180, 35);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Очистити таблицю";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSaveXML
            // 
            this.btSaveXML.Location = new System.Drawing.Point(0, 427);
            this.btSaveXML.Name = "btSaveXML";
            this.btSaveXML.Size = new System.Drawing.Size(180, 35);
            this.btSaveXML.TabIndex = 1;
            this.btSaveXML.Text = "Зберегти XML";
            this.btSaveXML.UseVisualStyleBackColor = true;
            this.btSaveXML.Click += new System.EventHandler(this.btSaveXML_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Age,
            this.Programmer});
            this.dataGridView1.Location = new System.Drawing.Point(0, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
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
            // 
            // Programmer
            // 
            this.Programmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Programmer.HeaderText = "Programmer";
            this.Programmer.MinimumWidth = 8;
            this.Programmer.Name = "Programmer";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 465);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Завдання 3";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

