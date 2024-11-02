using MaterialSkin.Controls;
namespace GUI_CSharp
{
    partial class SuaHS
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
            this.cardHS = new MaterialSkin.Controls.MaterialCard();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTongiao = new MaterialSkin.Controls.MaterialComboBox();
            this.cbNgheme = new MaterialSkin.Controls.MaterialComboBox();
            this.cbNghecha = new MaterialSkin.Controls.MaterialComboBox();
            this.cbDantoc = new MaterialSkin.Controls.MaterialComboBox();
            this.ngaySinh_HS = new System.Windows.Forms.DateTimePicker();
            this.gioiTinh_nu = new MaterialSkin.Controls.MaterialRadioButton();
            this.gioiTinh_nam = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txTenme = new MaterialSkin.Controls.MaterialTextBox();
            this.txTencha = new MaterialSkin.Controls.MaterialTextBox();
            this.txDiachi_HS = new MaterialSkin.Controls.MaterialTextBox();
            this.txTenHS = new MaterialSkin.Controls.MaterialTextBox();
            this.txMaHS = new MaterialSkin.Controls.MaterialTextBox();
            this.cardHS.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardHS
            // 
            this.cardHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardHS.Controls.Add(this.btnSua);
            this.cardHS.Controls.Add(this.label1);
            this.cardHS.Controls.Add(this.cbTongiao);
            this.cardHS.Controls.Add(this.cbNgheme);
            this.cardHS.Controls.Add(this.cbNghecha);
            this.cardHS.Controls.Add(this.cbDantoc);
            this.cardHS.Controls.Add(this.ngaySinh_HS);
            this.cardHS.Controls.Add(this.gioiTinh_nu);
            this.cardHS.Controls.Add(this.gioiTinh_nam);
            this.cardHS.Controls.Add(this.materialLabel2);
            this.cardHS.Controls.Add(this.materialLabel1);
            this.cardHS.Controls.Add(this.txEmail);
            this.cardHS.Controls.Add(this.txTenme);
            this.cardHS.Controls.Add(this.txTencha);
            this.cardHS.Controls.Add(this.txDiachi_HS);
            this.cardHS.Controls.Add(this.txTenHS);
            this.cardHS.Controls.Add(this.txMaHS);
            this.cardHS.Depth = 0;
            this.cardHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardHS.Location = new System.Drawing.Point(23, 96);
            this.cardHS.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardHS.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardHS.Name = "cardHS";
            this.cardHS.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardHS.Size = new System.Drawing.Size(1160, 853);
            this.cardHS.TabIndex = 21;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::GUI_CSharp.Properties.Resources.save;
            this.btnSua.Location = new System.Drawing.Point(389, 742);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(372, 52);
            this.btnSua.TabIndex = 21;
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
            this.label1.Location = new System.Drawing.Point(427, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "THÔNG TIN HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTongiao
            // 
            this.cbTongiao.AutoResize = false;
            this.cbTongiao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTongiao.Depth = 0;
            this.cbTongiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTongiao.DropDownHeight = 174;
            this.cbTongiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTongiao.DropDownWidth = 121;
            this.cbTongiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTongiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTongiao.FormattingEnabled = true;
            this.cbTongiao.Hint = "Tôn giáo";
            this.cbTongiao.IntegralHeight = false;
            this.cbTongiao.ItemHeight = 43;
            this.cbTongiao.Location = new System.Drawing.Point(855, 335);
            this.cbTongiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTongiao.MaxDropDownItems = 4;
            this.cbTongiao.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTongiao.Name = "cbTongiao";
            this.cbTongiao.Size = new System.Drawing.Size(197, 49);
            this.cbTongiao.StartIndex = 0;
            this.cbTongiao.TabIndex = 17;
            // 
            // cbNgheme
            // 
            this.cbNgheme.AutoResize = false;
            this.cbNgheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNgheme.Depth = 0;
            this.cbNgheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNgheme.DropDownHeight = 174;
            this.cbNgheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgheme.DropDownWidth = 121;
            this.cbNgheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNgheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNgheme.FormattingEnabled = true;
            this.cbNgheme.Hint = "Nghề nghiệp mẹ";
            this.cbNgheme.IntegralHeight = false;
            this.cbNgheme.ItemHeight = 43;
            this.cbNgheme.Location = new System.Drawing.Point(624, 532);
            this.cbNgheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNgheme.MaxDropDownItems = 4;
            this.cbNgheme.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNgheme.Name = "cbNgheme";
            this.cbNgheme.Size = new System.Drawing.Size(428, 49);
            this.cbNgheme.StartIndex = 0;
            this.cbNgheme.TabIndex = 17;
            // 
            // cbNghecha
            // 
            this.cbNghecha.AutoResize = false;
            this.cbNghecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNghecha.Depth = 0;
            this.cbNghecha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNghecha.DropDownHeight = 174;
            this.cbNghecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNghecha.DropDownWidth = 121;
            this.cbNghecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNghecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNghecha.FormattingEnabled = true;
            this.cbNghecha.Hint = "Nghề nghiệp cha";
            this.cbNghecha.IntegralHeight = false;
            this.cbNghecha.ItemHeight = 43;
            this.cbNghecha.Location = new System.Drawing.Point(624, 431);
            this.cbNghecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNghecha.MaxDropDownItems = 4;
            this.cbNghecha.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNghecha.Name = "cbNghecha";
            this.cbNghecha.Size = new System.Drawing.Size(428, 49);
            this.cbNghecha.StartIndex = 0;
            this.cbNghecha.TabIndex = 17;
            // 
            // cbDantoc
            // 
            this.cbDantoc.AutoResize = false;
            this.cbDantoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDantoc.Depth = 0;
            this.cbDantoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDantoc.DropDownHeight = 174;
            this.cbDantoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDantoc.DropDownWidth = 121;
            this.cbDantoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDantoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDantoc.FormattingEnabled = true;
            this.cbDantoc.Hint = "Dân tộc";
            this.cbDantoc.IntegralHeight = false;
            this.cbDantoc.ItemHeight = 43;
            this.cbDantoc.Location = new System.Drawing.Point(624, 335);
            this.cbDantoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDantoc.MaxDropDownItems = 4;
            this.cbDantoc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDantoc.Name = "cbDantoc";
            this.cbDantoc.Size = new System.Drawing.Size(197, 49);
            this.cbDantoc.StartIndex = 0;
            this.cbDantoc.TabIndex = 17;
            // 
            // ngaySinh_HS
            // 
            this.ngaySinh_HS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngaySinh_HS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)), true);
            this.ngaySinh_HS.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ngaySinh_HS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)), true);
            this.ngaySinh_HS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaySinh_HS.Location = new System.Drawing.Point(792, 246);
            this.ngaySinh_HS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngaySinh_HS.Name = "ngaySinh_HS";
            this.ngaySinh_HS.Size = new System.Drawing.Size(260, 30);
            this.ngaySinh_HS.TabIndex = 16;
            // 
            // gioiTinh_nu
            // 
            this.gioiTinh_nu.AutoSize = true;
            this.gioiTinh_nu.Depth = 0;
            this.gioiTinh_nu.Location = new System.Drawing.Point(979, 148);
            this.gioiTinh_nu.Margin = new System.Windows.Forms.Padding(0);
            this.gioiTinh_nu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gioiTinh_nu.MouseState = MaterialSkin.MouseState.HOVER;
            this.gioiTinh_nu.Name = "gioiTinh_nu";
            this.gioiTinh_nu.Ripple = true;
            this.gioiTinh_nu.Size = new System.Drawing.Size(56, 37);
            this.gioiTinh_nu.TabIndex = 15;
            this.gioiTinh_nu.TabStop = true;
            this.gioiTinh_nu.Text = "Nữ";
            this.gioiTinh_nu.UseVisualStyleBackColor = true;
            // 
            // gioiTinh_nam
            // 
            this.gioiTinh_nam.AutoSize = true;
            this.gioiTinh_nam.Depth = 0;
            this.gioiTinh_nam.Location = new System.Drawing.Point(792, 148);
            this.gioiTinh_nam.Margin = new System.Windows.Forms.Padding(0);
            this.gioiTinh_nam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gioiTinh_nam.MouseState = MaterialSkin.MouseState.HOVER;
            this.gioiTinh_nam.Name = "gioiTinh_nam";
            this.gioiTinh_nam.Ripple = true;
            this.gioiTinh_nam.Size = new System.Drawing.Size(69, 37);
            this.gioiTinh_nam.TabIndex = 15;
            this.gioiTinh_nam.TabStop = true;
            this.gioiTinh_nam.Text = "Nam";
            this.gioiTinh_nam.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(648, 257);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Ngày sinh:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(648, 160);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Giới tính:";
            // 
            // txEmail
            // 
            this.txEmail.AnimateReadOnly = false;
            this.txEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txEmail.Depth = 0;
            this.txEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txEmail.Hint = "Email";
            this.txEmail.LeadingIcon = null;
            this.txEmail.Location = new System.Drawing.Point(107, 334);
            this.txEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txEmail.MaxLength = 50;
            this.txEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txEmail.Multiline = false;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(476, 50);
            this.txEmail.TabIndex = 7;
            this.txEmail.Text = "";
            this.txEmail.TrailingIcon = null;
            // 
            // txTenme
            // 
            this.txTenme.AnimateReadOnly = false;
            this.txTenme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenme.Depth = 0;
            this.txTenme.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenme.Hint = "Họ tên mẹ";
            this.txTenme.LeadingIcon = null;
            this.txTenme.Location = new System.Drawing.Point(107, 530);
            this.txTenme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txTenme.MaxLength = 50;
            this.txTenme.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenme.Multiline = false;
            this.txTenme.Name = "txTenme";
            this.txTenme.Size = new System.Drawing.Size(476, 50);
            this.txTenme.TabIndex = 7;
            this.txTenme.Text = "";
            this.txTenme.TrailingIcon = null;
            // 
            // txTencha
            // 
            this.txTencha.AnimateReadOnly = false;
            this.txTencha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTencha.Depth = 0;
            this.txTencha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTencha.Hint = "Họ tên cha";
            this.txTencha.LeadingIcon = null;
            this.txTencha.Location = new System.Drawing.Point(107, 432);
            this.txTencha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txTencha.MaxLength = 50;
            this.txTencha.MouseState = MaterialSkin.MouseState.OUT;
            this.txTencha.Multiline = false;
            this.txTencha.Name = "txTencha";
            this.txTencha.Size = new System.Drawing.Size(476, 50);
            this.txTencha.TabIndex = 7;
            this.txTencha.Text = "";
            this.txTencha.TrailingIcon = null;
            // 
            // txDiachi_HS
            // 
            this.txDiachi_HS.AnimateReadOnly = false;
            this.txDiachi_HS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDiachi_HS.Depth = 0;
            this.txDiachi_HS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiachi_HS.Hint = "Địa chỉ";
            this.txDiachi_HS.LeadingIcon = null;
            this.txDiachi_HS.Location = new System.Drawing.Point(107, 629);
            this.txDiachi_HS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txDiachi_HS.MaxLength = 50;
            this.txDiachi_HS.MouseState = MaterialSkin.MouseState.OUT;
            this.txDiachi_HS.Multiline = false;
            this.txDiachi_HS.Name = "txDiachi_HS";
            this.txDiachi_HS.Size = new System.Drawing.Size(947, 50);
            this.txDiachi_HS.TabIndex = 7;
            this.txDiachi_HS.Text = "";
            this.txDiachi_HS.TrailingIcon = null;
            // 
            // txTenHS
            // 
            this.txTenHS.AnimateReadOnly = false;
            this.txTenHS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenHS.Depth = 0;
            this.txTenHS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenHS.Hint = "Họ và tên ";
            this.txTenHS.LeadingIcon = null;
            this.txTenHS.Location = new System.Drawing.Point(107, 235);
            this.txTenHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txTenHS.MaxLength = 50;
            this.txTenHS.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenHS.Multiline = false;
            this.txTenHS.Name = "txTenHS";
            this.txTenHS.Size = new System.Drawing.Size(476, 50);
            this.txTenHS.TabIndex = 6;
            this.txTenHS.Text = "";
            this.txTenHS.TrailingIcon = null;
            // 
            // txMaHS
            // 
            this.txMaHS.AnimateReadOnly = false;
            this.txMaHS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMaHS.Depth = 0;
            this.txMaHS.Enabled = false;
            this.txMaHS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMaHS.Hint = "Mã học sinh";
            this.txMaHS.LeadingIcon = null;
            this.txMaHS.Location = new System.Drawing.Point(107, 137);
            this.txMaHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txMaHS.MaxLength = 50;
            this.txMaHS.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaHS.Multiline = false;
            this.txMaHS.Name = "txMaHS";
            this.txMaHS.Size = new System.Drawing.Size(476, 50);
            this.txMaHS.TabIndex = 1;
            this.txMaHS.Text = "";
            this.txMaHS.TrailingIcon = null;
            // 
            // SuaHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 970);
            this.Controls.Add(this.cardHS);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaHS";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatThongTinHocSinh";
            this.cardHS.ResumeLayout(false);
            this.cardHS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardHS;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cbTongiao;
        private MaterialSkin.Controls.MaterialComboBox cbNgheme;
        private MaterialSkin.Controls.MaterialComboBox cbNghecha;
        private MaterialSkin.Controls.MaterialComboBox cbDantoc;
        private System.Windows.Forms.DateTimePicker ngaySinh_HS;
        private MaterialSkin.Controls.MaterialRadioButton gioiTinh_nu;
        private MaterialSkin.Controls.MaterialRadioButton gioiTinh_nam;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txEmail;
        private MaterialSkin.Controls.MaterialTextBox txTenme;
        private MaterialSkin.Controls.MaterialTextBox txTencha;
        private MaterialSkin.Controls.MaterialTextBox txDiachi_HS;
        private MaterialSkin.Controls.MaterialTextBox txTenHS;
        private MaterialSkin.Controls.MaterialTextBox txMaHS;
        private MaterialSkin.Controls.MaterialButton btnSua;
    }
}