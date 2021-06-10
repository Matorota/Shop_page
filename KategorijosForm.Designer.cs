
namespace Mysql_ir_CSharp
{
    partial class KategorijosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Kategorijos = new System.Windows.Forms.Button();
            this.button_produktas = new System.Windows.Forms.Button();
            this.button_Pardavejas = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_kategorija = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.TextBox_aprasymas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_vardas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kategorija)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Kategorijos
            // 
            this.button_Kategorijos.FlatAppearance.BorderSize = 0;
            this.button_Kategorijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kategorijos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Kategorijos.ForeColor = System.Drawing.Color.Black;
            this.button_Kategorijos.Location = new System.Drawing.Point(-1, -17);
            this.button_Kategorijos.Name = "button_Kategorijos";
            this.button_Kategorijos.Size = new System.Drawing.Size(187, 84);
            this.button_Kategorijos.TabIndex = 34;
            this.button_Kategorijos.Text = "Parduotuve";
            this.button_Kategorijos.UseVisualStyleBackColor = true;
            this.button_Kategorijos.Click += new System.EventHandler(this.button_Parduoti_Click);
            // 
            // button_produktas
            // 
            this.button_produktas.FlatAppearance.BorderSize = 0;
            this.button_produktas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_produktas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_produktas.ForeColor = System.Drawing.Color.Black;
            this.button_produktas.Location = new System.Drawing.Point(542, -16);
            this.button_produktas.Name = "button_produktas";
            this.button_produktas.Size = new System.Drawing.Size(169, 90);
            this.button_produktas.TabIndex = 33;
            this.button_produktas.Text = "Produktas";
            this.button_produktas.UseVisualStyleBackColor = true;
            this.button_produktas.Click += new System.EventHandler(this.button_produktas_Click);
            // 
            // button_Pardavejas
            // 
            this.button_Pardavejas.FlatAppearance.BorderSize = 0;
            this.button_Pardavejas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pardavejas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pardavejas.ForeColor = System.Drawing.Color.Black;
            this.button_Pardavejas.Location = new System.Drawing.Point(736, -9);
            this.button_Pardavejas.Name = "button_Pardavejas";
            this.button_Pardavejas.Size = new System.Drawing.Size(187, 76);
            this.button_Pardavejas.TabIndex = 32;
            this.button_Pardavejas.Text = "Klientai";
            this.button_Pardavejas.UseVisualStyleBackColor = true;
            this.button_Pardavejas.Click += new System.EventHandler(this.button_Pardavejas_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Gray;
            this.label_exit.Location = new System.Drawing.Point(1065, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 30);
            this.label_exit.TabIndex = 31;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.dataGridView_kategorija);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Button_Delete);
            this.panel1.Controls.Add(this.Button_Update);
            this.panel1.Controls.Add(this.Button_Add);
            this.panel1.Controls.Add(this.TextBox_aprasymas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_vardas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 571);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView_kategorija
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_kategorija.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_kategorija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_kategorija.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_kategorija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_kategorija.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_kategorija.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_kategorija.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_kategorija.ColumnHeadersHeight = 24;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_kategorija.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_kategorija.EnableHeadersVisualStyles = false;
            this.dataGridView_kategorija.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_kategorija.Location = new System.Drawing.Point(310, 70);
            this.dataGridView_kategorija.Name = "dataGridView_kategorija";
            this.dataGridView_kategorija.RowHeadersVisible = false;
            this.dataGridView_kategorija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kategorija.Size = new System.Drawing.Size(792, 501);
            this.dataGridView_kategorija.TabIndex = 26;
            this.dataGridView_kategorija.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_kategorija.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_kategorija.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_kategorija.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_kategorija.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_kategorija.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_kategorija.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_kategorija.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_kategorija.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_kategorija.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_kategorija.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_kategorija.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_kategorija.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_kategorija.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_kategorija.ThemeStyle.ReadOnly = false;
            this.dataGridView_kategorija.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_kategorija.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_kategorija.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_kategorija.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_kategorija.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_kategorija.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_kategorija.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_kategorija.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(424, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Valdymo kategorijos  sistema";
            // 
            // Button_Delete
            // 
            this.Button_Delete.FlatAppearance.BorderSize = 0;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Delete.Location = new System.Drawing.Point(180, 191);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(109, 36);
            this.Button_Delete.TabIndex = 22;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.FlatAppearance.BorderSize = 0;
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Update.Location = new System.Drawing.Point(78, 191);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(109, 36);
            this.Button_Update.TabIndex = 21;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add.Location = new System.Drawing.Point(-17, 191);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(109, 36);
            this.Button_Add.TabIndex = 20;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // TextBox_aprasymas
            // 
            this.TextBox_aprasymas.BorderRadius = 10;
            this.TextBox_aprasymas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_aprasymas.DefaultText = "";
            this.TextBox_aprasymas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_aprasymas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_aprasymas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_aprasymas.DisabledState.Parent = this.TextBox_aprasymas;
            this.TextBox_aprasymas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_aprasymas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_aprasymas.FocusedState.Parent = this.TextBox_aprasymas;
            this.TextBox_aprasymas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_aprasymas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_aprasymas.HoverState.Parent = this.TextBox_aprasymas;
            this.TextBox_aprasymas.Location = new System.Drawing.Point(135, 154);
            this.TextBox_aprasymas.Name = "TextBox_aprasymas";
            this.TextBox_aprasymas.PasswordChar = '\0';
            this.TextBox_aprasymas.PlaceholderText = "";
            this.TextBox_aprasymas.SelectedText = "";
            this.TextBox_aprasymas.ShadowDecoration.Parent = this.TextBox_aprasymas;
            this.TextBox_aprasymas.Size = new System.Drawing.Size(154, 30);
            this.TextBox_aprasymas.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Aprasymas";
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
            this.TextBox_vardas.Location = new System.Drawing.Point(135, 116);
            this.TextBox_vardas.Name = "TextBox_vardas";
            this.TextBox_vardas.PasswordChar = '\0';
            this.TextBox_vardas.PlaceholderText = "";
            this.TextBox_vardas.SelectedText = "";
            this.TextBox_vardas.ShadowDecoration.Parent = this.TextBox_vardas;
            this.TextBox_vardas.Size = new System.Drawing.Size(154, 30);
            this.TextBox_vardas.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vardas";
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
            this.TextBox_id.Location = new System.Drawing.Point(135, 80);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.ShadowDecoration.Parent = this.TextBox_id;
            this.TextBox_id.Size = new System.Drawing.Size(154, 30);
            this.TextBox_id.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label_Logout
            // 
            this.label_Logout.AutoSize = true;
            this.label_Logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logout.ForeColor = System.Drawing.Color.Black;
            this.label_Logout.Location = new System.Drawing.Point(949, 13);
            this.label_Logout.Name = "label_Logout";
            this.label_Logout.Size = new System.Drawing.Size(84, 30);
            this.label_Logout.TabIndex = 36;
            this.label_Logout.Text = "Logout";
            this.label_Logout.Click += new System.EventHandler(this.label_Logout_Click);
            this.label_Logout.MouseEnter += new System.EventHandler(this.label_Logout_MouseEnter);
            this.label_Logout.MouseLeave += new System.EventHandler(this.label_Logout_MouseLeave);
            // 
            // KategorijosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label_Logout);
            this.Controls.Add(this.button_Kategorijos);
            this.Controls.Add(this.button_produktas);
            this.Controls.Add(this.button_Pardavejas);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KategorijosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategorijosForm";
            this.Load += new System.EventHandler(this.KategorijosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kategorija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Kategorijos;
        private System.Windows.Forms.Button button_produktas;
        private System.Windows.Forms.Button button_Pardavejas;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_aprasymas;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_vardas;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_kategorija;
        private System.Windows.Forms.Label label_Logout;
    }
}