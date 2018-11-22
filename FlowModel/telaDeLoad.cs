using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    public partial class telaDeLoad : Form
    {
        public telaDeLoad()
        {
            InitializeComponent();
        }

        private void telaDeLoad_Shown(object sender, EventArgs e)
        {
        }

        private void telaDeLoad_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void telaDeLoad_Activated(object sender, EventArgs e)
        {

        }

        private void telaDeLoad_Leave(object sender, EventArgs e)
        {
            
        }

        private void telaDeLoad_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void telaDeLoad_BackgroundImageChanged(object sender, EventArgs e)
        {
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void telaDeLoad_MouseHover(object sender, EventArgs e)
        {
            
            label1.Text = "Conectando ao banco";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            label1.Text = "Baixando dados";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            label1.Text = "Criptografando HD";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            label1.Text = "Carregando processos";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            label1.Text = "Roubando seus dados";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            label1.Text = "";
            label2.Text = "Seja Bem-Vindo";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            this.Opacity = 0.7;
            this.Refresh();
            System.Threading.Thread.Sleep(100);
            this.Opacity = 0.7;
            this.Refresh();
            System.Threading.Thread.Sleep(100);
            this.Opacity = 0.5;
            this.Refresh();
            System.Threading.Thread.Sleep(100);
            this.Opacity = 0.3;
            this.Refresh();
            System.Threading.Thread.Sleep(100);
            this.Opacity = 0.1;
            this.Refresh();
            this.Close();
        }
    }
}
