namespace GUI_CSharp
{
    partial class ThemGV
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
            this.cardGV = new MaterialSkin.Controls.MaterialCard();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonGiangday = new MaterialSkin.Controls.MaterialComboBox();
            this.txSdt = new MaterialSkin.Controls.MaterialTextBox();
            this.txDiachi = new MaterialSkin.Controls.MaterialTextBox();
            this.txTenGV = new MaterialSkin.Controls.MaterialTextBox();
            this.txMaGV = new MaterialSkin.Controls.MaterialTextBox();
            this.cardGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardGV
            // 
            this.cardGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGV.Controls.Add(this.btnThem);
            this.cardGV.Controls.Add(this.label1);
            this.cardGV.Controls.Add(this.cbMonGiangday);
            this.cardGV.Controls.Add(this.txSdt);
            this.cardGV.Controls.Add(this.txDiachi);
            this.cardGV.Controls.Add(this.txTenGV);
            this.cardGV.Controls.Add(this.txMaGV);
            this.cardGV.Depth = 0;
            this.cardGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGV.Location = new System.Drawing.Point(17, 78);
            this.cardGV.Margin = new System.Windows.Forms.Padding(14);
            this.cardGV.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGV.Name = "cardGV";
            this.cardGV.Padding = new System.Windows.Forms.Padding(14);
            this.cardGV.Size = new System.Drawing.Size(632, 693);
            this.cardGV.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(164, 552);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(279, 42);
            this.btnThem.TabIndex = 17;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "THÊM GIÁO VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMonGiangday
            // 
            this.cbMonGiangday.AutoResize = false;
            this.cbMonGiangday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMonGiangday.Depth = 0;
            this.cbMonGiangday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMonGiangday.DropDownHeight = 174;
            this.cbMonGiangday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonGiangday.DropDownWidth = 121;
            this.cbMonGiangday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMonGiangday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMonGiangday.FormattingEnabled = true;
            this.cbMonGiangday.Hint = "Môn giảng dạy";
            this.cbMonGiangday.IntegralHeight = false;
            this.cbMonGiangday.ItemHeight = 43;
            this.cbMonGiangday.Location = new System.Drawing.Point(80, 375);
            this.cbMonGiangday.MaxDropDownItems = 4;
            this.cbMonGiangday.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMonGiangday.Name = "cbMonGiangday";
            this.cbMonGiangday.Size = new System.Drawing.Size(460, 49);
            this.cbMonGiangday.StartIndex = 0;
            this.cbMonGiangday.TabIndex = 13;
            // 
            // txSdt
            // 
            this.txSdt.AnimateReadOnly = false;
            this.txSdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSdt.Depth = 0;
            this.txSdt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSdt.Hint = "Số điện thoại";
            this.txSdt.LeadingIcon = null;
            this.txSdt.Location = new System.Drawing.Point(80, 460);
            this.txSdt.MaxLength = 50;
            this.txSdt.MouseState = MaterialSkin.MouseState.OUT;
            this.txSdt.Multiline = false;
            this.txSdt.Name = "txSdt";
            this.txSdt.Size = new System.Drawing.Size(460, 50);
            this.txSdt.TabIndex = 6;
            this.txSdt.Text = "";
            this.txSdt.TrailingIcon = null;
            // 
            // txDiachi
            // 
            this.txDiachi.AnimateReadOnly = false;
            this.txDiachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDiachi.Depth = 0;
            this.txDiachi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiachi.Hint = "Địa chỉ ";
            this.txDiachi.LeadingIcon = null;
            this.txDiachi.Location = new System.Drawing.Point(80, 289);
            this.txDiachi.MaxLength = 60;
            this.txDiachi.MouseState = MaterialSkin.MouseState.OUT;
            this.txDiachi.Multiline = false;
            this.txDiachi.Name = "txDiachi";
            this.txDiachi.Size = new System.Drawing.Size(460, 50);
            this.txDiachi.TabIndex = 6;
            this.txDiachi.Text = "";
            this.txDiachi.TrailingIcon = null;
            // 
            // txTenGV
            // 
            this.txTenGV.AnimateReadOnly = false;
            this.txTenGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenGV.Depth = 0;
            this.txTenGV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenGV.Hint = "Tên giáo viên";
            this.txTenGV.LeadingIcon = null;
            this.txTenGV.Location = new System.Drawing.Point(80, 203);
            this.txTenGV.MaxLength = 50;
            this.txTenGV.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenGV.Multiline = false;
            this.txTenGV.Name = "txTenGV";
            this.txTenGV.Size = new System.Drawing.Size(460, 50);
            this.txTenGV.TabIndex = 5;
            this.txTenGV.Text = "";
            this.txTenGV.TrailingIcon = null;
            // 
            // txMaGV
            // 
            this.txMaGV.AnimateReadOnly = false;
            this.txMaGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMaGV.Depth = 0;
            this.txMaGV.Enabled = false;
            this.txMaGV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMaGV.Hint = "Mã giáo viên";
            this.txMaGV.LeadingIcon = null;
            this.txMaGV.Location = new System.Drawing.Point(80, 117);
            this.txMaGV.MaxLength = 50;
            this.txMaGV.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaGV.Multiline = false;
            this.txMaGV.Name = "txMaGV";
            this.txMaGV.Size = new System.Drawing.Size(460, 50);
            this.txMaGV.TabIndex = 7;
            this.txMaGV.Text = "";
            this.txMaGV.TrailingIcon = null;
            // 
            // ThemGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 788);
            this.Controls.Add(this.cardGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemGV";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemGiaoVien";
            this.cardGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardGV;
        private MaterialSkin.Controls.MaterialComboBox cbMonGiangday;
        private MaterialSkin.Controls.MaterialTextBox txSdt;
        private MaterialSkin.Controls.MaterialTextBox txDiachi;
        private MaterialSkin.Controls.MaterialTextBox txTenGV;
        private MaterialSkin.Controls.MaterialTextBox txMaGV;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnThem;
    }
}