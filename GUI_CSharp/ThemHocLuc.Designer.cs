namespace GUI_CSharp
{
    partial class ThemHocLuc
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            this.txMaHL = new MaterialSkin.Controls.MaterialTextBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.diemKhongche = new MaterialSkin.Controls.MaterialTextBox();
            this.diemCanduoi = new MaterialSkin.Controls.MaterialTextBox();
            this.diemCantren = new MaterialSkin.Controls.MaterialTextBox();
            this.txTenHL = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.txMaHL);
            this.materialCard1.Controls.Add(this.btnThem);
            this.materialCard1.Controls.Add(this.diemKhongche);
            this.materialCard1.Controls.Add(this.diemCanduoi);
            this.materialCard1.Controls.Add(this.diemCantren);
            this.materialCard1.Controls.Add(this.txTenHL);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(4, 68);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(500, 577);
            this.materialCard1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 43);
            this.label2.TabIndex = 36;
            this.label2.Text = "THÊM HỌC LỰC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txMaHL
            // 
            this.txMaHL.AnimateReadOnly = false;
            this.txMaHL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMaHL.Depth = 0;
            this.txMaHL.Enabled = false;
            this.txMaHL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMaHL.Hint = "Mã học lực";
            this.txMaHL.LeadingIcon = null;
            this.txMaHL.Location = new System.Drawing.Point(43, 107);
            this.txMaHL.MaxLength = 50;
            this.txMaHL.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaHL.Multiline = false;
            this.txMaHL.Name = "txMaHL";
            this.txMaHL.Size = new System.Drawing.Size(411, 50);
            this.txMaHL.TabIndex = 37;
            this.txMaHL.Text = "";
            this.txMaHL.TrailingIcon = null;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(105, 488);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(279, 42);
            this.btnThem.TabIndex = 38;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // diemKhongche
            // 
            this.diemKhongche.AnimateReadOnly = false;
            this.diemKhongche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diemKhongche.Depth = 0;
            this.diemKhongche.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diemKhongche.Hint = "Điểm khống chế";
            this.diemKhongche.LeadingIcon = null;
            this.diemKhongche.Location = new System.Drawing.Point(43, 411);
            this.diemKhongche.MaxLength = 50;
            this.diemKhongche.MouseState = MaterialSkin.MouseState.OUT;
            this.diemKhongche.Multiline = false;
            this.diemKhongche.Name = "diemKhongche";
            this.diemKhongche.Size = new System.Drawing.Size(411, 50);
            this.diemKhongche.TabIndex = 37;
            this.diemKhongche.Text = "";
            this.diemKhongche.TrailingIcon = null;
            // 
            // diemCanduoi
            // 
            this.diemCanduoi.AnimateReadOnly = false;
            this.diemCanduoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diemCanduoi.Depth = 0;
            this.diemCanduoi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diemCanduoi.Hint = "Điểm cận dưới";
            this.diemCanduoi.LeadingIcon = null;
            this.diemCanduoi.Location = new System.Drawing.Point(43, 335);
            this.diemCanduoi.MaxLength = 50;
            this.diemCanduoi.MouseState = MaterialSkin.MouseState.OUT;
            this.diemCanduoi.Multiline = false;
            this.diemCanduoi.Name = "diemCanduoi";
            this.diemCanduoi.Size = new System.Drawing.Size(411, 50);
            this.diemCanduoi.TabIndex = 37;
            this.diemCanduoi.Text = "";
            this.diemCanduoi.TrailingIcon = null;
            // 
            // diemCantren
            // 
            this.diemCantren.AnimateReadOnly = false;
            this.diemCantren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diemCantren.Depth = 0;
            this.diemCantren.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diemCantren.Hint = "Điểm cận trên";
            this.diemCantren.LeadingIcon = null;
            this.diemCantren.Location = new System.Drawing.Point(43, 259);
            this.diemCantren.MaxLength = 50;
            this.diemCantren.MouseState = MaterialSkin.MouseState.OUT;
            this.diemCantren.Multiline = false;
            this.diemCantren.Name = "diemCantren";
            this.diemCantren.Size = new System.Drawing.Size(411, 50);
            this.diemCantren.TabIndex = 37;
            this.diemCantren.Text = "";
            this.diemCantren.TrailingIcon = null;
            // 
            // txTenHL
            // 
            this.txTenHL.AnimateReadOnly = false;
            this.txTenHL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenHL.Depth = 0;
            this.txTenHL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenHL.Hint = "Học lực";
            this.txTenHL.LeadingIcon = null;
            this.txTenHL.Location = new System.Drawing.Point(43, 183);
            this.txTenHL.MaxLength = 50;
            this.txTenHL.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenHL.Multiline = false;
            this.txTenHL.Name = "txTenHL";
            this.txTenHL.Size = new System.Drawing.Size(411, 50);
            this.txTenHL.TabIndex = 1;
            this.txTenHL.Text = "";
            this.txTenHL.TrailingIcon = null;
            // 
            // ThemHocLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 650);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemHocLuc";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHocLuc";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txMaHL;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialTextBox diemKhongche;
        private MaterialSkin.Controls.MaterialTextBox diemCanduoi;
        private MaterialSkin.Controls.MaterialTextBox diemCantren;
        private MaterialSkin.Controls.MaterialTextBox txTenHL;
    }
}