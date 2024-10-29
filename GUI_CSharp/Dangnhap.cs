using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace GUI_CSharp
{
    public partial class Dangnhap : MaterialForm
    {
        public Dangnhap()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Teal700, TextShade.WHITE);
            
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_matKhau.Checked)
            {
                txMatkhau.Password = false;
            }
            else
            {
                txMatkhau.Password = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu a = new Trangchu();
            a.Show();
            a.FormClosed += (s, args) => this.Close();
        }
    }
}
