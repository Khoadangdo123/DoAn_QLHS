namespace GUI_CSharp
{
    partial class ThemHanhKiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.txMaHK = new MaterialSkin.Controls.MaterialTextBox();
            this.txTenHK = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.diemCanduoi = new MaterialSkin.Controls.MaterialTextBox();
            this.diemCantren = new MaterialSkin.Controls.MaterialTextBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
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
            this.label2.Text = "THÊM HẠNH KIỂM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txMaHK
            // 
            this.txMaHK.AnimateReadOnly = false;
            this.txMaHK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMaHK.Depth = 0;
            this.txMaHK.Enabled = false;
            this.txMaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMaHK.Hint = "Mã hạnh kiểm";
            this.txMaHK.LeadingIcon = null;
            this.txMaHK.Location = new System.Drawing.Point(40, 107);
            this.txMaHK.MaxLength = 50;
            this.txMaHK.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaHK.Multiline = false;
            this.txMaHK.Name = "txMaHK";
            this.txMaHK.Size = new System.Drawing.Size(411, 50);
            this.txMaHK.TabIndex = 37;
            this.txMaHK.Text = "";
            this.txMaHK.TrailingIcon = null;
            // 
            // txTenHK
            // 
            this.txTenHK.AnimateReadOnly = false;
            this.txTenHK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenHK.Depth = 0;
            this.txTenHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenHK.Hint = "Hạnh kiểm";
            this.txTenHK.LeadingIcon = null;
            this.txTenHK.Location = new System.Drawing.Point(40, 183);
            this.txTenHK.MaxLength = 50;
            this.txTenHK.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenHK.Multiline = false;
            this.txTenHK.Name = "txTenHK";
            this.txTenHK.Size = new System.Drawing.Size(411, 50);
            this.txTenHK.TabIndex = 1;
            this.txTenHK.Text = "";
            this.txTenHK.TrailingIcon = null;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.txMaHK);
            this.materialCard1.Controls.Add(this.btnThem);
            this.materialCard1.Controls.Add(this.diemCanduoi);
            this.materialCard1.Controls.Add(this.diemCantren);
            this.materialCard1.Controls.Add(this.txTenHK);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 66);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(480, 497);
            this.materialCard1.TabIndex = 38;
            // 
            // diemCanduoi
            // 
            this.diemCanduoi.AnimateReadOnly = false;
            this.diemCanduoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diemCanduoi.Depth = 0;
            this.diemCanduoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diemCanduoi.Hint = "ĐIểm cận dưới";
            this.diemCanduoi.LeadingIcon = null;
            this.diemCanduoi.Location = new System.Drawing.Point(40, 335);
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
            this.diemCantren.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diemCantren.Hint = "Điểm cận trên";
            this.diemCantren.LeadingIcon = null;
            this.diemCantren.Location = new System.Drawing.Point(40, 259);
            this.diemCantren.MaxLength = 50;
            this.diemCantren.MouseState = MaterialSkin.MouseState.OUT;
            this.diemCantren.Multiline = false;
            this.diemCantren.Name = "diemCantren";
            this.diemCantren.Size = new System.Drawing.Size(411, 50);
            this.diemCantren.TabIndex = 37;
            this.diemCantren.Text = "";
            this.diemCantren.TrailingIcon = null;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(95, 418);
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
            // ThemHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 565);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemHanhKiem";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHanhKiem";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txMaHK;
        private MaterialSkin.Controls.MaterialTextBox txTenHK;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox diemCantren;
        private MaterialSkin.Controls.MaterialTextBox diemCanduoi;
        private MaterialSkin.Controls.MaterialButton btnThem;
    }
}