namespace GUI_CSharp
{
    partial class ThemVP
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
            this.cbDiemtru = new MaterialSkin.Controls.MaterialComboBox();
            this.btnThemVP = new MaterialSkin.Controls.MaterialButton();
            this.txTenVP = new MaterialSkin.Controls.MaterialTextBox();
            this.txMaVP = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cbDiemtru);
            this.materialCard1.Controls.Add(this.btnThemVP);
            this.materialCard1.Controls.Add(this.txTenVP);
            this.materialCard1.Controls.Add(this.txMaVP);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 106);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.Size = new System.Drawing.Size(780, 800);
            this.materialCard1.TabIndex = 1;
            // 
            // cbDiemtru
            // 
            this.cbDiemtru.AutoResize = false;
            this.cbDiemtru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDiemtru.Depth = 0;
            this.cbDiemtru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDiemtru.DropDownHeight = 174;
            this.cbDiemtru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemtru.DropDownWidth = 121;
            this.cbDiemtru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDiemtru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDiemtru.FormattingEnabled = true;
            this.cbDiemtru.Hint = "Điểm trừ";
            this.cbDiemtru.IntegralHeight = false;
            this.cbDiemtru.ItemHeight = 43;
            this.cbDiemtru.Location = new System.Drawing.Point(88, 477);
            this.cbDiemtru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDiemtru.MaxDropDownItems = 4;
            this.cbDiemtru.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDiemtru.Name = "cbDiemtru";
            this.cbDiemtru.Size = new System.Drawing.Size(614, 49);
            this.cbDiemtru.StartIndex = 0;
            this.cbDiemtru.TabIndex = 39;
            // 
            // btnThemVP
            // 
            this.btnThemVP.AutoSize = false;
            this.btnThemVP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemVP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemVP.Depth = 0;
            this.btnThemVP.HighEmphasis = true;
            this.btnThemVP.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnThemVP.Location = new System.Drawing.Point(182, 611);
            this.btnThemVP.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnThemVP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemVP.Name = "btnThemVP";
            this.btnThemVP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemVP.Size = new System.Drawing.Size(418, 65);
            this.btnThemVP.TabIndex = 38;
            this.btnThemVP.TabStop = false;
            this.btnThemVP.Text = "Thêm";
            this.btnThemVP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemVP.UseAccentColor = false;
            this.btnThemVP.UseVisualStyleBackColor = true;
            this.btnThemVP.Click += new System.EventHandler(this.btnThemVP_Click);
            // 
            // txTenVP
            // 
            this.txTenVP.AnimateReadOnly = false;
            this.txTenVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenVP.Depth = 0;
            this.txTenVP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenVP.Hint = "Vi phạm";
            this.txTenVP.LeadingIcon = null;
            this.txTenVP.Location = new System.Drawing.Point(88, 338);
            this.txTenVP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txTenVP.MaxLength = 50;
            this.txTenVP.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenVP.Multiline = false;
            this.txTenVP.Name = "txTenVP";
            this.txTenVP.Size = new System.Drawing.Size(616, 50);
            this.txTenVP.TabIndex = 36;
            this.txTenVP.Text = "";
            this.txTenVP.TrailingIcon = null;
            // 
            // txMaVP
            // 
            this.txMaVP.AnimateReadOnly = false;
            this.txMaVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMaVP.Depth = 0;
            this.txMaVP.Enabled = false;
            this.txMaVP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txMaVP.Hint = "Mã vi phạm";
            this.txMaVP.LeadingIcon = null;
            this.txMaVP.Location = new System.Drawing.Point(88, 200);
            this.txMaVP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txMaVP.MaxLength = 50;
            this.txMaVP.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaVP.Multiline = false;
            this.txMaVP.Name = "txMaVP";
            this.txMaVP.Size = new System.Drawing.Size(616, 50);
            this.txMaVP.TabIndex = 1;
            this.txMaVP.Text = "";
            this.txMaVP.TrailingIcon = null;
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
            this.label2.Text = "THÊM VI PHẠM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 911);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemVP";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemViPham";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cbDiemtru;
        private MaterialSkin.Controls.MaterialButton btnThemVP;
        private MaterialSkin.Controls.MaterialTextBox txTenVP;
        private MaterialSkin.Controls.MaterialTextBox txMaVP;
        private System.Windows.Forms.Label label2;
    }
}