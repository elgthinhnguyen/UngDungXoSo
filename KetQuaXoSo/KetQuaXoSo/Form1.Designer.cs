namespace KetQuaXoSo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMIenNam = new System.Windows.Forms.RadioButton();
            this.rbMIenBac = new System.Windows.Forms.RadioButton();
            this.rbMIenTrung = new System.Windows.Forms.RadioButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.tabKetQua = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.rbMIenTrung);
            this.groupBox1.Controls.Add(this.rbMIenBac);
            this.groupBox1.Controls.Add(this.rbMIenNam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn vùng, thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(363, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xổ Số Các MIền";
            // 
            // rbMIenNam
            // 
            this.rbMIenNam.AccessibleName = "";
            this.rbMIenNam.AutoSize = true;
            this.rbMIenNam.Checked = true;
            this.rbMIenNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rbMIenNam.Location = new System.Drawing.Point(22, 41);
            this.rbMIenNam.Name = "rbMIenNam";
            this.rbMIenNam.Size = new System.Drawing.Size(114, 24);
            this.rbMIenNam.TabIndex = 0;
            this.rbMIenNam.TabStop = true;
            this.rbMIenNam.Text = "Miền Nam";
            this.rbMIenNam.UseVisualStyleBackColor = true;
            this.rbMIenNam.CheckedChanged += new System.EventHandler(this.rbMIenNam_CheckedChanged);
            // 
            // rbMIenBac
            // 
            this.rbMIenBac.AccessibleName = "";
            this.rbMIenBac.AutoSize = true;
            this.rbMIenBac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMIenBac.Location = new System.Drawing.Point(22, 84);
            this.rbMIenBac.Name = "rbMIenBac";
            this.rbMIenBac.Size = new System.Drawing.Size(109, 24);
            this.rbMIenBac.TabIndex = 0;
            this.rbMIenBac.Text = "Miền Bắc";
            this.rbMIenBac.UseVisualStyleBackColor = true;
            this.rbMIenBac.CheckedChanged += new System.EventHandler(this.rbMIenBac_CheckedChanged);
            // 
            // rbMIenTrung
            // 
            this.rbMIenTrung.AccessibleName = "";
            this.rbMIenTrung.AutoSize = true;
            this.rbMIenTrung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMIenTrung.Location = new System.Drawing.Point(22, 125);
            this.rbMIenTrung.Name = "rbMIenTrung";
            this.rbMIenTrung.Size = new System.Drawing.Size(124, 24);
            this.rbMIenTrung.TabIndex = 0;
            this.rbMIenTrung.Text = "Miền Trung";
            this.rbMIenTrung.UseVisualStyleBackColor = true;
            this.rbMIenTrung.CheckedChanged += new System.EventHandler(this.rbMIenTrung_CheckedChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dtpNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Location = new System.Drawing.Point(22, 169);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(276, 26);
            this.dtpNgay.TabIndex = 1;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // tabKetQua
            // 
            this.tabKetQua.Controls.Add(this.tabPage1);
            this.tabKetQua.Controls.Add(this.tabPage2);
            this.tabKetQua.Location = new System.Drawing.Point(363, 73);
            this.tabKetQua.Name = "tabKetQua";
            this.tabKetQua.SelectedIndex = 0;
            this.tabKetQua.Size = new System.Drawing.Size(774, 378);
            this.tabKetQua.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.tabKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabKetQua.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMIenTrung;
        private System.Windows.Forms.RadioButton rbMIenBac;
        private System.Windows.Forms.RadioButton rbMIenNam;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TabControl tabKetQua;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

