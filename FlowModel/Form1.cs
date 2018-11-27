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
        private Desenho selecionado;

        private const int tamanhoX = 1015;
        private const int tamanhoY = 600;

        private int click;
        private bool BatterySaver, achou, arrastandoFigura, desenhandoRelacionamento, desenhandoEntidade, desenhandoEspecializacao, desenhandoPadronizacao, desenhandoAtributo;
        private int envolvidos;

        public EditPanel()
        {
            InitializeComponent();
        }

        private void EditPanel_Load(object sender, EventArgs e)
        {
            bmpImagem = new Bitmap(tamanhoX, tamanhoY);
            pn_edit.BackgroundImage = bmpImagem;

            grpImage = Graphics.FromImage(bmpImagem);
            grpImage.Clear(Color.White);

            figuras = new List<Desenho>();
            click = 0;
            envolvidos = 0;
            desenhandoRelacionamento = false;
            desenhandoEspecializacao = false;
            desenhandoPadronizacao = false;
            desenhandoEntidade = false;
            desenhandoAtributo = false;
            arrastandoFigura = false;
            BatterySaver = false;
            selecionado = null;
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

            this.selecionado.setName(NomeEntidade.Text);
            if (this.NomeEntidade.TextLength > 8)
            {
                grpImage.Clear(Color.White);
                foreach (Desenho d in figuras)
                    d.SeDesenhe(grpImage, pn_edit);
            }
            else
            {
                this.selecionado.SeDesenhe(grpImage, pn_edit);
            }
        }

        private void txtEntidadeX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEntidadeX.Text != "" && txtEntidadeX.Text != "-")
                {
                    Entidade mudada = (Entidade)this.selecionado;
                    mudada.setX(int.Parse(txtEntidadeX.Text));

                    foreach (Desenho d in figuras)
                    {
                        if (d.QuemSou() == "Atributo")
                        {
                            Atributo temQueMudar = (Atributo)d;
                            if (temQueMudar.getProprietario() == mudada)
                            {
                                temQueMudar.setX(int.Parse(txtEntidadeX.Text));
                            }
                        }
                    }
                    grpImage.Clear(Color.White);
                    foreach (Desenho d in figuras)
                        d.SeDesenhe(grpImage, pn_edit);
                }
            }
            catch (Exception)
            {
                txtEntidadeX.Text = this.selecionado.getX().ToString();
            }
        }

        private void txtEntidadeY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEntidadeX.Text != "" && txtEntidadeX.Text != "-")
                {
                    Entidade mudada = (Entidade)this.selecionado;
                    mudada.setY(int.Parse(txtEntidadeY.Text));

                    foreach (Desenho d in figuras)
                    {
                        if (d.QuemSou() == "Atributo")
                        {
                            Atributo temQueMudar = (Atributo)d;
                            if (temQueMudar.getProprietario() == mudada)
                            {
                                switch (temQueMudar.getTipo())
                                {
                                    case "Comum":
                                        temQueMudar.setY(int.Parse(txtEntidadeY.Text) + 50);
                                        break;
                                    default:
                                        temQueMudar.setY(int.Parse(txtEntidadeY.Text));
                                        break;
                                }

                            }
                        }
                    }
                    grpImage.Clear(Color.White);
                    foreach (Desenho d in figuras)
                        d.SeDesenhe(grpImage, pn_edit);
                }
            }
            catch (Exception)
            {
                txtEntidadeX.Text = this.selecionado.getX().ToString();
            }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atributo Aselecionado = (Atributo)this.selecionado;
            Aselecionado.setDado(cbTipoAtributo.SelectedIndex);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EditPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_entidade_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void EditPanel_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode.Equals(Keys.Back) || e.KeyCode.Equals(Keys.Delete)) && this.selecionado != null)
            {
                figuras.Remove(this.selecionado);
                grpImage.Clear(Color.White);

                foreach (Desenho d in figuras)
                {
                    d.SeDesenhe(this.grpImage, this.pn_edit);
                }
                this.pn_edit.Refresh();
                this.selecionado = null;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NomeAtributo_TextChanged(object sender, EventArgs e)
        {
            this.selecionado.setName(NomeAtributo.Text);
            grpImage.Clear(Color.White);
            foreach (Desenho figura in figuras)
            {
                figura.SeDesenhe(grpImage, pn_edit);
            }
        }

        private void cbDonoAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desenho novoDono = (Desenho)cbDonoAtributo.SelectedItem;
            Atributo Aselecionado = (Atributo) this.selecionado;
            Aselecionado.setProprietario(novoDono);

            if (Aselecionado.getTipo() == "Comum")
            {
                Aselecionado.setX(novoDono.getX());
                Aselecionado.setY(novoDono.getY() + 50);
            }
            else if (Aselecionado.getTipo() == "Opcional")
            {
                Aselecionado.setX(novoDono.getX() + 86);
                Aselecionado.setY(novoDono.getY() - 40);
            }
            else
            {
                Aselecionado.setX(novoDono.getX());
                Aselecionado.setY(novoDono.getY() - 40);
            }

            grpImage.Clear(Color.White);
            foreach (Desenho d in figuras)
                d.SeDesenhe(grpImage, pn_edit);
        }

        private void txtCardAtributoMin_TextChanged(object sender, EventArgs e)
        {
            Atributo Aselecionado = (Atributo) this.selecionado;
            switch (txtCardAtributoMin.Text)
            {
                case "0":
                    grpImage.Clear(Color.White);
                    switch (Aselecionado.getTipo())
                    {
                        case "Primario":
                            Aselecionado.PrimarioToComum();
                            Aselecionado.comumToOpcional();
                            Primario.Checked = false;
                            break;
                        case "Comum":
                            Aselecionado.comumToOpcional();
                            break;
                    }
                    Aselecionado.setCardMin(0);
                    foreach (Desenho f in figuras)
                        f.SeDesenhe(grpImage, pn_edit);
                    break;
                case "1":
                    grpImage.Clear(Color.White);
                    if (Aselecionado.getTipo() == "Opcional")
                    { 
                            Aselecionado.OpcionalToComum();
                    }
                    Aselecionado.setCardMin(1);
                    foreach (Desenho f in figuras)
                        f.SeDesenhe(grpImage, pn_edit);
                    break;
            }

        }

        private void txtCardAtributoMax_TextChanged(object sender, EventArgs e)
        {
            Atributo Aselecionado = (Atributo) this.selecionado;
            if (txtCardAtributoMax.Text.ToUpper().Equals("N"))
            {
                txtCardAtributoMax.Text = "N";
                if(Aselecionado.getPropriedade()[4] == 1)
                {
                    Aselecionado.setName(Aselecionado.getName() + " " + Aselecionado.getPropriedade()[3] + ", N");
                    Aselecionado.SeDesenhe(grpImage, pn_edit);
                    Aselecionado.setCardMax(2);
                }
            }
            if (txtCardAtributoMax.Text.Equals("1"))
            {
                if (Aselecionado.getPropriedade()[4] == 2)
                {
                    Aselecionado.setName(Aselecionado.getName().Split(' ')[0]);
                    grpImage.Clear(Color.White);
                    foreach(Desenho f in figuras)
                    {
                        f.SeDesenhe(grpImage, pn_edit);
                    }
                    Aselecionado.setCardMax(1);
                }
            }
        }

        private void Primario_CheckedChanged(object sender, EventArgs e)
        {
            Atributo Aselecionado = (Atributo) this.selecionado;
            if (Primario.Checked == true && Aselecionado.getPropriedade()[0] != 1)
            {
                txtCardAtributoMin.Text = "1";
                Aselecionado.comumToPrimario();
                grpImage.Clear(Color.White);
                foreach (Desenho g in figuras)
                    g.SeDesenhe(grpImage, pn_edit);
            }
            else
            {
                if(Aselecionado.getPropriedade()[0] == 1)
                {
                    Aselecionado.PrimarioToComum();
                    grpImage.Clear(Color.White);
                    foreach (Desenho g in figuras)
                        g.SeDesenhe(grpImage, pn_edit);
                }
            }
        }

        private void Derivado_CheckedChanged(object sender, EventArgs e)
        {
            Atributo Aselecionado = (Atributo)this.selecionado;

            if(Derivado.Checked == true)
            {
                cbDerivado.Visible = true;
                cbDerivado.Items.Clear();
                foreach (Desenho k in figuras)
                {
                    if (k.QuemSou() == "Atributo")
                    {
                        cbDerivado.Items.Add(k);
                    }
                    if (Aselecionado.getDerivado() == k)
                    {
                        cbDerivado.SelectedItem = k;
                    }
                }
            }
            else
            {
                cbDerivado.Visible = false;
            }
        }

        private void cbDerivado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atributo Aselecionado = (Atributo)this.selecionado;
            Aselecionado.setDerivado((Atributo)cbDerivado.SelectedItem);
        }

        private void pn_edit_MouseUp(object sender, MouseEventArgs e)
        {
            arrastandoFigura = false;
            if(BatterySaver)
            {
                grpImage.Clear(Color.White);
                foreach (Desenho d in figuras)
                    d.SeDesenhe(grpImage, pn_edit);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0)
            {
                /*
                btn_atributo.BackColor = Color.White;
                btn_entidade.BackColor = Color.White;
                btn_heranca.BackColor = Color.White;
                btn_padrao.BackColor = Color.White;
                btn_relacionamento.BackColor = Color.White;
                */
                BatterySaver = false;
                trackBar1.BackColor = Color.Snow;
                this.BackColor = Color.Snow;
            }
            else
            {
               
                BatterySaver = true;
                trackBar1.BackColor = Color.DarkGray;
                this.BackColor = Color.DarkGray;
            }
        }

        private void pn_edit_MouseDown(object sender, MouseEventArgs e)
        {
            foreach(Desenho d in figuras)
            {
                if (d.GetArea(e.X, e.Y))
                {
                    this.selecionado = d;
                    arrastandoFigura = true;
                }
                if(d.QuemSou().Equals("Relacionamento"))
                {
                    Relacionamento r = (Relacionamento)d;
                    foreach(Cardinalidade c in r.getCards())
                    {
                        if(c.GetArea(e.X, e.Y))
                        {
                            this.selecionado = c;
                            arrastandoFigura = true;
                            break;
                        }
                    }
                }
                if (arrastandoFigura)
                    break;
            }
                
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
            if (arrastandoFigura)
            {
                this.selecionado.setX(e.X);
                this.selecionado.setY(e.Y);
                
                if (!BatterySaver)
                {
                    grpImage.Clear(Color.White);
                    foreach (Desenho f in figuras)
                    {
                        f.SeDesenhe(grpImage, pn_edit);
                    }
                }
            }
        }

        private void pn_edit_MouseClick(object sender, MouseEventArgs e)
        {
            string value = "";
            BoxEntidade.Visible = false;
            BoxAtributo.Visible = false;
            BoxRelacionamento.Visible = false;
            if (!desenhandoAtributo && !desenhandoEntidade && !desenhandoEspecializacao && !desenhandoPadronizacao && !desenhandoRelacionamento)
            {
                
                for (int i = 0; i < figuras.Count; i++)
                {
                    if(figuras[i].GetArea(e.X, e.Y))
                    {
                        this.selecionado = figuras[i];
                        switch (figuras[i].QuemSou())
                        {
                            case "Entidade":
                                BoxEntidade.Visible = true;
                                NomeEntidade.Text = this.selecionado.getName();
                                txtEntidadeX.Text = this.selecionado.getX().ToString();
                                txtEntidadeY.Text = this.selecionado.getY().ToString();

                                break;
                            case "Relacionamento":

                                
                                break;
                            case "Atributo":
                                BoxAtributo.Visible = true;
                                Atributo Aselecionado = (Atributo)figuras[i];
                                NomeAtributo.Text = Aselecionado.getName();
                                cbDonoAtributo.Items.Clear();
                                int qual = 0;
                                foreach (Desenho g in figuras)
                                {
                                    if(g.QuemSou().Equals("Entidade") || g.QuemSou().Equals("Relacionamento"))
                                    {
                                        cbDonoAtributo.Items.Insert(qual, g);
                                        qual++;
                                        if(Aselecionado.getProprietario() == g)
                                        {
                                            cbDonoAtributo.SelectedItem = g;
                                        }
                                    }
                                }
                                Dados dadoDoAtributo = Aselecionado.getDados();
                                cbTipoAtributo.Items.Clear();
                                foreach (KeyValuePair<int, string> itemDado in dadoDoAtributo.getDados())
                                {                                    
                                    cbTipoAtributo.Items.Insert(itemDado.Key, itemDado.Value);
                                    if(itemDado.Value.Equals(Aselecionado.getDados().getDado()))
                                    {
                                        cbTipoAtributo.SelectedIndex = itemDado.Key;
                                    }
                                }
                                List<int> tipoA = Aselecionado.getPropriedade();
                                if (tipoA[0] == 1)
                                    Primario.Checked = true;
                                else
                                    Primario.Checked = false;

                                if (tipoA[1] == 1)
                                    Composto.Checked = true;
                                else
                                    Composto.Checked = false;

                                if (tipoA[2] == 1)
                                {
                                    Derivado.Checked = true;
                                    cbDerivado.Visible = true;
                                    cbDerivado.Items.Clear();
                                    foreach (Desenho k in figuras)
                                    {
                                        if (k.QuemSou() == "Atributo")
                                        {
                                            cbDerivado.Items.Add(k);
                                        }
                                        if (Aselecionado.getDerivado() == k)
                                        {
                                            cbDerivado.SelectedItem = k;
                                        }
                                    }
                                }
                                else
                                {
                                    Derivado.Checked = false;
                                    cbDerivado.Visible = false;
                                }

                                txtCardAtributoMin.Text = tipoA[3].ToString();

                                string str;
                                if(tipoA[4] == 2)
                                {
                                    str = "n";
                                }
                                else
                                {
                                    str = "1";
                                }

                                txtCardAtributoMax.Text = str;
                                break;
                        }
                    }
                }
            }

            if(desenhandoAtributo)
            {
                for (int i = figuras.Count - 1; i >= 0; i--)
                {
                    string str = figuras[i].QuemSou();
                    if ((str.Equals("Entidade") || str.Equals("Relacionamento")) && figuras[i].GetArea(e.X, e.Y) == true)
                    {
                        value = "Atributo";
                        if (InputBox("Novo Atributo", "Nome Atributo:", ref value) == DialogResult.OK)
                        { 
                            figuras.Add(new Atributo(value, figuras[i].getX(), figuras[i].getY() + 50, figuras[i]));
                            figuras.Last().SeDesenhe(grpImage, pn_edit);
                            desenhandoAtributo = false;
                            this.textBox1.Focus();
                            break;
                        }
                    }
                    if ((str.Equals("Atributo")) && figuras[i].GetArea(e.X, e.Y) == true)
                    {
                        value = "Atributo Composto";
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
                            this.textBox1.Focus();;
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
                        this.textBox1.Focus();;
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
                        this.textBox1.Focus();;
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
                this.textBox1.Focus();;
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
                                    this.textBox1.Focus();;
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
                                this.textBox1.Focus();;
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
