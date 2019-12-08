using System;
using System.Windows.Forms;

namespace FlowModel.Screens
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quadro paint = new Quadro();
            paint.Show();
        }
    }
}
