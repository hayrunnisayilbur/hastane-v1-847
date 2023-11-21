namespace hastane_v1_847
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.rbVar = new System.Windows.Forms.RadioButton();
            this.rbYok = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbKan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kronik Hastalık:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = " ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(110, 48);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(110, 83);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(133, 123);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 9;
            this.DateTimePicker1.Value = new System.DateTime(2023, 11, 21, 0, 0, 0, 0);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(110, 158);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcNo.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(110, 192);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 11;
            // 
            // rbVar
            // 
            this.rbVar.AutoSize = true;
            this.rbVar.Location = new System.Drawing.Point(110, 230);
            this.rbVar.Name = "rbVar";
            this.rbVar.Size = new System.Drawing.Size(113, 17);
            this.rbVar.TabIndex = 13;
            this.rbVar.TabStop = true;
            this.rbVar.Text = "kronik hastalığı var";
            this.rbVar.UseVisualStyleBackColor = true;
            // 
            // rbYok
            // 
            this.rbYok.AutoSize = true;
            this.rbYok.Location = new System.Drawing.Point(110, 253);
            this.rbYok.Name = "rbYok";
            this.rbYok.Size = new System.Drawing.Size(115, 17);
            this.rbYok.TabIndex = 14;
            this.rbYok.TabStop = true;
            this.rbYok.Text = "kronik hastalığı yok";
            this.rbYok.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "TC No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kan Grubu:";
            // 
            // cmbKan
            // 
            this.cmbKan.FormattingEnabled = true;
            this.cmbKan.Items.AddRange(new object[] {
            "0+",
            "0-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cmbKan.Location = new System.Drawing.Point(111, 279);
            this.cmbKan.Name = "cmbKan";
            this.cmbKan.Size = new System.Drawing.Size(121, 21);
            this.cmbKan.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 477);
            this.Controls.Add(this.cmbKan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbYok);
            this.Controls.Add(this.rbVar);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.RadioButton rbVar;
        private System.Windows.Forms.RadioButton rbYok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbKan;
    }
}

