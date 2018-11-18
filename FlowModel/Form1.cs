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
    public partial class EditPanel : Form
    {
        private List<Desenho> figuras;
        private Bitmap bmpImagem;
        private Graphics grpImage;

        public EditPanel()
        {
            InitializeComponent();
        }

        private void EditPanel_Load(object sender, EventArgs e)
        {
            bmpImagem = new Bitmap(713, 599);
            pn_edit.BackgroundImage = bmpImagem;
            grpImage = Graphics.FromImage(bmpImagem);
            grpImage.Clear(Color.White);

            figuras = new List<Desenho>();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pn_edit_Click(object sender, EventArgs e)
        {
        
        }

        public Graphics getGraphics()
        {
            return this.grpImage;
        }
        public Bitmap getBmp()
        {
            return this.bmpImagem;
        }

        private void btn_entidade_Click(object sender, EventArgs e)
        {

        }

        private void btn_relacionamento_Click(object sender, EventArgs e)
        {

        }

        private void btn_padrao_Click(object sender, EventArgs e)
        {

        }

        private void btn_atributo_Click(object sender, EventArgs e)
        {

        }

        private void btn_heranca_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pn_edit_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pn_edit_MouseClick(object sender, MouseEventArgs e)
        {
            string value = "Entidade";
            if (InputBox("Nova Entidade", "Nome Entidade:", ref value) == DialogResult.OK)
            {
                figuras.Add(new Relacionamento(value, e.X, e.Y, 2));
                figuras[figuras.Count() - 1].SeDesenhe(grpImage, pn_edit);
                pn_edit.Refresh();
            }           
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
