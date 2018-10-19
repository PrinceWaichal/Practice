using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace Testing_Application
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();

            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;

            manager.ColorScheme = new ColorScheme
                (
                Primary.Cyan300, Primary.Green400, Primary.Red300, Accent.LightBlue200, TextShade.WHITE
                );
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }
}
