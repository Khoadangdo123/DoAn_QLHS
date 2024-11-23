namespace GUI_CSharp
{
    partial class ThemTT
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
            this.cbDiemCong = new MaterialSkin.Controls.MaterialComboBox();
            this.btnThemTT = new MaterialSkin.Controls.MaterialButton();
            this.txTenTT = new MaterialSkin.Controls.MaterialTextBox();
            this.txMaTT = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cbDiemCong);
            this.materialCard1.Controls.Add(this.btnThemTT);
            this.materialCard1.Controls.Add(this.txTenTT);
            this.materialCard1.Controls.Add(this.txMaTT);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(2, 67);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(520, 520);
            this.materialCard1.TabIndex = 0;
            // 
            // cbDiemCong
            // 
            this.cbDiemCong.AutoResize = false;
            this.cbDiemCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDiemCong.Depth = 0;
            this.cbDiemCong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDiemCong.DropDownHeight = 174;
            this.cbDiemCong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemCong.DropDownWidth = 121;
            this.cbDiemCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDiemCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDiemCong.FormattingEnabled = true;
            this.cbDiemCong.Hint = "Điểm cộng";
            this.cbDiemCong.IntegralHeight = false;
            this.cbDiemCong.ItemHeight = 43;
            this.cbDiemCong.Location = new System.Drawing.Point(59, 310);
            this.cbDiemCong.MaxDropDownItems = 4;
            this.cbDiemCong.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDiemCong.Name = "cbDiemCong";
            this.cbDiemCong.Size = new System.Drawing.Size(411, 49);
            this.cbDiemCong.StartIndex = 0;
            this.cbDiemCong.TabIndex = 39;
            // 
            // btnThemTT
            // 
            this.btnThemTT.AutoSize = false;
            this.btnThemTT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemTT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemTT.Depth = 0;
            this.btnThemTT.HighEmphasis = true;
            this.btnThemTT.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnThemTT.Location = new System.Drawing.Point(121, 397);
            this.btnThemTT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemTT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemTT.Size = new System.Drawing.Size(279, 42);
            this.btnThemTT.TabIndex = 38;
            this.btnThemTT.TabStop = false;
            this.btnThemTT.Text = "Thêm";
            this.btnThemTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemTT.UseAccentColor = false;
            this.btnThemTT.UseVisualStyleBackColor = true;
            // 
            // txTenTT
            // 
            this.txTenTT.AnimateReadOnly = false;
            this.txTenTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenTT.Depth = 0;
            this.txTenTT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenTT.Hint = "Thành tích";
            this.txTenTT.LeadingIcon = null;
            this.txTenTT.Location = new System.Drawing.Point(59, 220);
            this.txTenTT.MaxLength = 50;
            this.txTenTT.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenTT.Multiline = false;
            this.txTenTT.Name = "txTenTT";
            this.txTenTT.Size = new System.Drawing.Size(411, 50);
            this.txTenTT.TabIndex = 36;
            this.txTenTT.Text = "";
            this.txTenTT.TrailingIcon = null;
            // 
            // txMaTT
            // 
            this.txMaTT.AnimateReadOnly = false;
            this.txMaTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMaTT.Depth = 0;
            this.txMaTT.Enabled = false;
            this.txMaTT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMaTT.Hint = "Mã thành tích";
            this.txMaTT.LeadingIcon = null;
            this.txMaTT.Location = new System.Drawing.Point(59, 130);
            this.txMaTT.MaxLength = 50;
            this.txMaTT.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaTT.Multiline = false;
            this.txMaTT.Name = "txMaTT";
            this.txMaTT.Size = new System.Drawing.Size(411, 50);
            this.txMaTT.TabIndex = 1;
            this.txMaTT.Text = "";
            this.txMaTT.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(149, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 43);
            this.label2.TabIndex = 35;
            this.label2.Text = "THÊM THÀNH TÍCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 592);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemTT";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemThanhTich";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cbDiemCong;
        private MaterialSkin.Controls.MaterialButton btnThemTT;
        private MaterialSkin.Controls.MaterialTextBox txTenTT;
        private MaterialSkin.Controls.MaterialTextBox txMaTT;
        private System.Windows.Forms.Label label2;
    }
}