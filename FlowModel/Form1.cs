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

        private int click;
        private bool achou, desenhandoRelacionamento, desenhandoEntidade, desenhandoEspecializacao, desenhandoPadronizacao, desenhandoAtributo;
        private int envolvidos;

        public EditPanel()
        {
            InitializeComponent();
        }

        private void EditPanel_Load(object sender, EventArgs e)
        {
            bmpImagem = new Bitmap(1015, 600);
            pn_edit.BackgroundImage = bmpImagem;

            grpImage = Graphics.FromImage(bmpImagem);
            grpImage.Clear(Color.WhiteSmoke);

            figuras = new List<Desenho>();
            click = 0;
            envolvidos = 0;
            desenhandoRelacionamento = false;
            desenhandoEspecializacao = false;
            desenhandoPadronizacao = false;
            desenhandoEntidade = false;
            desenhandoAtributo = false;
            /*
            figuras.Add(new Entidade("TESTE1", 70, 70));
            figuras[0].SeDesenhe(grpImage, pn_edit);

            figuras.Add(new Entidade("TESTE2", 370, 70));
            figuras[1].SeDesenhe(grpImage, pn_edit);
            */
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
            desenhandoEntidade = true;
            desenhandoRelacionamento = false;
            desenhandoPadronizacao = false;
            desenhandoEspecializacao = false;
            desenhandoAtributo = false;
        }

        private void btn_relacionamento_Click(object sender, EventArgs e)
        {
            desenhandoEntidade = false;
            desenhandoRelacionamento = true;
            desenhandoEspecializacao = false;
            desenhandoPadronizacao = false;
            desenhandoAtributo = false;
        }

        private void btn_padrao_Click(object sender, EventArgs e)
        {
            desenhandoPadronizacao = true;
            desenhandoEntidade = false;
            desenhandoRelacionamento = false;
            desenhandoEspecializacao = false;
            desenhandoAtributo = false;
        }

        private void btn_atributo_Click(object sender, EventArgs e)
        {
            desenhandoEspecializacao = false;
            desenhandoRelacionamento = false;
            desenhandoEntidade = false;
            desenhandoPadronizacao = false;
            desenhandoAtributo = true; 
        }

        private void btn_heranca_Click(object sender, EventArgs e)
        {
            desenhandoEspecializacao = true;
            desenhandoRelacionamento = false;
            desenhandoEntidade = false;
            desenhandoPadronizacao = false;
            desenhandoAtributo = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gerarSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlGerado = "";
            int tables = 0;
            List<string> sql = new List<string>();
            foreach (Desenho d in figuras)
            {
                if(d.QuemSou() == "Entidade")
                {
                    
                    Entidade ent = (Entidade)d;
                    sql.Add("Create Table " + ent.getName() + " {\n");
                    foreach (Desenho a in figuras)
                    {
                        if (a.QuemSou() == "Atributo")
                        {
                            Atributo atributo = (Atributo)a;
                            if(atributo.getProprietario() == d)
                            {
                                sql[tables] += atributo.getSql();
                                if (atributo.getIndice() + 1 != ent.getQtdAtributos())
                                    sql[tables] += ",\n";                                    
                            }
                        }
                    }
                    sql[tables] += "\n};\n\n";
                    tables++;
                }
            }
            for (int i = 0; i < sql.Count; i++)
                sqlGerado += sql[i];
        }

        private void NomeEntidade_TextChanged(object sender, EventArgs e)
        {
            //Alterar nome entidade
        }

        private void txtEntidadeX_TextChanged(object sender, EventArgs e)
        {
            //Altera X da entidade
        }

        private void txtEntidadeY_TextChanged(object sender, EventArgs e)
        {
            //Altera Y entidade
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Atributo tipo altera
        }

        private void label7_Click(object sender, EventArgs e)
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
            Info.Text = e.X + "," + e.Y;
        }

        private void pn_edit_MouseClick(object sender, MouseEventArgs e)
        {
            string value = "";

            if(!desenhandoAtributo && !desenhandoEntidade && !desenhandoEspecializacao && !desenhandoPadronizacao && !desenhandoRelacionamento)


            if(desenhandoAtributo)
            {
                for (int i = figuras.Count - 1; i >= 0; i--)
                {
                    string str = figuras[i].QuemSou();
                    if ((str.Equals("Entidade") || str.Equals("Relacionamento")) && figuras[i].GetArea(e.X, e.Y) == true)
                    {
                        if (InputBox("Novo Atributo", "Nome Atributo:", ref value) == DialogResult.OK)
                        { 
                            figuras.Add(new Atributo(value, figuras[i].getX(), figuras[i].getY() + 50, figuras[i]));
                            figuras.Last().SeDesenhe(grpImage, pn_edit);
                            desenhandoAtributo = false;
                            break;
                        }
                    }
                    if ((str.Equals("Atributo")) && figuras[i].GetArea(e.X, e.Y) == true)
                    {
                        
                        if (InputBox("Novo Atributo", "Nome Atributo:", ref value) == DialogResult.OK)
                        {
                            Atributo at = (Atributo)figuras[i];
                            int cordXAtributo = at.getX();
                            int cordYAtributo = at.getY();
                            if (at.getTipo() == "Comum")
                            {
                                cordXAtributo += 18 + at.getTam();
                                cordYAtributo += 28 + (at.getIndice() * 14);
                            }
                            else if (at.getTipo() == "Primario")
                            {
                                cordXAtributo += 18 + at.getTam();
                                cordYAtributo += 12 - (at.getIndice() * 14);
                            }

                            figuras.Add(new Atributo(value, cordXAtributo, cordYAtributo, figuras[i]));
                            figuras.Last().SeDesenhe(grpImage, pn_edit);
                            desenhandoAtributo = false;
                            break;
                        }
                    }
                }
            }
            if (desenhandoPadronizacao)
            {
                click++;
                this.achou = false;
                if (click == 1)
                {
                    this.achou = false;
                    value = "Generalização";
                    string d = "2";
                    if (InputBox("Nova Generalização", "Nome Generalização:", ref value) == DialogResult.OK)
                    {
                        InputBox("Numero", "Quantidade de Entidades envolvidas:", ref d);
                        this.envolvidos = int.Parse(d);
                        figuras.Add(new Padronizacao(value, e.X, e.Y));
                    }
                    else
                    {
                        click--;
                    }
                }
                else if (click == 2)
                {
                    for (int i = 0; i < (figuras.Count) - 1; i++)
                    {
                        if (figuras[i].QuemSou() == "Entidade" && figuras[i].GetArea(e.X, e.Y) == true)
                        {
                            Padronizacao spec = (Padronizacao)figuras[figuras.Count - 1];
                            spec.setPadrao((Entidade)figuras[i]);
                            achou = true;
                            break;
                        }
                    }
                    if (!achou)
                        click--;
                }
                else
                {
                    for (int i = 0; i < (figuras.Count) - 1; i++)
                    {
                        if (figuras[i].QuemSou() == "Entidade" && figuras[i].GetArea(e.X, e.Y) == true)
                        {
                            Padronizacao spec = (Padronizacao)figuras[figuras.Count - 1];
                            spec.addEntidade((Entidade)figuras[i]);
                            envolvidos--;
                            break;
                        }
                    }
                    if (envolvidos == 0)
                    {
                        figuras.Last().SeDesenhe(grpImage, pn_edit);
                        desenhandoPadronizacao = false;
                        click = 0;
                    }
                }


            }
            if (desenhandoEspecializacao)
            {
                click++;
                this.achou = false;
                if (click == 1)
                {
                    this.achou = false;
                    value = "Especialização";
                    string d = "2";
                    if (InputBox("Nova Especialização", "Nome Especialização:", ref value) == DialogResult.OK)
                    {
                        InputBox("Numero", "Quantidade de Entidades envolvidas:", ref d);
                        this.envolvidos = int.Parse(d);
                        figuras.Add(new Especializacao(value, e.X, e.Y));
                    }
                    else
                    {
                        click--;
                    }
                }
                else if (click == 2)
                {
                    for (int i = 0; i < (figuras.Count) - 1; i++)
                    {
                        if (figuras[i].QuemSou() == "Entidade" && figuras[i].GetArea(e.X, e.Y) == true)
                        {
                            Especializacao spec = (Especializacao)figuras[figuras.Count - 1];
                            spec.setEntidadeEspecializada((Entidade)figuras[i]);
                            achou = true;
                            break;
                        }
                    }
                    if (!achou)
                        click--;
                }
                else
                {
                    for (int i = 0; i < (figuras.Count) - 1; i++)
                    {
                        if (figuras[i].QuemSou() == "Entidade" && figuras[i].GetArea(e.X, e.Y) == true)
                        {
                            Especializacao spec = (Especializacao)figuras[figuras.Count - 1];
                            spec.addEntidades((Entidade)figuras[i]);
                            envolvidos--;
                            break;
                        }
                    }
                    if (envolvidos == 0)
                    {                        
                        figuras.Last().SeDesenhe(grpImage, pn_edit);
                        desenhandoEspecializacao = false;
                        click = 0;
                    }
                }


            }
            if (desenhandoEntidade)
            {
                value = "Entidade";
                if (InputBox("Nova Entidade", "Nome Entidade:", ref value) == DialogResult.OK)
                {
                    figuras.Add(new Entidade(value, e.X, e.Y));
                    figuras[figuras.Count-1].SeDesenhe(grpImage, pn_edit);
                }
                desenhandoEntidade = false;
            }
            if (desenhandoRelacionamento)
            {
                click++;
                this.achou = false;
                switch (click)
                {
                    case 1:
                        value = "Relacionamento";
                        string d = "2";
                        if (InputBox("Novo Relacionamento", "Nome Relacionamento:", ref value) == DialogResult.OK)
                        {
                            InputBox("Numero de 2 a 3", "Quantidade de Entidades envolvidas (2 ou 3):", ref d);
                            figuras.Add(new Relacionamento(value, e.X, e.Y, Convert.ToInt16(d)));
                        }
                        else
                        {
                            click--;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < (figuras.Count) - 1; i++)
                        {
                            if (figuras[i].QuemSou() == "Entidade" && figuras[i].GetArea(e.X, e.Y) == true)
                            {
                                Relacionamento r = (Relacionamento)figuras[figuras.Count - 1];
                                r.relacionarEntidade((Entidade)figuras[i]);
                                /// CRIA CARDINALIDADE
                                string cad = "1,1";
                                InputBox("Cardinalidade", "Cardinalidade", ref cad);
                                Cardinalidade c = new Cardinalidade(figuras[i].getX(), figuras[i].getY() + 55);
                                string[] t = cad.Split(',');
                                c.setCardMin(t[0]);
                                c.setCardMax(t[1]);
                                //////// FINALIZA
                                r.adicionarCardinalidade(c);
                                achou = true;
                                break;
                            }
                        }
                        if (!achou)
                            click--;
                        break;
                    case 3:
                        for (int i = 0; i < figuras.Count; i++)
                        {
                            if (figuras[i].QuemSou() == "Entidade" && figuras[i].GetArea(e.X, e.Y) == true)
                            {
                                Relacionamento r = (Relacionamento)figuras[figuras.Count - 1];
                                r.relacionarEntidade((Entidade)figuras[i]);
                                /// CRIA CARDINALIDADE
                                string cad = "1,1";
                                InputBox("Cardinalidade", "Cardinalidade", ref cad);
                                Cardinalidade c = new Cardinalidade(figuras[i].getX(), figuras[i].getY() + 55);
                                string[] t = cad.Split(',');
                                c.setCardMin(t[0]);
                                c.setCardMax(t[1]);
                                //////// FINALIZA
                                r.adicionarCardinalidade(c);
                                if (r.getQtdEnvolvidos() == 2)
                                {
                                    r.SeDesenhe(grpImage, pn_edit);                                    
                                    desenhandoRelacionamento = false;
                                    click = 0;
                                }
                                achou = true;
                                break;
                            }
                        }
                        if (!achou)
                            click--;
                        break;
                    case 4:
                        for (int i = 0; i < figuras.Count; i++)
                        {
                            if (figuras[i].QuemSou() == "Entidade" && figuras[i].GetArea(e.X, e.Y) == true)
                            {
                                Relacionamento r = (Relacionamento)figuras[figuras.Count - 1];
                                r.relacionarEntidade((Entidade)figuras[i]);
                                /// CRIA CARDINALIDADE
                                string cad = "1,1";
                                InputBox("Cardinalidade", "Cardinalidade", ref cad);
                                Cardinalidade c = new Cardinalidade(figuras[i].getX(), figuras[i].getY() + 55);
                                string[] t = cad.Split(',');
                                c.setCardMin(t[0]);
                                c.setCardMax(t[1]);
                                //////// FINALIZA
                                r.adicionarCardinalidade(c);
                                r.SeDesenhe(grpImage, pn_edit);                                
                                desenhandoRelacionamento = false;
                                click = 0;

                                achou = true;
                                break;
                            }
                        }
                        if (!achou)
                            click--;
                        break;
                }
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
