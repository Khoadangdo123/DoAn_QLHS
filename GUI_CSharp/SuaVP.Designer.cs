namespace GUI_CSharp
{
    partial class SuaVP
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
            this.cbDiemTru = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSuaVP = new MaterialSkin.Controls.MaterialButton();
            this.txTenVP = new MaterialSkin.Controls.MaterialTextBox();
            this.txMaVP = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cbDiemTru);
            this.materialCard1.Controls.Add(this.btnSuaVP);
            this.materialCard1.Controls.Add(this.txTenVP);
            this.materialCard1.Controls.Add(this.txMaVP);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(6, 65);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(520, 520);
            this.materialCard1.TabIndex = 1;
            // 
            // cbDiemTru
            // 
            this.cbDiemTru.AutoResize = false;
            this.cbDiemTru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDiemTru.Depth = 0;
            this.cbDiemTru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDiemTru.DropDownHeight = 174;
            this.cbDiemTru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemTru.DropDownWidth = 121;
            this.cbDiemTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDiemTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDiemTru.FormattingEnabled = true;
            this.cbDiemTru.Hint = "Điểm trừ";
            this.cbDiemTru.IntegralHeight = false;
            this.cbDiemTru.ItemHeight = 43;
            this.cbDiemTru.Location = new System.Drawing.Point(59, 310);
            this.cbDiemTru.MaxDropDownItems = 4;
            this.cbDiemTru.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDiemTru.Name = "cbDiemTru";
            this.cbDiemTru.Size = new System.Drawing.Size(411, 49);
            this.cbDiemTru.StartIndex = 0;
            this.cbDiemTru.TabIndex = 39;
            // 
            // btnSuaVP
            // 
            this.btnSuaVP.AutoSize = false;
            this.btnSuaVP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaVP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSuaVP.Depth = 0;
            this.btnSuaVP.HighEmphasis = true;
            this.btnSuaVP.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnSuaVP.Location = new System.Drawing.Point(121, 397);
            this.btnSuaVP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaVP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaVP.Name = "btnSuaVP";
            this.btnSuaVP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSuaVP.Size = new System.Drawing.Size(279, 42);
            this.btnSuaVP.TabIndex = 38;
            this.btnSuaVP.TabStop = false;
            this.btnSuaVP.Text = "Sửa";
            this.btnSuaVP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaVP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSuaVP.UseAccentColor = false;
            this.btnSuaVP.UseVisualStyleBackColor = true;
            // 
            // txTenVP
            // 
            this.txTenVP.AnimateReadOnly = false;
            this.txTenVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTenVP.Depth = 0;
            this.txTenVP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenVP.Hint = "Vi phạm";
            this.txTenVP.LeadingIcon = null;
            this.txTenVP.Location = new System.Drawing.Point(59, 220);
            this.txTenVP.MaxLength = 50;
            this.txTenVP.MouseState = MaterialSkin.MouseState.OUT;
            this.txTenVP.Multiline = false;
            this.txTenVP.Name = "txTenVP";
            this.txTenVP.Size = new System.Drawing.Size(411, 50);
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
            this.txMaVP.Location = new System.Drawing.Point(59, 130);
            this.txMaVP.MaxLength = 50;
            this.txMaVP.MouseState = MaterialSkin.MouseState.OUT;
            this.txMaVP.Multiline = false;
            this.txMaVP.Name = "txMaVP";
            this.txMaVP.Size = new System.Drawing.Size(411, 50);
            this.txMaVP.TabIndex = 1;
            this.txMaVP.Text = "";
            this.txMaVP.TrailingIcon = null;
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
            this.label2.Text = "SỬA VI PHẠM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuaVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 584);
            this.Controls.Add(this.materialCard1);
            this.Name = "SuaVP";
            this.Text = "SuaVP";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cbDiemTru;
        private MaterialSkin.Controls.MaterialButton btnSuaVP;
        private MaterialSkin.Controls.MaterialTextBox txTenVP;
        private MaterialSkin.Controls.MaterialTextBox txMaVP;
        private System.Windows.Forms.Label label2;
    }
}