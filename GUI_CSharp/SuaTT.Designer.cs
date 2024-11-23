namespace GUI_CSharp
{
    partial class SuaTT
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
            this.btnSuaTT = new MaterialSkin.Controls.MaterialButton();
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
            this.materialCard1.Controls.Add(this.btnSuaTT);
            this.materialCard1.Controls.Add(this.txTenTT);
            this.materialCard1.Controls.Add(this.txMaTT);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 103);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.Size = new System.Drawing.Size(780, 800);
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
            this.cbDiemCong.Location = new System.Drawing.Point(88, 477);
            this.cbDiemCong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDiemCong.MaxDropDownItems = 4;
            this.cbDiemCong.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDiemCong.Name = "cbDiemCong";
            this.cbDiemCong.Size = new System.Drawing.Size(614, 49);
            this.cbDiemCong.StartIndex = 0;
            this.cbDiemCong.TabIndex = 39;
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.AutoSize = false;
            this.btnSuaTT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaTT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSuaTT.Depth = 0;
            this.btnSuaTT.HighEmphasis = true;
            this.btnSuaTT.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnSuaTT.Location = new System.Drawing.Point(182, 611);
            this.btnSuaTT.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSuaTT.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSuaTT.Size = new System.Drawing.Size(418, 65);
            this.btnSuaTT.TabIndex = 38;
            this.btnSuaTT.TabStop = false;
            this.btnSuaTT.Text = "Sửa";
            this.btnSuaTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSuaTT.UseAccentColor = false;
            this.btnSuaTT.UseVisualStyleBackColor = true;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // txTenTT
            // 
            this.txTenTT.AnimateReadOnly = false;
            this.txTenTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenTT.Depth = 0;
            this.txTenTT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenTT.Hint = "Thành tích";
            this.txTenTT.LeadingIcon = null;
            this.txTenTT.Location = new System.Drawing.Point(88, 338);
            this.txTenTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txTenTT.MaxLength = 50;
            this.txTenTT.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenTT.Multiline = false;
            this.txTenTT.Name = "txTenTT";
            this.txTenTT.Size = new System.Drawing.Size(616, 50);
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
            this.txMaTT.Location = new System.Drawing.Point(88, 200);
            this.txMaTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txMaTT.MaxLength = 50;
            this.txMaTT.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaTT.Multiline = false;
            this.txMaTT.Name = "txMaTT";
            this.txMaTT.Size = new System.Drawing.Size(616, 50);
            this.txMaTT.TabIndex = 1;
            this.txMaTT.Text = "";
            this.txMaTT.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(224, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 66);
            this.label2.TabIndex = 35;
            this.label2.Text = "SỬA THÀNH TÍCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 911);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaThanhTich";
            this.Sizable = false;
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cbDiemCong;
        private MaterialSkin.Controls.MaterialButton btnSuaTT;
        private MaterialSkin.Controls.MaterialTextBox txTenTT;
        private MaterialSkin.Controls.MaterialTextBox txMaTT;
        private System.Windows.Forms.Label label2;
    }
}