namespace CSharp_TinhChuViDienTich
{
    partial class HinhChuNhat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDai = new TextBox();
            txtRong = new TextBox();
            label4 = new Label();
            lblKQ = new Label();
            btnTinh = new Button();
            btnThoat = new Button();
            btnDienTich = new Button();
            btnChuVi = new Button();
            Tinhnew = new Button();
            CMM = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            trackBar1 = new TrackBar();
            CMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(789, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH CHU VI VÀ DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20F);
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 1;
            label2.Text = "Chiều dài";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F);
            label3.Location = new Point(22, 142);
            label3.Name = "label3";
            label3.Size = new Size(144, 33);
            label3.TabIndex = 2;
            label3.Text = "Chiều rộng";
            // 
            // txtDai
            // 
            txtDai.Location = new Point(186, 79);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(219, 40);
            txtDai.TabIndex = 3;
            txtDai.Text = "5";
            // 
            // txtRong
            // 
            txtRong.Location = new Point(186, 139);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(219, 40);
            txtRong.TabIndex = 3;
            txtRong.Text = "6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F);
            label4.Location = new Point(22, 202);
            label4.Name = "label4";
            label4.Size = new Size(106, 33);
            label4.TabIndex = 2;
            label4.Text = "Kết quả";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Tahoma", 20F);
            lblKQ.Location = new Point(186, 202);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 33);
            lblKQ.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(22, 267);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(144, 56);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(625, 348);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(168, 56);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(22, 344);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(168, 56);
            btnDienTich.TabIndex = 6;
            btnDienTich.Text = "DIỆN TÍCH";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(237, 344);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(168, 56);
            btnChuVi.TabIndex = 6;
            btnChuVi.Text = "CHU VI";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // Tinhnew
            // 
            Tinhnew.Location = new Point(445, 344);
            Tinhnew.Name = "Tinhnew";
            Tinhnew.Size = new Size(144, 56);
            Tinhnew.TabIndex = 5;
            Tinhnew.Text = "TÍNH new";
            Tinhnew.UseVisualStyleBackColor = true;
            Tinhnew.Click += btnTinh_Click;
            // 
            // CMM
            // 
            CMM.Controls.Add(radioButton2);
            CMM.Controls.Add(radioButton1);
            CMM.Location = new Point(531, 160);
            CMM.Name = "CMM";
            CMM.Size = new Size(253, 142);
            CMM.TabIndex = 7;
            CMM.TabStop = false;
            CMM.Text = "Chọn Chức Năng";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 37);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Chu vi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(136, 37);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Diện tích";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(431, 80);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 40);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(539, 82);
            trackBar1.Maximum = 50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 412);
            Controls.Add(trackBar1);
            Controls.Add(numericUpDown1);
            Controls.Add(CMM);
            Controls.Add(btnChuVi);
            Controls.Add(btnDienTich);
            Controls.Add(btnThoat);
            Controls.Add(Tinhnew);
            Controls.Add(btnTinh);
            Controls.Add(lblKQ);
            Controls.Add(txtRong);
            Controls.Add(txtDai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "HinhChuNhat";
            Text = "HÌNH CHỮ NHẬT";
            Load += HinhChuNhat_Load;
            CMM.ResumeLayout(false);
            CMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDai;
        private TextBox txtRong;
        private Label label4;
        private Label lblKQ;
        private Button btnTinh;
        private Button btnThoat;
        private Button btnDienTich;
        private Button btnChuVi;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox CMM;
        private Button Tinhnew;
        private NumericUpDown numericUpDown1;
        private TrackBar trackBar1;
    }
}
