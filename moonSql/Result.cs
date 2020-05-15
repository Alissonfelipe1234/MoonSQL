using moonSql.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
