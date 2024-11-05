namespace GUI_CSharp
{
    partial class ThemLop
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
            this.txGiaoVien = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNamhoc = new MaterialSkin.Controls.MaterialComboBox();
            this.cbKhoilop = new MaterialSkin.Controls.MaterialComboBox();
            this.txSiso = new MaterialSkin.Controls.MaterialTextBox();
            this.txTenlop = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.txGiaoVien);
            this.materialCard.Controls.Add(this.materialComboBox1);
            this.materialCard.Controls.Add(this.btnThem);
            this.materialCard.Controls.Add(this.label1);
            this.materialCard.Controls.Add(this.cbNamhoc);
            this.materialCard.Controls.Add(this.cbKhoilop);
            this.materialCard.Controls.Add(this.txSiso);
            this.materialCard.Controls.Add(this.txTenlop);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 78);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(632, 693);
            this.materialCard.TabIndex = 4;
            // 
            // txGiaoVien
            // 
            this.txGiaoVien.AutoResize = false;
            this.txGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txGiaoVien.Depth = 0;
            this.txGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txGiaoVien.DropDownHeight = 174;
            this.txGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txGiaoVien.DropDownWidth = 121;
            this.txGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txGiaoVien.FormattingEnabled = true;
            this.txGiaoVien.Hint = "Giáo Viên";
            this.txGiaoVien.IntegralHeight = false;
            this.txGiaoVien.ItemHeight = 43;
            this.txGiaoVien.Location = new System.Drawing.Point(81, 421);
            this.txGiaoVien.MaxDropDownItems = 4;
            this.txGiaoVien.MouseState = MaterialSkin.MouseState.OUT;
            this.txGiaoVien.Name = "txGiaoVien";
            this.txGiaoVien.Size = new System.Drawing.Size(460, 49);
            this.txGiaoVien.StartIndex = 0;
            this.txGiaoVien.TabIndex = 19;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Học kì";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(81, 501);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(460, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(158, 594);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(279, 42);
            this.btnThem.TabIndex = 16;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "THÊM LỚP HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbNamhoc.Location = new System.Drawing.Point(81, 338);
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
            this.cbKhoilop.Hint = "Khối lớp:";
            this.cbKhoilop.IntegralHeight = false;
            this.cbKhoilop.ItemHeight = 43;
            this.cbKhoilop.Location = new System.Drawing.Point(81, 166);
            this.cbKhoilop.MaxDropDownItems = 4;
            this.cbKhoilop.MouseState = MaterialSkin.MouseState.OUT;
            this.cbKhoilop.Name = "cbKhoilop";
            this.cbKhoilop.Size = new System.Drawing.Size(460, 49);
            this.cbKhoilop.StartIndex = 0;
            this.cbKhoilop.TabIndex = 3;
            this.cbKhoilop.SelectedIndexChanged += new System.EventHandler(this.cbKhoilop_SelectedIndexChanged);
            // 
            // txSiso
            // 
            this.txSiso.AnimateReadOnly = false;
            this.txSiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSiso.Depth = 0;
            this.txSiso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSiso.Hint = "Sĩ số";
            this.txSiso.LeadingIcon = null;
            this.txSiso.Location = new System.Drawing.Point(81, 252);
            this.txSiso.MaxLength = 50;
            this.txSiso.MouseState = MaterialSkin.MouseState.OUT;
            this.txSiso.Multiline = false;
            this.txSiso.Name = "txSiso";
            this.txSiso.Size = new System.Drawing.Size(460, 50);
            this.txSiso.TabIndex = 3;
            this.txSiso.Text = "";
            this.txSiso.TrailingIcon = null;
            // 
            // txTenlop
            // 
            this.txTenlop.AnimateReadOnly = false;
            this.txTenlop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenlop.Depth = 0;
            this.txTenlop.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenlop.Hint = "Tên lớp ";
            this.txTenlop.LeadingIcon = null;
            this.txTenlop.Location = new System.Drawing.Point(81, 80);
            this.txTenlop.MaxLength = 50;
            this.txTenlop.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenlop.Multiline = false;
            this.txTenlop.Name = "txTenlop";
            this.txTenlop.Size = new System.Drawing.Size(460, 50);
            this.txTenlop.TabIndex = 2;
            this.txTenlop.Text = "";
            this.txTenlop.TrailingIcon = null;
            // 
            // ThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 788);
            this.Controls.Add(this.materialCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemLop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemLopHoc";
            this.materialCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialCard materialCard;
        public MaterialSkin.Controls.MaterialComboBox cbNamhoc;
        public MaterialSkin.Controls.MaterialComboBox cbKhoilop;
        public MaterialSkin.Controls.MaterialTextBox txTenlop;
        public System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialButton btnThem;
        public MaterialSkin.Controls.MaterialTextBox txSiso;
        public MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        public MaterialSkin.Controls.MaterialComboBox txGiaoVien;
    }
}