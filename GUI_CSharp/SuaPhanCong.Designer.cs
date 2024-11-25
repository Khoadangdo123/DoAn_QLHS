namespace GUI_CSharp
{
    partial class SuaPhanCong
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
            this.cardPhancong = new MaterialSkin.Controls.MaterialCard();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhancongNamhoc = new MaterialSkin.Controls.MaterialComboBox();
            this.cbPhancongMalop = new MaterialSkin.Controls.MaterialComboBox();
            this.cbPhancongGV = new MaterialSkin.Controls.MaterialComboBox();
            this.cbPhancongMonhoc = new MaterialSkin.Controls.MaterialComboBox();
            this.txSttPhancong = new MaterialSkin.Controls.MaterialTextBox();
            this.cbNgayPhanCong = new MaterialSkin.Controls.MaterialComboBox();
            this.txSoTiet = new MaterialSkin.Controls.MaterialTextBox();
            this.cardPhancong.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPhancong
            // 
            this.cardPhancong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardPhancong.Controls.Add(this.txSoTiet);
            this.cardPhancong.Controls.Add(this.cbNgayPhanCong);
            this.cardPhancong.Controls.Add(this.btnSua);
            this.cardPhancong.Controls.Add(this.label1);
            this.cardPhancong.Controls.Add(this.cbPhancongNamhoc);
            this.cardPhancong.Controls.Add(this.cbPhancongMalop);
            this.cardPhancong.Controls.Add(this.cbPhancongGV);
            this.cardPhancong.Controls.Add(this.cbPhancongMonhoc);
            this.cardPhancong.Controls.Add(this.txSttPhancong);
            this.cardPhancong.Depth = 0;
            this.cardPhancong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardPhancong.Location = new System.Drawing.Point(26, 120);
            this.cardPhancong.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.cardPhancong.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardPhancong.Name = "cardPhancong";
            this.cardPhancong.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.cardPhancong.Size = new System.Drawing.Size(948, 1066);
            this.cardPhancong.TabIndex = 17;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::GUI_CSharp.Properties.Resources.save;
            this.btnSua.Location = new System.Drawing.Point(240, 915);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(418, 65);
            this.btnSua.TabIndex = 17;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "THÔNG TIN PHÂN CÔNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPhancongNamhoc
            // 
            this.cbPhancongNamhoc.AutoResize = false;
            this.cbPhancongNamhoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongNamhoc.Depth = 0;
            this.cbPhancongNamhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongNamhoc.DropDownHeight = 174;
            this.cbPhancongNamhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongNamhoc.DropDownWidth = 121;
            this.cbPhancongNamhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongNamhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongNamhoc.FormattingEnabled = true;
            this.cbPhancongNamhoc.Hint = "Năm học";
            this.cbPhancongNamhoc.IntegralHeight = false;
            this.cbPhancongNamhoc.ItemHeight = 43;
            this.cbPhancongNamhoc.Location = new System.Drawing.Point(118, 317);
            this.cbPhancongNamhoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPhancongNamhoc.MaxDropDownItems = 4;
            this.cbPhancongNamhoc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongNamhoc.Name = "cbPhancongNamhoc";
            this.cbPhancongNamhoc.Size = new System.Drawing.Size(688, 49);
            this.cbPhancongNamhoc.StartIndex = 0;
            this.cbPhancongNamhoc.TabIndex = 12;
            // 
            // cbPhancongMalop
            // 
            this.cbPhancongMalop.AutoResize = false;
            this.cbPhancongMalop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongMalop.Depth = 0;
            this.cbPhancongMalop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongMalop.DropDownHeight = 174;
            this.cbPhancongMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongMalop.DropDownWidth = 121;
            this.cbPhancongMalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongMalop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongMalop.FormattingEnabled = true;
            this.cbPhancongMalop.Hint = "Mã lớp";
            this.cbPhancongMalop.IntegralHeight = false;
            this.cbPhancongMalop.ItemHeight = 43;
            this.cbPhancongMalop.Location = new System.Drawing.Point(118, 442);
            this.cbPhancongMalop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPhancongMalop.MaxDropDownItems = 4;
            this.cbPhancongMalop.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongMalop.Name = "cbPhancongMalop";
            this.cbPhancongMalop.Size = new System.Drawing.Size(688, 49);
            this.cbPhancongMalop.StartIndex = 0;
            this.cbPhancongMalop.TabIndex = 13;
            this.cbPhancongMalop.SelectedIndexChanged += new System.EventHandler(this.cbPhancongMalop_SelectedIndexChanged);
            // 
            // cbPhancongGV
            // 
            this.cbPhancongGV.AutoResize = false;
            this.cbPhancongGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongGV.Depth = 0;
            this.cbPhancongGV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongGV.DropDownHeight = 174;
            this.cbPhancongGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongGV.DropDownWidth = 121;
            this.cbPhancongGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongGV.FormattingEnabled = true;
            this.cbPhancongGV.Hint = "Giáo viên dạy";
            this.cbPhancongGV.IntegralHeight = false;
            this.cbPhancongGV.ItemHeight = 43;
            this.cbPhancongGV.Location = new System.Drawing.Point(118, 631);
            this.cbPhancongGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPhancongGV.MaxDropDownItems = 4;
            this.cbPhancongGV.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongGV.Name = "cbPhancongGV";
            this.cbPhancongGV.Size = new System.Drawing.Size(688, 49);
            this.cbPhancongGV.StartIndex = 0;
            this.cbPhancongGV.TabIndex = 13;
            // 
            // cbPhancongMonhoc
            // 
            this.cbPhancongMonhoc.AutoResize = false;
            this.cbPhancongMonhoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongMonhoc.Depth = 0;
            this.cbPhancongMonhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongMonhoc.DropDownHeight = 174;
            this.cbPhancongMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongMonhoc.DropDownWidth = 121;
            this.cbPhancongMonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongMonhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongMonhoc.FormattingEnabled = true;
            this.cbPhancongMonhoc.Hint = "Môn học";
            this.cbPhancongMonhoc.IntegralHeight = false;
            this.cbPhancongMonhoc.ItemHeight = 43;
            this.cbPhancongMonhoc.Location = new System.Drawing.Point(118, 546);
            this.cbPhancongMonhoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPhancongMonhoc.MaxDropDownItems = 4;
            this.cbPhancongMonhoc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongMonhoc.Name = "cbPhancongMonhoc";
            this.cbPhancongMonhoc.Size = new System.Drawing.Size(688, 49);
            this.cbPhancongMonhoc.StartIndex = 0;
            this.cbPhancongMonhoc.TabIndex = 13;
            // 
            // txSttPhancong
            // 
            this.txSttPhancong.AnimateReadOnly = false;
            this.txSttPhancong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSttPhancong.Depth = 0;
            this.txSttPhancong.Enabled = false;
            this.txSttPhancong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSttPhancong.Hint = "Số thứ tự";
            this.txSttPhancong.LeadingIcon = null;
            this.txSttPhancong.Location = new System.Drawing.Point(118, 192);
            this.txSttPhancong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txSttPhancong.MaxLength = 50;
            this.txSttPhancong.MouseState = MaterialSkin.MouseState.OUT;
            this.txSttPhancong.Multiline = false;
            this.txSttPhancong.Name = "txSttPhancong";
            this.txSttPhancong.Size = new System.Drawing.Size(690, 50);
            this.txSttPhancong.TabIndex = 7;
            this.txSttPhancong.Text = "";
            this.txSttPhancong.TrailingIcon = null;
            // 
            // cbNgayPhanCong
            // 
            this.cbNgayPhanCong.AutoResize = false;
            this.cbNgayPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNgayPhanCong.Depth = 0;
            this.cbNgayPhanCong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNgayPhanCong.DropDownHeight = 432;
            this.cbNgayPhanCong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgayPhanCong.DropDownWidth = 121;
            this.cbNgayPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNgayPhanCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNgayPhanCong.FormattingEnabled = true;
            this.cbNgayPhanCong.Hint = "Ngày Đăng Ký";
            this.cbNgayPhanCong.IntegralHeight = false;
            this.cbNgayPhanCong.ItemHeight = 43;
            this.cbNgayPhanCong.Items.AddRange(new object[] {
            "Chủ nhật",
            "Thứ 2",
            "Thứ 3",
            "Thứ 4 ",
            "Thứ 5 ",
            "Thứ 6 ",
            "Thứ 7"});
            this.cbNgayPhanCong.Location = new System.Drawing.Point(118, 800);
            this.cbNgayPhanCong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNgayPhanCong.MaxDropDownItems = 10;
            this.cbNgayPhanCong.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNgayPhanCong.Name = "cbNgayPhanCong";
            this.cbNgayPhanCong.Size = new System.Drawing.Size(688, 49);
            this.cbNgayPhanCong.StartIndex = 0;
            this.cbNgayPhanCong.TabIndex = 20;
            // 
            // txSoTiet
            // 
            this.txSoTiet.AnimateReadOnly = false;
            this.txSoTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSoTiet.Depth = 0;
            this.txSoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSoTiet.Hint = "Số Tiết";
            this.txSoTiet.LeadingIcon = null;
            this.txSoTiet.Location = new System.Drawing.Point(118, 713);
            this.txSoTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txSoTiet.MaxLength = 50;
            this.txSoTiet.MouseState = MaterialSkin.MouseState.OUT;
            this.txSoTiet.Multiline = false;
            this.txSoTiet.Name = "txSoTiet";
            this.txSoTiet.Size = new System.Drawing.Size(690, 50);
            this.txSoTiet.TabIndex = 21;
            this.txSoTiet.Text = "";
            this.txSoTiet.TrailingIcon = null;
            // 
            // SuaPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1212);
            this.Controls.Add(this.cardPhancong);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaPhanCong";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaPhanCong";
            this.cardPhancong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardPhancong;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongNamhoc;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongMalop;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongGV;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongMonhoc;
        private MaterialSkin.Controls.MaterialTextBox txSttPhancong;
        private MaterialSkin.Controls.MaterialButton btnSua;
        public MaterialSkin.Controls.MaterialComboBox cbNgayPhanCong;
        private MaterialSkin.Controls.MaterialTextBox txSoTiet;
    }
}