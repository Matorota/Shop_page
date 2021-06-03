
namespace Mysql_ir_CSharp
{
    partial class ProduktaiForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Add = new System.Windows.Forms.Button();
            this.comboBox_kategorija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_kaina = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_kiekis = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_vardas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.comboBox_kategorijos = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Pardavejas = new System.Windows.Forms.Button();
            this.button_Kategorijos = new System.Windows.Forms.Button();
            this.button_Parduoti = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_kategorijos);
            this.panel1.Controls.Add(this.Button_Delete);
            this.panel1.Controls.Add(this.Button_Update);
            this.panel1.Controls.Add(this.Button_Add);
            this.panel1.Controls.Add(this.comboBox_kategorija);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TextBox_kaina);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_kiekis);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_vardas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(143, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 535);
            this.panel1.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add.Location = new System.Drawing.Point(-17, 277);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(109, 36);
            this.Button_Add.TabIndex = 20;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // comboBox_kategorija
            // 
            this.comboBox_kategorija.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_kategorija.FormattingEnabled = true;
            this.comboBox_kategorija.Items.AddRange(new object[] {
            "Admin",
            "Pardavejas"});
            this.comboBox_kategorija.Location = new System.Drawing.Point(121, 226);
            this.comboBox_kategorija.Name = "comboBox_kategorija";
            this.comboBox_kategorija.Size = new System.Drawing.Size(154, 33);
            this.comboBox_kategorija.TabIndex = 19;
            this.comboBox_kategorija.Text = "Pasirinkite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kategorija";
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
            this.TextBox_kaina.Location = new System.Drawing.Point(121, 188);
            this.TextBox_kaina.Name = "TextBox_kaina";
            this.TextBox_kaina.PasswordChar = '\0';
            this.TextBox_kaina.PlaceholderText = "";
            this.TextBox_kaina.SelectedText = "";
            this.TextBox_kaina.ShadowDecoration.Parent = this.TextBox_kaina;
            this.TextBox_kaina.Size = new System.Drawing.Size(154, 30);
            this.TextBox_kaina.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kaina";
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
            this.TextBox_kiekis.Location = new System.Drawing.Point(121, 152);
            this.TextBox_kiekis.Name = "TextBox_kiekis";
            this.TextBox_kiekis.PasswordChar = '\0';
            this.TextBox_kiekis.PlaceholderText = "";
            this.TextBox_kiekis.SelectedText = "";
            this.TextBox_kiekis.ShadowDecoration.Parent = this.TextBox_kiekis;
            this.TextBox_kiekis.Size = new System.Drawing.Size(154, 30);
            this.TextBox_kiekis.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kiekis";
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
            this.TextBox_vardas.Location = new System.Drawing.Point(121, 116);
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
            this.TextBox_id.Location = new System.Drawing.Point(121, 80);
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
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Gray;
            this.label_exit.Location = new System.Drawing.Point(840, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 30);
            this.label_exit.TabIndex = 10;
            this.label_exit.Text = "X";
            // 
            // Button_Update
            // 
            this.Button_Update.FlatAppearance.BorderSize = 0;
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Update.Location = new System.Drawing.Point(78, 277);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(109, 36);
            this.Button_Update.TabIndex = 21;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            // 
            // Button_Delete
            // 
            this.Button_Delete.FlatAppearance.BorderSize = 0;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Delete.Location = new System.Drawing.Point(180, 277);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(109, 36);
            this.Button_Delete.TabIndex = 22;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            // 
            // comboBox_kategorijos
            // 
            this.comboBox_kategorijos.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_kategorijos.FormattingEnabled = true;
            this.comboBox_kategorijos.Items.AddRange(new object[] {
            "Admin",
            "Pardavejas"});
            this.comboBox_kategorijos.Location = new System.Drawing.Point(346, 39);
            this.comboBox_kategorijos.Name = "comboBox_kategorijos";
            this.comboBox_kategorijos.Size = new System.Drawing.Size(154, 33);
            this.comboBox_kategorijos.TabIndex = 23;
            this.comboBox_kategorijos.Text = "Pasirinkite";
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_refresh.Location = new System.Drawing.Point(506, 36);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(109, 36);
            this.button_refresh.TabIndex = 24;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(274, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Management system";
            // 
            // button_Pardavejas
            // 
            this.button_Pardavejas.FlatAppearance.BorderSize = 0;
            this.button_Pardavejas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pardavejas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pardavejas.ForeColor = System.Drawing.Color.Black;
            this.button_Pardavejas.Location = new System.Drawing.Point(2, 35);
            this.button_Pardavejas.Name = "button_Pardavejas";
            this.button_Pardavejas.Size = new System.Drawing.Size(135, 41);
            this.button_Pardavejas.TabIndex = 26;
            this.button_Pardavejas.Text = "Pardavėjas";
            this.button_Pardavejas.UseVisualStyleBackColor = true;
            // 
            // button_Kategorijos
            // 
            this.button_Kategorijos.FlatAppearance.BorderSize = 0;
            this.button_Kategorijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kategorijos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Kategorijos.ForeColor = System.Drawing.Color.Black;
            this.button_Kategorijos.Location = new System.Drawing.Point(2, 102);
            this.button_Kategorijos.Name = "button_Kategorijos";
            this.button_Kategorijos.Size = new System.Drawing.Size(135, 41);
            this.button_Kategorijos.TabIndex = 27;
            this.button_Kategorijos.Text = "Kategorijos";
            this.button_Kategorijos.UseVisualStyleBackColor = true;
            // 
            // button_Parduoti
            // 
            this.button_Parduoti.FlatAppearance.BorderSize = 0;
            this.button_Parduoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Parduoti.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Parduoti.ForeColor = System.Drawing.Color.Black;
            this.button_Parduoti.Location = new System.Drawing.Point(2, 174);
            this.button_Parduoti.Name = "button_Parduoti";
            this.button_Parduoti.Size = new System.Drawing.Size(135, 41);
            this.button_Parduoti.TabIndex = 28;
            this.button_Parduoti.Text = "Parduoti";
            this.button_Parduoti.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.Black;
            this.button_logout.Location = new System.Drawing.Point(2, 518);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(135, 41);
            this.button_logout.TabIndex = 29;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(281, 78);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.Size = new System.Drawing.Size(504, 436);
            this.dataGridView_product.TabIndex = 26;
            // 
            // ProduktaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 554);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_Parduoti);
            this.Controls.Add(this.button_Kategorijos);
            this.Controls.Add(this.button_Pardavejas);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ProduktaiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProduktaiForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_kaina;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_kiekis;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_vardas;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.ComboBox comboBox_kategorija;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_kategorijos;
        private System.Windows.Forms.Button button_Pardavejas;
        private System.Windows.Forms.Button button_Kategorijos;
        private System.Windows.Forms.Button button_Parduoti;
        private System.Windows.Forms.Button button_logout;
    }
}