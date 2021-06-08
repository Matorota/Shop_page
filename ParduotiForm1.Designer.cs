
namespace Mysql_ir_CSharp
{
    partial class ParduotiForm1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_kiekisSt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridView_Parduotu_sarasas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_kategorija = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_pardavejas = new System.Windows.Forms.Label();
            this.DataGridView_produktas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridView_uzsakyti = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiekis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_AddOrder = new System.Windows.Forms.Button();
            this.TextBox_kiekis = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_kaina = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_vardas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Parduotu_sarasas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_produktas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uzsakyti)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.Black;
            this.button_logout.Location = new System.Drawing.Point(900, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(135, 41);
            this.button_logout.TabIndex = 40;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            this.button_logout.MouseEnter += new System.EventHandler(this.button_logout_MouseEnter);
            this.button_logout.MouseLeave += new System.EventHandler(this.button_logout_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_kiekisSt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DataGridView_Parduotu_sarasas);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_kategorija);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_pardavejas);
            this.panel1.Controls.Add(this.DataGridView_produktas);
            this.panel1.Controls.Add(this.dataGridView_uzsakyti);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Button_Add);
            this.panel1.Controls.Add(this.Button_AddOrder);
            this.panel1.Controls.Add(this.TextBox_kiekis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_kaina);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_vardas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 532);
            this.panel1.TabIndex = 36;
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 10;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.Parent = this.TextBox_id;
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.FocusedState.Parent = this.TextBox_id;
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.HoverState.Parent = this.TextBox_id;
            this.TextBox_id.Location = new System.Drawing.Point(888, 239);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.ShadowDecoration.Parent = this.TextBox_id;
            this.TextBox_id.Size = new System.Drawing.Size(57, 30);
            this.TextBox_id.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(733, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 30);
            this.label8.TabIndex = 36;
            this.label8.Text = "Saskaitos Id";
            // 
            // label_kiekisSt
            // 
            this.label_kiekisSt.AutoSize = true;
            this.label_kiekisSt.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kiekisSt.ForeColor = System.Drawing.Color.Snow;
            this.label_kiekisSt.Location = new System.Drawing.Point(921, 202);
            this.label_kiekisSt.Name = "label_kiekisSt";
            this.label_kiekisSt.Size = new System.Drawing.Size(62, 30);
            this.label_kiekisSt.TabIndex = 35;
            this.label_kiekisSt.Text = "Eurai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(722, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 30);
            this.label7.TabIndex = 34;
            this.label7.Text = "Kiekis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(305, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Parduotu sarašas";
            // 
            // DataGridView_Parduotu_sarasas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_Parduotu_sarasas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Parduotu_sarasas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Parduotu_sarasas.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Parduotu_sarasas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Parduotu_sarasas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Parduotu_sarasas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Parduotu_sarasas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Parduotu_sarasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Parduotu_sarasas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Parduotu_sarasas.EnableHeadersVisualStyles = false;
            this.DataGridView_Parduotu_sarasas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Parduotu_sarasas.Location = new System.Drawing.Point(310, 275);
            this.DataGridView_Parduotu_sarasas.Name = "DataGridView_Parduotu_sarasas";
            this.DataGridView_Parduotu_sarasas.RowHeadersVisible = false;
            this.DataGridView_Parduotu_sarasas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Parduotu_sarasas.Size = new System.Drawing.Size(774, 282);
            this.DataGridView_Parduotu_sarasas.TabIndex = 32;
            this.DataGridView_Parduotu_sarasas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Parduotu_sarasas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Parduotu_sarasas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Parduotu_sarasas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.ReadOnly = false;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Parduotu_sarasas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Parduotu_sarasas.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_Parduotu_sarasas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Parduotu_sarasas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_refresh.Location = new System.Drawing.Point(168, 235);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(113, 38);
            this.button_refresh.TabIndex = 31;
            this.button_refresh.Text = "Perkrauti";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_kategorija
            // 
            this.comboBox_kategorija.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_kategorija.FormattingEnabled = true;
            this.comboBox_kategorija.Location = new System.Drawing.Point(17, 242);
            this.comboBox_kategorija.Name = "comboBox_kategorija";
            this.comboBox_kategorija.Size = new System.Drawing.Size(150, 27);
            this.comboBox_kategorija.TabIndex = 30;
            this.comboBox_kategorija.Text = "Pasirinkite kategorija";
            this.comboBox_kategorija.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategorija_SelectedIndexChanged);
            this.comboBox_kategorija.SelectionChangeCommitted += new System.EventHandler(this.comboBox_kategorija_SelectionChangeCommitted);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Snow;
            this.label_date.Location = new System.Drawing.Point(765, 9);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(64, 30);
            this.label_date.TabIndex = 29;
            this.label_date.Text = "Data:";
            // 
            // label_pardavejas
            // 
            this.label_pardavejas.AutoSize = true;
            this.label_pardavejas.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pardavejas.ForeColor = System.Drawing.Color.Snow;
            this.label_pardavejas.Location = new System.Drawing.Point(12, 0);
            this.label_pardavejas.Name = "label_pardavejas";
            this.label_pardavejas.Size = new System.Drawing.Size(176, 30);
            this.label_pardavejas.TabIndex = 28;
            this.label_pardavejas.Text = "PardavejoVardas";
            // 
            // DataGridView_produktas
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_produktas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_produktas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_produktas.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_produktas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_produktas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_produktas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_produktas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_produktas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_produktas.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_produktas.EnableHeadersVisualStyles = false;
            this.DataGridView_produktas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_produktas.Location = new System.Drawing.Point(17, 275);
            this.DataGridView_produktas.Name = "DataGridView_produktas";
            this.DataGridView_produktas.RowHeadersVisible = false;
            this.DataGridView_produktas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_produktas.Size = new System.Drawing.Size(258, 282);
            this.DataGridView_produktas.TabIndex = 27;
            this.DataGridView_produktas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView_produktas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_produktas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_produktas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_produktas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_produktas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_produktas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_produktas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_produktas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_produktas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_produktas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_produktas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_produktas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView_produktas.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridView_produktas.ThemeStyle.ReadOnly = false;
            this.DataGridView_produktas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_produktas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_produktas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_produktas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_produktas.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_produktas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_produktas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_produktas.Click += new System.EventHandler(this.DataGridView_produktas_Click);
            // 
            // dataGridView_uzsakyti
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_uzsakyti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_uzsakyti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_uzsakyti.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_uzsakyti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_uzsakyti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_uzsakyti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_uzsakyti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_uzsakyti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_uzsakyti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Vardas,
            this.Kaina,
            this.Kiekis,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_uzsakyti.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_uzsakyti.EnableHeadersVisualStyles = false;
            this.dataGridView_uzsakyti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_uzsakyti.Location = new System.Drawing.Point(310, 51);
            this.dataGridView_uzsakyti.Name = "dataGridView_uzsakyti";
            this.dataGridView_uzsakyti.RowHeadersVisible = false;
            this.dataGridView_uzsakyti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_uzsakyti.Size = new System.Drawing.Size(766, 138);
            this.dataGridView_uzsakyti.TabIndex = 26;
            this.dataGridView_uzsakyti.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_uzsakyti.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_uzsakyti.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_uzsakyti.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_uzsakyti.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_uzsakyti.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_uzsakyti.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_uzsakyti.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_uzsakyti.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_uzsakyti.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_uzsakyti.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_uzsakyti.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_uzsakyti.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_uzsakyti.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView_uzsakyti.ThemeStyle.ReadOnly = false;
            this.dataGridView_uzsakyti.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_uzsakyti.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_uzsakyti.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_uzsakyti.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_uzsakyti.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_uzsakyti.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_uzsakyti.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Vardas
            // 
            this.Vardas.HeaderText = "Vardas";
            this.Vardas.Name = "Vardas";
            // 
            // Kaina
            // 
            this.Kaina.HeaderText = "Kaina";
            this.Kaina.Name = "Kaina";
            // 
            // Kiekis
            // 
            this.Kiekis.HeaderText = "Kiekis";
            this.Kiekis.Name = "Kiekis";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(468, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Parduotuvė";
            // 
            // Button_Add
            // 
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Add.Location = new System.Drawing.Point(967, 232);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(109, 36);
            this.Button_Add.TabIndex = 21;
            this.Button_Add.Text = "Prideti";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_AddOrder
            // 
            this.Button_AddOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_AddOrder.FlatAppearance.BorderSize = 0;
            this.Button_AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddOrder.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_AddOrder.Location = new System.Drawing.Point(33, 196);
            this.Button_AddOrder.Name = "Button_AddOrder";
            this.Button_AddOrder.Size = new System.Drawing.Size(242, 36);
            this.Button_AddOrder.TabIndex = 20;
            this.Button_AddOrder.Text = "Prideti uzsakyma";
            this.Button_AddOrder.UseVisualStyleBackColor = false;
            this.Button_AddOrder.Click += new System.EventHandler(this.Button_AddOrder_Click);
            // 
            // TextBox_kiekis
            // 
            this.TextBox_kiekis.BorderRadius = 10;
            this.TextBox_kiekis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_kiekis.DefaultText = "";
            this.TextBox_kiekis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_kiekis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_kiekis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_kiekis.DisabledState.Parent = this.TextBox_kiekis;
            this.TextBox_kiekis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_kiekis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_kiekis.FocusedState.Parent = this.TextBox_kiekis;
            this.TextBox_kiekis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_kiekis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_kiekis.HoverState.Parent = this.TextBox_kiekis;
            this.TextBox_kiekis.Location = new System.Drawing.Point(121, 143);
            this.TextBox_kiekis.Name = "TextBox_kiekis";
            this.TextBox_kiekis.PasswordChar = '\0';
            this.TextBox_kiekis.PlaceholderText = "";
            this.TextBox_kiekis.SelectedText = "";
            this.TextBox_kiekis.ShadowDecoration.Parent = this.TextBox_kiekis;
            this.TextBox_kiekis.Size = new System.Drawing.Size(154, 30);
            this.TextBox_kiekis.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kiekis";
            // 
            // TextBox_kaina
            // 
            this.TextBox_kaina.BorderRadius = 10;
            this.TextBox_kaina.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_kaina.DefaultText = "";
            this.TextBox_kaina.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_kaina.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_kaina.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_kaina.DisabledState.Parent = this.TextBox_kaina;
            this.TextBox_kaina.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_kaina.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_kaina.FocusedState.Parent = this.TextBox_kaina;
            this.TextBox_kaina.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_kaina.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_kaina.HoverState.Parent = this.TextBox_kaina;
            this.TextBox_kaina.Location = new System.Drawing.Point(121, 107);
            this.TextBox_kaina.Name = "TextBox_kaina";
            this.TextBox_kaina.PasswordChar = '\0';
            this.TextBox_kaina.PlaceholderText = "";
            this.TextBox_kaina.ReadOnly = true;
            this.TextBox_kaina.SelectedText = "";
            this.TextBox_kaina.ShadowDecoration.Parent = this.TextBox_kaina;
            this.TextBox_kaina.Size = new System.Drawing.Size(154, 30);
            this.TextBox_kaina.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kaina";
            // 
            // TextBox_vardas
            // 
            this.TextBox_vardas.BorderRadius = 10;
            this.TextBox_vardas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_vardas.DefaultText = "";
            this.TextBox_vardas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_vardas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_vardas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_vardas.DisabledState.Parent = this.TextBox_vardas;
            this.TextBox_vardas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_vardas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_vardas.FocusedState.Parent = this.TextBox_vardas;
            this.TextBox_vardas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_vardas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_vardas.HoverState.Parent = this.TextBox_vardas;
            this.TextBox_vardas.Location = new System.Drawing.Point(121, 71);
            this.TextBox_vardas.Name = "TextBox_vardas";
            this.TextBox_vardas.PasswordChar = '\0';
            this.TextBox_vardas.PlaceholderText = "";
            this.TextBox_vardas.ReadOnly = true;
            this.TextBox_vardas.SelectedText = "";
            this.TextBox_vardas.ShadowDecoration.Parent = this.TextBox_vardas;
            this.TextBox_vardas.Size = new System.Drawing.Size(154, 30);
            this.TextBox_vardas.TabIndex = 13;
            this.TextBox_vardas.TextChanged += new System.EventHandler(this.TextBox_vardas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vardas";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Gray;
            this.label_exit.Location = new System.Drawing.Point(1073, -2);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 30);
            this.label_exit.TabIndex = 41;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // ParduotiForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParduotiForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParduotiForm1";
            this.Load += new System.EventHandler(this.ParduotiForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Parduotu_sarasas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_produktas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uzsakyti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_uzsakyti;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_AddOrder;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_kiekis;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_kaina;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_vardas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_produktas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_kategorija;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_pardavejas;
        private System.Windows.Forms.Label label_kiekisSt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Parduotu_sarasas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiekis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label8;
    }
}