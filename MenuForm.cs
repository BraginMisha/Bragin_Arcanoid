using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bragin_Arcanoid
{
    public partial class MenuForm : Form
    {

        public MenuForm()
        {
             InitializeComponent();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            var infoForm = new Form1();
            Hide();
            infoForm.ShowDialog();
            Show();
        }
        

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
