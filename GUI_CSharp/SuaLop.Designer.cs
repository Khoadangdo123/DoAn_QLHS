namespace GUI_CSharp
{
    partial class SuaLop
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
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.txHocKy = new MaterialSkin.Controls.MaterialComboBox();
            this.txSiso = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGiaovien = new MaterialSkin.Controls.MaterialComboBox();
            this.cbNamhoc = new MaterialSkin.Controls.MaterialComboBox();
            this.cbKhoilop = new MaterialSkin.Controls.MaterialComboBox();
            this.txTenlop = new MaterialSkin.Controls.MaterialTextBox();
            this.txMalop = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.txHocKy);
            this.materialCard.Controls.Add(this.txSiso);
            this.materialCard.Controls.Add(this.btnSua);
            this.materialCard.Controls.Add(this.label1);
            this.materialCard.Controls.Add(this.cbGiaovien);
            this.materialCard.Controls.Add(this.cbNamhoc);
            this.materialCard.Controls.Add(this.cbKhoilop);
            this.materialCard.Controls.Add(this.txTenlop);
            this.materialCard.Controls.Add(this.txMalop);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 78);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(632, 693);
            this.materialCard.TabIndex = 5;
            // 
            // txHocKy
            // 
            this.txHocKy.AutoResize = false;
            this.txHocKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txHocKy.Depth = 0;
            this.txHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txHocKy.DropDownHeight = 174;
            this.txHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txHocKy.DropDownWidth = 121;
            this.txHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txHocKy.FormattingEnabled = true;
            this.txHocKy.Hint = "Học Kỳ";
            this.txHocKy.IntegralHeight = false;
            this.txHocKy.ItemHeight = 43;
            this.txHocKy.Location = new System.Drawing.Point(73, 571);
            this.txHocKy.MaxDropDownItems = 4;
            this.txHocKy.MouseState = MaterialSkin.MouseState.OUT;
            this.txHocKy.Name = "txHocKy";
            this.txHocKy.Size = new System.Drawing.Size(460, 49);
            this.txHocKy.StartIndex = 0;
            this.txHocKy.TabIndex = 18;
            // 
            // txSiso
            // 
            this.txSiso.AnimateReadOnly = false;
            this.txSiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSiso.Depth = 0;
            this.txSiso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSiso.Hint = "Sĩ số";
            this.txSiso.LeadingIcon = null;
            this.txSiso.Location = new System.Drawing.Point(75, 336);
            this.txSiso.MaxLength = 50;
            this.txSiso.MouseState = MaterialSkin.MouseState.OUT;
            this.txSiso.Multiline = false;
            this.txSiso.Name = "txSiso";
            this.txSiso.Size = new System.Drawing.Size(460, 50);
            this.txSiso.TabIndex = 17;
            this.txSiso.Text = "";
            this.txSiso.TrailingIcon = null;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::GUI_CSharp.Properties.Resources.save;
            this.btnSua.Location = new System.Drawing.Point(168, 599);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(279, 42);
            this.btnSua.TabIndex = 16;
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
            this.label1.Location = new System.Drawing.Point(189, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "THÔNG TIN LỚP HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGiaovien
            // 
            this.cbGiaovien.AutoResize = false;
            this.cbGiaovien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbGiaovien.Depth = 0;
            this.cbGiaovien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbGiaovien.DropDownHeight = 174;
            this.cbGiaovien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiaovien.DropDownWidth = 121;
            this.cbGiaovien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbGiaovien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbGiaovien.FormattingEnabled = true;
            this.cbGiaovien.Hint = "Giáo viên ";
            this.cbGiaovien.IntegralHeight = false;
            this.cbGiaovien.ItemHeight = 43;
            this.cbGiaovien.Location = new System.Drawing.Point(75, 507);
            this.cbGiaovien.MaxDropDownItems = 4;
            this.cbGiaovien.MouseState = MaterialSkin.MouseState.OUT;
            this.cbGiaovien.Name = "cbGiaovien";
            this.cbGiaovien.Size = new System.Drawing.Size(460, 49);
            this.cbGiaovien.StartIndex = 0;
            this.cbGiaovien.TabIndex = 6;
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.AutoResize = false;
            this.cbNamhoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNamhoc.Depth = 0;
            this.cbNamhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNamhoc.DropDownHeight = 174;
            this.cbNamhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamhoc.DropDownWidth = 121;
            this.cbNamhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNamhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Hint = "Năm học";
            this.cbNamhoc.IntegralHeight = false;
            this.cbNamhoc.ItemHeight = 43;
            this.cbNamhoc.Location = new System.Drawing.Point(75, 422);
            this.cbNamhoc.MaxDropDownItems = 4;
            this.cbNamhoc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(460, 49);
            this.cbNamhoc.StartIndex = 0;
            this.cbNamhoc.TabIndex = 5;
            // 
            // cbKhoilop
            // 
            this.cbKhoilop.AutoResize = false;
            this.cbKhoilop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbKhoilop.Depth = 0;
            this.cbKhoilop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbKhoilop.DropDownHeight = 174;
            this.cbKhoilop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoilop.DropDownWidth = 121;
            this.cbKhoilop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbKhoilop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbKhoilop.FormattingEnabled = true;
            this.cbKhoilop.Hint = "Khối lớp";
            this.cbKhoilop.IntegralHeight = false;
            this.cbKhoilop.ItemHeight = 43;
            this.cbKhoilop.Location = new System.Drawing.Point(75, 250);
            this.cbKhoilop.MaxDropDownItems = 4;
            this.cbKhoilop.MouseState = MaterialSkin.MouseState.OUT;
            this.cbKhoilop.Name = "cbKhoilop";
            this.cbKhoilop.Size = new System.Drawing.Size(460, 49);
            this.cbKhoilop.StartIndex = 0;
            this.cbKhoilop.TabIndex = 3;
            // 
            // txTenlop
            // 
            this.txTenlop.AnimateReadOnly = false;
            this.txTenlop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenlop.Depth = 0;
            this.txTenlop.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenlop.Hint = "Tên lớp ";
            this.txTenlop.LeadingIcon = null;
            this.txTenlop.Location = new System.Drawing.Point(75, 164);
            this.txTenlop.MaxLength = 50;
            this.txTenlop.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenlop.Multiline = false;
            this.txTenlop.Name = "txTenlop";
            this.txTenlop.Size = new System.Drawing.Size(460, 50);
            this.txTenlop.TabIndex = 2;
            this.txTenlop.Text = "";
            this.txTenlop.TrailingIcon = null;
            // 
            // txMalop
            // 
            this.txMalop.AnimateReadOnly = false;
            this.txMalop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMalop.Depth = 0;
            this.txMalop.Enabled = false;
            this.txMalop.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMalop.Hint = "Mã lớp";
            this.txMalop.LeadingIcon = null;
            this.txMalop.Location = new System.Drawing.Point(75, 86);
            this.txMalop.MaxLength = 50;
            this.txMalop.MouseState = MaterialSkin.MouseState.OUT;
            this.txMalop.Multiline = false;
            this.txMalop.Name = "txMalop";
            this.txMalop.Size = new System.Drawing.Size(460, 50);
            this.txMalop.TabIndex = 1;
            this.txMalop.Text = "";
            this.txMalop.TrailingIcon = null;
            // 
            // SuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 788);
            this.Controls.Add(this.materialCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaLop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatThongTinLopHoc";
            this.materialCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cbGiaovien;
        private MaterialSkin.Controls.MaterialComboBox cbNamhoc;
        private MaterialSkin.Controls.MaterialComboBox cbKhoilop;
        private MaterialSkin.Controls.MaterialTextBox txTenlop;
        private MaterialSkin.Controls.MaterialTextBox txMalop;
        private MaterialSkin.Controls.MaterialTextBox txSiso;
        private MaterialSkin.Controls.MaterialComboBox txHocKy;
    }
}