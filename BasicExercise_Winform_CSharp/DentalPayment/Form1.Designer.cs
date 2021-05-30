
namespace DentalPayment
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
            this.buttonTinhTien = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.lablename = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxCV = new System.Windows.Forms.CheckBox();
            this.checkBoxTT = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNR = new System.Windows.Forms.NumericUpDown();
            this.numericTR = new System.Windows.Forms.NumericUpDown();
            this.labelCV = new System.Windows.Forms.Label();
            this.labelTT = new System.Windows.Forms.Label();
            this.labelNR = new System.Windows.Forms.Label();
            this.labelTR = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTinhTien
            // 
            this.buttonTinhTien.Location = new System.Drawing.Point(13, 321);
            this.buttonTinhTien.Name = "buttonTinhTien";
            this.buttonTinhTien.Size = new System.Drawing.Size(75, 23);
            this.buttonTinhTien.TabIndex = 0;
            this.buttonTinhTien.Text = "Tinh tien";
            this.buttonTinhTien.UseVisualStyleBackColor = true;
            this.buttonTinhTien.Click += new System.EventHandler(this.buttonTinhTien_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(94, 321);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 1;
            this.buttonXoa.Text = "Xoa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(175, 321);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoat";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // lablename
            // 
            this.lablename.AutoSize = true;
            this.lablename.Location = new System.Drawing.Point(66, 59);
            this.lablename.Name = "lablename";
            this.lablename.Size = new System.Drawing.Size(35, 13);
            this.lablename.TabIndex = 3;
            this.lablename.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(114, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // checkBoxCV
            // 
            this.checkBoxCV.AutoSize = true;
            this.checkBoxCV.Location = new System.Drawing.Point(13, 93);
            this.checkBoxCV.Name = "checkBoxCV";
            this.checkBoxCV.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCV.TabIndex = 5;
            this.checkBoxCV.Text = "Cao voi";
            this.checkBoxCV.UseVisualStyleBackColor = true;
            // 
            // checkBoxTT
            // 
            this.checkBoxTT.AutoSize = true;
            this.checkBoxTT.Location = new System.Drawing.Point(12, 116);
            this.checkBoxTT.Name = "checkBoxTT";
            this.checkBoxTT.Size = new System.Drawing.Size(71, 17);
            this.checkBoxTT.TabIndex = 6;
            this.checkBoxTT.Text = "Tay trang";
            this.checkBoxTT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nho rang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tram rang";
            // 
            // numericNR
            // 
            this.numericNR.Location = new System.Drawing.Point(70, 148);
            this.numericNR.Name = "numericNR";
            this.numericNR.Size = new System.Drawing.Size(33, 20);
            this.numericNR.TabIndex = 9;
            // 
            // numericTR
            // 
            this.numericTR.Location = new System.Drawing.Point(69, 176);
            this.numericTR.Name = "numericTR";
            this.numericTR.Size = new System.Drawing.Size(34, 20);
            this.numericTR.TabIndex = 10;
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Location = new System.Drawing.Point(175, 93);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(43, 13);
            this.labelCV.TabIndex = 11;
            this.labelCV.Text = "100000";
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.Location = new System.Drawing.Point(175, 117);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(49, 13);
            this.labelTT.TabIndex = 12;
            this.labelTT.Text = "1500000";
            // 
            // labelNR
            // 
            this.labelNR.AutoSize = true;
            this.labelNR.Location = new System.Drawing.Point(175, 155);
            this.labelNR.Name = "labelNR";
            this.labelNR.Size = new System.Drawing.Size(43, 13);
            this.labelNR.TabIndex = 13;
            this.labelNR.Text = "150000";
            // 
            // labelTR
            // 
            this.labelTR.AutoSize = true;
            this.labelTR.Location = new System.Drawing.Point(175, 183);
            this.labelTR.Name = "labelTR";
            this.labelTR.Size = new System.Drawing.Size(43, 13);
            this.labelTR.TabIndex = 14;
            this.labelTR.Text = "200000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tong tien";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(110, 250);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dental Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTR);
            this.Controls.Add(this.labelNR);
            this.Controls.Add(this.labelTT);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.numericTR);
            this.Controls.Add(this.numericNR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxTT);
            this.Controls.Add(this.checkBoxCV);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lablename);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTinhTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTinhTien;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label lablename;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxCV;
        private System.Windows.Forms.CheckBox checkBoxTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericNR;
        private System.Windows.Forms.NumericUpDown numericTR;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.Label labelNR;
        private System.Windows.Forms.Label labelTR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label1;
    }
}

