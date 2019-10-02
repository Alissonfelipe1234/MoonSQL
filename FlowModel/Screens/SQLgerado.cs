using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FlowModel
{
    public partial class SQLgerado : Form
    {
        private Form telaAnterior;

        public SQLgerado(string sql, Form f)
        {
            InitializeComponent();
            telaAnterior = f;
            progressBar1.Value = 10;
            this.Refresh();
            System.Threading.Thread.Sleep(500);
            progressBar1.Value = 40;
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 80;
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 100;
            Resultado.Text = sql;
            this.Refresh();
        }

        private void SQLgerado_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaAnterior.Show();
            telaAnterior.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process pgsql = new Process();
            pgsql.StartInfo.FileName = @"C:\Program Files\PostgreSQL\11\pgAdmin 4\bin\pgAdmin4.exe";
            pgsql.Start();
        }
    }
}
