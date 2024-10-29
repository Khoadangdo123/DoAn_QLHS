namespace GUI_CSharp
{
    partial class SuaDiemMon
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
            this.txDiemthi = new MaterialSkin.Controls.MaterialTextBox();
            this.txDiem45 = new MaterialSkin.Controls.MaterialTextBox();
            this.txDiem15 = new MaterialSkin.Controls.MaterialTextBox();
            this.txDiemMieng = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txMonhoc = new MaterialSkin.Controls.MaterialTextBox();
            this.txMaHS = new MaterialSkin.Controls.MaterialTextBox();
            this.cardHS.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardHS
            // 
            this.cardHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardHS.Controls.Add(this.btnSua);
            this.cardHS.Controls.Add(this.txDiemthi);
            this.cardHS.Controls.Add(this.txDiem45);
            this.cardHS.Controls.Add(this.txDiem15);
            this.cardHS.Controls.Add(this.txDiemMieng);
            this.cardHS.Controls.Add(this.label1);
            this.cardHS.Controls.Add(this.txMonhoc);
            this.cardHS.Controls.Add(this.txMaHS);
            this.cardHS.Depth = 0;
            this.cardHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardHS.Location = new System.Drawing.Point(4, 68);
            this.cardHS.Margin = new System.Windows.Forms.Padding(14);
            this.cardHS.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardHS.Name = "cardHS";
            this.cardHS.Padding = new System.Windows.Forms.Padding(14);
            this.cardHS.Size = new System.Drawing.Size(535, 718);
            this.cardHS.TabIndex = 22;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::GUI_CSharp.Properties.Resources.save;
            this.btnSua.Location = new System.Drawing.Point(84, 615);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(357, 42);
            this.btnSua.TabIndex = 23;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // txDiemthi
            // 
            this.txDiemthi.AnimateReadOnly = false;
            this.txDiemthi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDiemthi.Depth = 0;
            this.txDiemthi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiemthi.Hint = "Điểm thi";
            this.txDiemthi.LeadingIcon = null;
            this.txDiemthi.Location = new System.Drawing.Point(84, 507);
            this.txDiemthi.MaxLength = 50;
            this.txDiemthi.MouseState = MaterialSkin.MouseState.OUT;
            this.txDiemthi.Multiline = false;
            this.txDiemthi.Name = "txDiemthi";
            this.txDiemthi.Size = new System.Drawing.Size(357, 50);
            this.txDiemthi.TabIndex = 22;
            this.txDiemthi.Text = "";
            this.txDiemthi.TrailingIcon = null;
            // 
            // txDiem45
            // 
            this.txDiem45.AnimateReadOnly = false;
            this.txDiem45.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDiem45.Depth = 0;
            this.txDiem45.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiem45.Hint = "Điểm 45 phút";
            this.txDiem45.LeadingIcon = null;
            this.txDiem45.Location = new System.Drawing.Point(84, 427);
            this.txDiem45.MaxLength = 50;
            this.txDiem45.MouseState = MaterialSkin.MouseState.OUT;
            this.txDiem45.Multiline = false;
            this.txDiem45.Name = "txDiem45";
            this.txDiem45.Size = new System.Drawing.Size(357, 50);
            this.txDiem45.TabIndex = 22;
            this.txDiem45.Text = "";
            this.txDiem45.TrailingIcon = null;
            // 
            // txDiem15
            // 
            this.txDiem15.AnimateReadOnly = false;
            this.txDiem15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDiem15.Depth = 0;
            this.txDiem15.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiem15.Hint = "Điểm 15 phút";
            this.txDiem15.LeadingIcon = null;
            this.txDiem15.Location = new System.Drawing.Point(84, 347);
            this.txDiem15.MaxLength = 50;
            this.txDiem15.MouseState = MaterialSkin.MouseState.OUT;
            this.txDiem15.Multiline = false;
            this.txDiem15.Name = "txDiem15";
            this.txDiem15.Size = new System.Drawing.Size(357, 50);
            this.txDiem15.TabIndex = 22;
            this.txDiem15.Text = "";
            this.txDiem15.TrailingIcon = null;
            // 
            // txDiemMieng
            // 
            this.txDiemMieng.AnimateReadOnly = false;
            this.txDiemMieng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txDiemMieng.Depth = 0;
            this.txDiemMieng.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiemMieng.Hint = "Điểm miệng";
            this.txDiemMieng.LeadingIcon = null;
            this.txDiemMieng.Location = new System.Drawing.Point(84, 267);
            this.txDiemMieng.MaxLength = 50;
            this.txDiemMieng.MouseState = MaterialSkin.MouseState.OUT;
            this.txDiemMieng.Multiline = false;
            this.txDiemMieng.Name = "txDiemMieng";
            this.txDiemMieng.Size = new System.Drawing.Size(357, 50);
            this.txDiemMieng.TabIndex = 1;
            this.txDiemMieng.Text = "";
            this.txDiemMieng.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "CẬP NHẬT ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txMonhoc
            // 
            this.txMonhoc.AnimateReadOnly = false;
            this.txMonhoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMonhoc.Depth = 0;
            this.txMonhoc.Enabled = false;
            this.txMonhoc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMonhoc.Hint = "Môn học";
            this.txMonhoc.LeadingIcon = null;
            this.txMonhoc.Location = new System.Drawing.Point(84, 187);
            this.txMonhoc.MaxLength = 50;
            this.txMonhoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txMonhoc.Multiline = false;
            this.txMonhoc.Name = "txMonhoc";
            this.txMonhoc.Size = new System.Drawing.Size(357, 50);
            this.txMonhoc.TabIndex = 7;
            this.txMonhoc.Text = "";
            this.txMonhoc.TrailingIcon = null;
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
            this.txMaHS.Location = new System.Drawing.Point(84, 107);
            this.txMaHS.MaxLength = 50;
            this.txMaHS.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaHS.Multiline = false;
            this.txMaHS.Name = "txMaHS";
            this.txMaHS.Size = new System.Drawing.Size(357, 50);
            this.txMaHS.TabIndex = 1;
            this.txMaHS.Text = "";
            this.txMaHS.TrailingIcon = null;
            // 
            // SuaDiemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 794);
            this.Controls.Add(this.cardHS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaDiemMon";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaDiemMonHoc";
            this.cardHS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardHS;
        private MaterialSkin.Controls.MaterialTextBox txDiemthi;
        private MaterialSkin.Controls.MaterialTextBox txDiem45;
        private MaterialSkin.Controls.MaterialTextBox txDiem15;
        private MaterialSkin.Controls.MaterialTextBox txDiemMieng;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txMonhoc;
        private MaterialSkin.Controls.MaterialTextBox txMaHS;
        private MaterialSkin.Controls.MaterialButton btnSua;
    }
}