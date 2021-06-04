
namespace VitchMat_SNY
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.X0 = new System.Windows.Forms.DataGridView();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.t_e = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.l_k = new DarkUI.Controls.DarkLabel();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.R_prost = new DarkUI.Controls.DarkRadioButton();
            this.R_Koord = new DarkUI.Controls.DarkRadioButton();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.Xlast = new System.Windows.Forms.DataGridView();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.Xtmp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.X0)).BeginInit();
            this.darkGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xlast)).BeginInit();
            this.darkGroupBox2.SuspendLayout();
            this.darkGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xtmp)).BeginInit();
            this.SuspendLayout();
            // 
            // X0
            // 
            this.X0.AllowUserToAddRows = false;
            this.X0.AllowUserToDeleteRows = false;
            this.X0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.X0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.X0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.X0.ColumnHeadersVisible = false;
            this.X0.Location = new System.Drawing.Point(116, 46);
            this.X0.Margin = new System.Windows.Forms.Padding(2);
            this.X0.Name = "X0";
            this.X0.RowHeadersVisible = false;
            this.X0.RowHeadersWidth = 51;
            this.X0.RowTemplate.Height = 24;
            this.X0.Size = new System.Drawing.Size(51, 43);
            this.X0.TabIndex = 66;
            this.X0.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(11, 11);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(105, 13);
            this.darkLabel6.TabIndex = 68;
            this.darkLabel6.Text = "Погрешность e = 0,";
            // 
            // t_e
            // 
            this.t_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_e.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_e.Location = new System.Drawing.Point(116, 9);
            this.t_e.Name = "t_e";
            this.t_e.Size = new System.Drawing.Size(51, 20);
            this.t_e.TabIndex = 67;
            this.t_e.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_e_KeyPress);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(93, 46);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(23, 13);
            this.darkLabel1.TabIndex = 69;
            this.darkLabel1.Text = "X0:";
            // 
            // l_k
            // 
            this.l_k.AutoSize = true;
            this.l_k.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.l_k.Location = new System.Drawing.Point(103, 6);
            this.l_k.Name = "l_k";
            this.l_k.Size = new System.Drawing.Size(13, 13);
            this.l_k.TabIndex = 74;
            this.l_k.Text = "0";
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(3, 6);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(94, 13);
            this.darkLabel5.TabIndex = 73;
            this.darkLabel5.Text = "Число Итераций:";
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(25, 240);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(102, 23);
            this.darkButton2.TabIndex = 72;
            this.darkButton2.Text = "Поехали";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // R_prost
            // 
            this.R_prost.AutoSize = true;
            this.R_prost.Checked = true;
            this.R_prost.Location = new System.Drawing.Point(14, 103);
            this.R_prost.Name = "R_prost";
            this.R_prost.Size = new System.Drawing.Size(151, 17);
            this.R_prost.TabIndex = 75;
            this.R_prost.TabStop = true;
            this.R_prost.Text = "Метод простой итерации";
            // 
            // R_Koord
            // 
            this.R_Koord.AutoSize = true;
            this.R_Koord.Location = new System.Drawing.Point(14, 126);
            this.R_Koord.Name = "R_Koord";
            this.R_Koord.Size = new System.Drawing.Size(194, 17);
            this.R_Koord.TabIndex = 76;
            this.R_Koord.Text = "Метод покоординатных итераций";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox1.Controls.Add(this.R_Koord);
            this.darkGroupBox1.Controls.Add(this.R_prost);
            this.darkGroupBox1.Controls.Add(this.darkLabel1);
            this.darkGroupBox1.Controls.Add(this.darkLabel6);
            this.darkGroupBox1.Controls.Add(this.t_e);
            this.darkGroupBox1.Controls.Add(this.X0);
            this.darkGroupBox1.Location = new System.Drawing.Point(22, 79);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(216, 155);
            this.darkGroupBox1.TabIndex = 77;
            this.darkGroupBox1.TabStop = false;
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(42, 46);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(20, 13);
            this.darkLabel2.TabIndex = 78;
            this.darkLabel2.Text = " X:";
            // 
            // Xlast
            // 
            this.Xlast.AllowUserToAddRows = false;
            this.Xlast.AllowUserToDeleteRows = false;
            this.Xlast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Xlast.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Xlast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Xlast.ColumnHeadersVisible = false;
            this.Xlast.Location = new System.Drawing.Point(67, 46);
            this.Xlast.Margin = new System.Windows.Forms.Padding(2);
            this.Xlast.Name = "Xlast";
            this.Xlast.ReadOnly = true;
            this.Xlast.RowHeadersVisible = false;
            this.Xlast.RowHeadersWidth = 51;
            this.Xlast.RowTemplate.Height = 24;
            this.Xlast.Size = new System.Drawing.Size(51, 43);
            this.Xlast.TabIndex = 77;
            this.Xlast.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox2.Controls.Add(this.darkLabel2);
            this.darkGroupBox2.Controls.Add(this.Xlast);
            this.darkGroupBox2.Controls.Add(this.l_k);
            this.darkGroupBox2.Controls.Add(this.darkLabel5);
            this.darkGroupBox2.Location = new System.Drawing.Point(244, 79);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(156, 155);
            this.darkGroupBox2.TabIndex = 79;
            this.darkGroupBox2.TabStop = false;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(6, 16);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(86, 13);
            this.darkLabel3.TabIndex = 77;
            this.darkLabel3.Text = "x^2 + y^2 - 4 = 0";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(6, 38);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(74, 13);
            this.darkLabel4.TabIndex = 80;
            this.darkLabel4.Text = "x^3 - y + 2 = 0";
            // 
            // darkGroupBox3
            // 
            this.darkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox3.Controls.Add(this.darkLabel4);
            this.darkGroupBox3.Controls.Add(this.darkLabel3);
            this.darkGroupBox3.Location = new System.Drawing.Point(22, 13);
            this.darkGroupBox3.Name = "darkGroupBox3";
            this.darkGroupBox3.Size = new System.Drawing.Size(105, 60);
            this.darkGroupBox3.TabIndex = 81;
            this.darkGroupBox3.TabStop = false;
            this.darkGroupBox3.Text = "СНУ:";
            // 
            // Xtmp
            // 
            this.Xtmp.AllowUserToAddRows = false;
            this.Xtmp.AllowUserToDeleteRows = false;
            this.Xtmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Xtmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Xtmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Xtmp.ColumnHeadersVisible = false;
            this.Xtmp.Location = new System.Drawing.Point(457, 125);
            this.Xtmp.Margin = new System.Windows.Forms.Padding(2);
            this.Xtmp.Name = "Xtmp";
            this.Xtmp.ReadOnly = true;
            this.Xtmp.RowHeadersVisible = false;
            this.Xtmp.RowHeadersWidth = 51;
            this.Xtmp.RowTemplate.Height = 24;
            this.Xtmp.Size = new System.Drawing.Size(51, 43);
            this.Xtmp.TabIndex = 82;
            this.Xtmp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 280);
            this.Controls.Add(this.Xtmp);
            this.Controls.Add(this.darkGroupBox3);
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.darkGroupBox1);
            this.Controls.Add(this.darkButton2);
            this.Name = "Form1";
            this.Text = "Решение СНУ";
            ((System.ComponentModel.ISupportInitialize)(this.X0)).EndInit();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xlast)).EndInit();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.darkGroupBox3.ResumeLayout(false);
            this.darkGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xtmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView X0;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkTextBox t_e;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel l_k;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkRadioButton R_prost;
        private DarkUI.Controls.DarkRadioButton R_Koord;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private System.Windows.Forms.DataGridView Xlast;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkGroupBox darkGroupBox3;
        private System.Windows.Forms.DataGridView Xtmp;
    }
}

