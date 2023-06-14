
namespace Sofronov
{
    partial class Menager
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxskidcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvoditelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opicanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sofronovDataSet = new Sofronov.sofronovDataSet();
            this.tovarTableAdapter = new Sofronov.sofronovDataSetTableAdapters.TovarTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.articulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edenicaizmereniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavhicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skidkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new Sofronov.sofronovDataSetTableAdapters.SkladTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sofronovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.saleDataGridViewTextBoxColumn,
            this.maxskidcaDataGridViewTextBoxColumn,
            this.proizvoditelDataGridViewTextBoxColumn,
            this.opicanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(972, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // articulDataGridViewTextBoxColumn
            // 
            this.articulDataGridViewTextBoxColumn.DataPropertyName = "Articul";
            this.articulDataGridViewTextBoxColumn.HeaderText = "Articul";
            this.articulDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.articulDataGridViewTextBoxColumn.Name = "articulDataGridViewTextBoxColumn";
            this.articulDataGridViewTextBoxColumn.ReadOnly = true;
            this.articulDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // saleDataGridViewTextBoxColumn
            // 
            this.saleDataGridViewTextBoxColumn.DataPropertyName = "Sale";
            this.saleDataGridViewTextBoxColumn.HeaderText = "Sale";
            this.saleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saleDataGridViewTextBoxColumn.Name = "saleDataGridViewTextBoxColumn";
            this.saleDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDataGridViewTextBoxColumn.Width = 150;
            // 
            // maxskidcaDataGridViewTextBoxColumn
            // 
            this.maxskidcaDataGridViewTextBoxColumn.DataPropertyName = "Max_skidca";
            this.maxskidcaDataGridViewTextBoxColumn.HeaderText = "Max_skidca";
            this.maxskidcaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxskidcaDataGridViewTextBoxColumn.Name = "maxskidcaDataGridViewTextBoxColumn";
            this.maxskidcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxskidcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // proizvoditelDataGridViewTextBoxColumn
            // 
            this.proizvoditelDataGridViewTextBoxColumn.DataPropertyName = "Proizvoditel";
            this.proizvoditelDataGridViewTextBoxColumn.HeaderText = "Proizvoditel";
            this.proizvoditelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.proizvoditelDataGridViewTextBoxColumn.Name = "proizvoditelDataGridViewTextBoxColumn";
            this.proizvoditelDataGridViewTextBoxColumn.ReadOnly = true;
            this.proizvoditelDataGridViewTextBoxColumn.Width = 150;
            // 
            // opicanieDataGridViewTextBoxColumn
            // 
            this.opicanieDataGridViewTextBoxColumn.DataPropertyName = "Opicanie";
            this.opicanieDataGridViewTextBoxColumn.HeaderText = "Opicanie";
            this.opicanieDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opicanieDataGridViewTextBoxColumn.Name = "opicanieDataGridViewTextBoxColumn";
            this.opicanieDataGridViewTextBoxColumn.ReadOnly = true;
            this.opicanieDataGridViewTextBoxColumn.Width = 150;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.sofronovDataSet;
            // 
            // sofronovDataSet
            // 
            this.sofronovDataSet.DataSetName = "sofronovDataSet";
            this.sofronovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulDataGridViewTextBoxColumn1,
            this.edenicaizmereniaDataGridViewTextBoxColumn,
            this.postavhicDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.skidkaDataGridViewTextBoxColumn,
            this.colhestvoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.skladBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(972, 226);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            // 
            // articulDataGridViewTextBoxColumn1
            // 
            this.articulDataGridViewTextBoxColumn1.DataPropertyName = "Articul";
            this.articulDataGridViewTextBoxColumn1.HeaderText = "Articul";
            this.articulDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.articulDataGridViewTextBoxColumn1.Name = "articulDataGridViewTextBoxColumn1";
            this.articulDataGridViewTextBoxColumn1.ReadOnly = true;
            this.articulDataGridViewTextBoxColumn1.Width = 150;
            // 
            // edenicaizmereniaDataGridViewTextBoxColumn
            // 
            this.edenicaizmereniaDataGridViewTextBoxColumn.DataPropertyName = "Edenica_izmerenia";
            this.edenicaizmereniaDataGridViewTextBoxColumn.HeaderText = "Edenica_izmerenia";
            this.edenicaizmereniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.edenicaizmereniaDataGridViewTextBoxColumn.Name = "edenicaizmereniaDataGridViewTextBoxColumn";
            this.edenicaizmereniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.edenicaizmereniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // postavhicDataGridViewTextBoxColumn
            // 
            this.postavhicDataGridViewTextBoxColumn.DataPropertyName = "Postavhic";
            this.postavhicDataGridViewTextBoxColumn.HeaderText = "Postavhic";
            this.postavhicDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postavhicDataGridViewTextBoxColumn.Name = "postavhicDataGridViewTextBoxColumn";
            this.postavhicDataGridViewTextBoxColumn.ReadOnly = true;
            this.postavhicDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // skidkaDataGridViewTextBoxColumn
            // 
            this.skidkaDataGridViewTextBoxColumn.DataPropertyName = "Skidka";
            this.skidkaDataGridViewTextBoxColumn.HeaderText = "Skidka";
            this.skidkaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.skidkaDataGridViewTextBoxColumn.Name = "skidkaDataGridViewTextBoxColumn";
            this.skidkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.skidkaDataGridViewTextBoxColumn.Width = 150;
            // 
            // colhestvoDataGridViewTextBoxColumn
            // 
            this.colhestvoDataGridViewTextBoxColumn.DataPropertyName = "Colhestvo";
            this.colhestvoDataGridViewTextBoxColumn.HeaderText = "Colhestvo";
            this.colhestvoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colhestvoDataGridViewTextBoxColumn.Name = "colhestvoDataGridViewTextBoxColumn";
            this.colhestvoDataGridViewTextBoxColumn.ReadOnly = true;
            this.colhestvoDataGridViewTextBoxColumn.Width = 150;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.sofronovDataSet;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.guna2Button7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 48);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-9",
            "10-14",
            "15-больше"});
            this.comboBox1.Location = new System.Drawing.Point(708, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(835, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(835, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 18;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(448, 6);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(159, 39);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Склад";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(283, 6);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(159, 39);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Товары";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Менеджер";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button5);
            this.panel2.Controls.Add(this.guna2Button6);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 448);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(863, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Строки";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(535, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "B111C5",
            "E112C6",
            "K839K3",
            "L293S9",
            "M112C8",
            "M294G9",
            "M398S9",
            "N283K3",
            "S384K2",
            "T238C7"});
            this.comboBox2.Location = new System.Drawing.Point(534, 247);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 28);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderRadius = 21;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Location = new System.Drawing.Point(812, 247);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(173, 45);
            this.guna2Button4.TabIndex = 11;
            this.guna2Button4.Text = "Подсчет строк";
            this.guna2Button4.Visible = false;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(233, 247);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(202, 45);
            this.guna2Button3.TabIndex = 10;
            this.guna2Button3.Text = "Подствет строк";
            this.guna2Button3.Visible = false;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BorderRadius = 21;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Location = new System.Drawing.Point(13, 298);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(215, 45);
            this.guna2Button5.TabIndex = 9;
            this.guna2Button5.Text = "По возростанию";
            this.guna2Button5.Visible = false;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.AutoRoundedCorners = true;
            this.guna2Button6.BorderRadius = 21;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Location = new System.Drawing.Point(13, 247);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(215, 45);
            this.guna2Button6.TabIndex = 8;
            this.guna2Button6.Text = "По убыванию ";
            this.guna2Button6.Visible = false;
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.AutoRoundedCorners = true;
            this.guna2Button7.BorderRadius = 13;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.Location = new System.Drawing.Point(132, 10);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(145, 29);
            this.guna2Button7.TabIndex = 7;
            this.guna2Button7.Text = "Назад";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // Menager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menager";
            this.Text = "Menager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menager_FormClosing);
            this.Load += new System.EventHandler(this.Menager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sofronovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sofronovDataSet sofronovDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private sofronovDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxskidcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvoditelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opicanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private sofronovDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn edenicaizmereniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavhicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skidkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
    }
}