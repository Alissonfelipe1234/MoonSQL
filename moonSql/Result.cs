using System.Windows.Forms;

namespace moonSql
{
    public partial class Result : Form
    {
        private Form prev;
        public Result(string SQL, Form prev)
        {
            this.prev = prev;
            InitializeComponent();
            sql.Text = SQL;
        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            prev.Show();
            prev.Visible = true;
        }

        private void sql_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
