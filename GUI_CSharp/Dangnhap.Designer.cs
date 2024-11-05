

using BLL;

namespace GUI_CSharp
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.btnDangnhap = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatkhau = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTaikhoan = new MaterialSkin.Controls.MaterialTextBox();
            this.check_matKhau = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.AutoSize = false;
            this.btnDangnhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangnhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangnhap.Depth = 0;
            this.btnDangnhap.HighEmphasis = true;
            this.btnDangnhap.Icon = null;
            this.btnDangnhap.Location = new System.Drawing.Point(72, 352);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDangnhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangnhap.Size = new System.Drawing.Size(375, 32);
            this.btnDangnhap.TabIndex = 108;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangnhap.UseAccentColor = false;
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.AnimateReadOnly = false;
            this.txtMatkhau.BackColor = System.Drawing.Color.White;
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhau.Depth = 0;
            this.txtMatkhau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatkhau.Hint = "Mật khẩu";
            this.txtMatkhau.LeadingIcon = null;
            this.txtMatkhau.Location = new System.Drawing.Point(72, 247);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatkhau.MaxLength = 50;
            this.txtMatkhau.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatkhau.Multiline = false;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Password = true;
            this.txtMatkhau.Size = new System.Drawing.Size(375, 50);
            this.txtMatkhau.TabIndex = 109;
            this.txtMatkhau.Text = "";
            this.txtMatkhau.TrailingIcon = null;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.AnimateReadOnly = false;
            this.txtTaikhoan.BackColor = System.Drawing.Color.White;
            this.txtTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaikhoan.Depth = 0;
            this.txtTaikhoan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTaikhoan.Hint = "Tài khoản";
            this.txtTaikhoan.LeadingIcon = null;
            this.txtTaikhoan.Location = new System.Drawing.Point(72, 183);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaikhoan.MaxLength = 50;
            this.txtTaikhoan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTaikhoan.Multiline = false;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(375, 50);
            this.txtTaikhoan.TabIndex = 109;
            this.txtTaikhoan.Text = "";
            this.txtTaikhoan.TrailingIcon = null;
            this.txtTaikhoan.TextChanged += new System.EventHandler(this.txTaikhoan_TextChanged);
            // 
            // check_matKhau
            // 
            this.check_matKhau.AutoSize = true;
            this.check_matKhau.Depth = 0;
            this.check_matKhau.Location = new System.Drawing.Point(287, 299);
            this.check_matKhau.Margin = new System.Windows.Forms.Padding(0);
            this.check_matKhau.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_matKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_matKhau.Name = "check_matKhau";
            this.check_matKhau.ReadOnly = false;
            this.check_matKhau.Ripple = true;
            this.check_matKhau.Size = new System.Drawing.Size(160, 37);
            this.check_matKhau.TabIndex = 110;
            this.check_matKhau.Text = "Hiển thị mật khẩu";
            this.check_matKhau.UseVisualStyleBackColor = true;
            this.check_matKhau.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 429);
            this.Controls.Add(this.check_matKhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dangnhap";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MaterialSkin.Controls.MaterialButton btnDangnhap;
        public System.Windows.Forms.PictureBox pictureBox1;
        public MaterialSkin.Controls.MaterialTextBox txtMatkhau;
        public MaterialSkin.Controls.MaterialTextBox txtTaikhoan;
        public MaterialSkin.Controls.MaterialCheckbox check_matKhau;
    }
}

