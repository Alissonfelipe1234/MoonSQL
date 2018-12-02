using Npgsql;
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
        

        private void NomeEntidade_TextChanged(object sender, EventArgs e)
        {

            this.selecionado.setName(NomeEntidade.Text);
            if (this.NomeEntidade.TextLength > 8)
            {
                grpImage.Clear(Color.White);
                foreach (Desenho d in figuras)
                    d.SeDesenhe(grpImage);
                pn_edit.Refresh();
            }
            else
            {
                this.selecionado.SeDesenhe(grpImage);
                pn_edit.Refresh();
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
                        d.SeDesenhe(grpImage);
                    pn_edit.Refresh();
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
                        d.SeDesenhe(grpImage);
                    pn_edit.Refresh();
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode.Equals(Keys.Back) || e.KeyCode.Equals(Keys.Delete)) && this.selecionado != null)
            {
                figuras.Remove(this.selecionado);
                grpImage.Clear(Color.White);

                foreach (Desenho d in figuras)
                {
                    d.SeDesenhe(this.grpImage);
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
                figura.SeDesenhe(grpImage);
            }
            pn_edit.Refresh();
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
                d.SeDesenhe(grpImage);
            pn_edit.Refresh();
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
                        f.SeDesenhe(grpImage);
                    pn_edit.Refresh();
                    break;
                case "1":
                    grpImage.Clear(Color.White);
                    if (Aselecionado.getTipo() == "Opcional")
                    { 
                            Aselecionado.OpcionalToComum();
                    }
                    Aselecionado.setCardMin(1);
                    foreach (Desenho f in figuras)
                        f.SeDesenhe(grpImage);
                    pn_edit.Refresh();
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
                    Aselecionado.SeDesenhe(grpImage);
                    pn_edit.Refresh();
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
                        f.SeDesenhe(grpImage);
                        pn_edit.Refresh();
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
                    g.SeDesenhe(grpImage);
                pn_edit.Refresh();
            }
            else
            {
                if(Aselecionado.getPropriedade()[0] == 1)
                {
                    Aselecionado.PrimarioToComum();
                    grpImage.Clear(Color.White);
                    foreach (Desenho g in figuras)
                        g.SeDesenhe(grpImage);
                    pn_edit.Refresh();
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
                    d.SeDesenhe(grpImage);
                pn_edit.Refresh();
            }
        }

        private void NomeRelacionamento_TextChanged(object sender, EventArgs e)
        {
            this.selecionado.setName(NomeRelacionamento.Text);
            grpImage.Clear(Color.White);
            foreach (Desenho f in figuras)
                f.SeDesenhe(grpImage);
            pn_edit.Refresh();
        }

        private void RelacionamentoX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (RelacionamentoX.Text != "" && RelacionamentoX.Text != "-")
                {
                    this.selecionado.setX(int.Parse(RelacionamentoX.Text));
                    grpImage.Clear(Color.White);
                    foreach (Desenho d in figuras)
                        d.SeDesenhe(grpImage);
                    pn_edit.Refresh();
                }
            }
            catch (Exception)
            {
                RelacionamentoX.Text = this.selecionado.getX().ToString();
            }
        }

        private void RelacionamentoY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (RelacionamentoY.Text != "" && RelacionamentoY.Text != "-")
                {
                    this.selecionado.setY(int.Parse(RelacionamentoY.Text));
                    grpImage.Clear(Color.White);
                    foreach (Desenho d in figuras)
                        d.SeDesenhe(grpImage);
                    pn_edit.Refresh();
                }
            }
            catch (Exception)
            {
                RelacionamentoY.Text = this.selecionado.getX().ToString();
            }
        }

        private void EntidadeDono1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Entidade ex = (Entidade)EntidadeDono1.SelectedItem;
            Relacionamento rel = (Relacionamento)this.selecionado;
            rel.getCards()[0].setX(ex.getX());
            rel.getCards()[0].setY(ex.getY()+50);

            rel.setEntidade(0, ex);
            foreach (Desenho d in figuras)
                d.SeDesenhe(grpImage);
            pn_edit.Refresh();
        }

        private void EntidadeDono2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidade ex = (Entidade)EntidadeDono1.SelectedItem;
            Relacionamento rel = (Relacionamento)this.selecionado;
            rel.getCards()[1].setX(ex.getX());
            rel.getCards()[1].setY(ex.getY() + 50);

            rel.setEntidade(1, ex);
            foreach (Desenho d in figuras)
                d.SeDesenhe(grpImage);
            pn_edit.Refresh();
        }

        private void EntidadeDono3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidade ex = (Entidade)EntidadeDono1.SelectedItem;
            Relacionamento rel = (Relacionamento)this.selecionado;
            rel.getCards()[2].setX(ex.getX());
            rel.getCards()[2].setY(ex.getY() + 50);

            rel.setEntidade(2, ex);
            grpImage.Clear(Color.White);
            foreach (Desenho d in figuras)
                d.SeDesenhe(grpImage);
            pn_edit.Refresh();
        }

        private void gerador_Click(object sender, EventArgs e)
        {
            string sqlGerado = "";
            Dictionary<Entidade, string> sql = new Dictionary<Entidade, string>();
            Dictionary<Desenho, string> tablesAltenative = new Dictionary<Desenho, string>();
            Dictionary<Entidade, Atributo> PK = new Dictionary<Entidade, Atributo>();
            foreach (Desenho d in figuras)
            {
                if (d.QuemSou() == "Entidade")
                {

                    Entidade ent = (Entidade)d;
                    sql.Add(ent, "Create Table " + ent.getName() + " (\n");
                }
            }
            foreach (Desenho a in figuras)
            {
                if (a.QuemSou() == "Atributo")
                {
                    Atributo atributo = (Atributo)a;
                    if (atributo.getProprietario().QuemSou() == "Entidade")
                    {
                        if (atributo.getPropriedade()[0] == 1)
                        {
                            try
                            {
                                PK.Add((Entidade)atributo.getProprietario(), atributo);
                            }
                            catch { }
                        }
                        if (atributo.getCardMax() == 1)
                        {
                            Entidade EntidadeAtributo = (Entidade)atributo.getProprietario();
                            sql[EntidadeAtributo] += atributo.getSql();
                            if (atributo.getIndice() + 1 != EntidadeAtributo.getQtdAtributos())
                                sql[EntidadeAtributo] += ",\n";
                        }
                        else
                        {
                            Entidade EntidadeAtributoMValorado = (Entidade)atributo.getProprietario();
                            string nome = atributo.getName().Split(' ')[0];
                            sql[EntidadeAtributoMValorado] += nome + "FK integer";
                            if (atributo.getCardMin() != 0)
                                sql[EntidadeAtributoMValorado] += " NOT NULL";
                            if (atributo.getIndice() + 1 != EntidadeAtributoMValorado.getQtdAtributos())
                                sql[EntidadeAtributoMValorado] += ",\n";

                            tablesAltenative.Add(atributo, "Create Table " + nome + " (\n");
                            tablesAltenative[atributo] += "ID" + nome + " serial Primary Key,\n";
                            tablesAltenative[atributo] += atributo.getSql() + ",\n";
                            tablesAltenative[atributo] += EntidadeAtributoMValorado.getName() + "FK integer,\n";
                            tablesAltenative[atributo] += "CONSTRAINT " + nome + "_" + EntidadeAtributoMValorado.getName() + " FOREIGN KEY(FK" + EntidadeAtributoMValorado.getName() + ")\n";
                            tablesAltenative[atributo] += "REFERENCES " + EntidadeAtributoMValorado.getName() + "(" + nome + "FK)\n)";
                            tablesAltenative[atributo] += ");";
                        }
                    }
                }
            }
            foreach (Desenho a in figuras)
            {
                if (a.QuemSou() == "Relacionamento")
                {
                    Relacionamento relacionamento = (Relacionamento)a;
                    int envolvidos = relacionamento.getQtdEnvolvidos();
                    switch (envolvidos)
                    {
                        case 1:
                            Entidade dono = relacionamento.getEnvolvidos()[0];
                            if (PK.ContainsKey(dono))
                            {
                                if (dono.getQtdAtributos() > 0)
                                    sql[dono] += ",\n" + dono.getName() + "ID Integer PRIMARY KEY";
                                else
                                    sql[dono] += dono.getName() + "ID Integer PRIMARY KEY";
                            }

                            sql[dono] += ",\n" + relacionamento.getName();
                            if (relacionamento.getCards()[0].getCardMin().Equals("1"))
                                sql[dono] += " NOT NULL";
                            try { sql[dono] += " FOREIGN KEY REFERENCES " + dono.getName() + "(" + PK[dono].getName() + ")"; }
                            catch { sql[dono] += " FOREIGN KEY REFERENCES " + dono.getName() + "(" + dono.getName() + "ID  )"; }
                            break;
                        case 2:
                            Entidade dono1 = relacionamento.getEnvolvidos()[0];
                            Entidade dono2 = relacionamento.getEnvolvidos()[1];
                            Cardinalidade card1 = relacionamento.getCards()[0];
                            Cardinalidade card2 = relacionamento.getCards()[1];
                            if (card1.getCardMax().Equals("1") && card2.getCardMax().Equals("1"))
                            {
                                if (card1.getCardMin().Equals("1"))
                                {
                                    if (dono1.getQtdAtributos() > 0)
                                        sql[dono1] += ",\n" + dono2.getName() + " Integer";
                                    else
                                        sql[dono1] += dono2.getName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono1] += " NOT NULL";
                                    try { sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.getName() + "(" + PK[dono2].getName() + ")"; }
                                    catch
                                    {
                                        sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.getName() + "(" + dono2.getName() + "ID  )";
                                        if (dono2.getQtdAtributos() > 0)
                                            sql[dono2] += ",\n" + dono2.getName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono2] += dono2.getName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono1] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.getProprietario() == relacionamento)
                                                {
                                                    sql[dono1] += possivel.getSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono1] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (dono2.getQtdAtributos() > 0)
                                        sql[dono2] += ",\n" + dono1.getName() + " Integer";
                                    else
                                        sql[dono2] += dono1.getName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono2] += " NOT NULL";
                                    try { sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.getName() + "(" + PK[dono1].getName() + ")"; }
                                    catch
                                    {
                                        sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.getName() + "(" + dono1.getName() + "ID  )";
                                        if (dono1.getQtdAtributos() > 0)
                                            sql[dono1] += ",\n" + dono1.getName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono1] += dono1.getName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono2] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.getProprietario() == relacionamento)
                                                {
                                                    sql[dono2] += possivel.getSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono2] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }

                                }
                            }
                            else if (!card1.getCardMax().Equals(card2.getCardMax()))
                            {
                                if (card1.getCardMax().Equals("N"))
                                {
                                    sql[dono1] += ",\n" + dono2.getName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono1] += " NOT NULL";
                                    try { sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.getName() + "(" + PK[dono2].getName() + ")"; }
                                    catch
                                    {

                                        sql[dono1] += " FOREIGN KEY REFERENCES " + dono2.getName() + "(" + dono2.getName() + "ID  )";
                                        if (dono2.getQtdAtributos() > 0)
                                            sql[dono2] += ",\n" + dono2.getName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono2] += dono2.getName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono1] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.getProprietario() == relacionamento)
                                                {
                                                    sql[dono1] += possivel.getSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono1] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    sql[dono2] += ",\n" + dono1.getName() + " Integer";
                                    if (card2.getCardMin().Equals("1"))
                                        sql[dono2] += " NOT NULL";
                                    try { sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.getName() + "(" + PK[dono1].getName() + ")"; }
                                    catch
                                    {
                                        sql[dono2] += " FOREIGN KEY REFERENCES " + dono1.getName() + "(" + dono1.getName() + "ID  )";
                                        if (dono1.getQtdAtributos() > 0)
                                            sql[dono1] += ",\n" + dono1.getName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[dono1] += dono1.getName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        sql[dono2] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.getProprietario() == relacionamento)
                                                {
                                                    sql[dono2] += possivel.getSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[dono2] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                tablesAltenative.Add(relacionamento, "Create Table " + relacionamento.getName() + " (\n");
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[dono1].getSql() + ",\n";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += dono1.getName() + "ID  integer,\n";
                                    PK.Add(dono1, new Atributo(dono1.getName() + "ID", -50, -50, (Desenho)dono1));
                                    if (dono1.getQtdAtributos() > 0)
                                        sql[dono1] += ",\n" + dono1.getName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[dono1] += dono1.getName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[dono2].getSql();
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += dono2.getName() + "ID  integer";
                                    PK.Add(dono2, new Atributo(dono2.getName() + "ID", -50, -50, (Desenho)dono2));
                                    if (dono1.getQtdAtributos() > 0)
                                        sql[dono2] += ",\n" + dono2.getName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[dono2] += dono2.getName() + "ID Integer PRIMARY KEY";
                                }
                                int atr = relacionamento.getQtdAtributos();
                                if (atr > 0)
                                {
                                    foreach (Desenho f in figuras)
                                    {

                                        if (f.QuemSou().Equals("Atributo"))
                                        {
                                            Atributo possivel = (Atributo)f;
                                            if (possivel.getProprietario() == relacionamento)
                                            {
                                                tablesAltenative[relacionamento] += ",\n";
                                                tablesAltenative[relacionamento] += possivel.getSql();
                                                atr--;
                                                if (atr > 0)
                                                    tablesAltenative[relacionamento] += ",\n";
                                                else
                                                    break;

                                            }
                                        }
                                    }
                                }
                                tablesAltenative[relacionamento] += ",\nPRIMARY KEY (" + PK[dono1].getName() + ", " + PK[dono2].getName() + "),\n";
                                tablesAltenative[relacionamento] += "CONTRAINT " + relacionamento.getName() + "FK1 FOREIGN KEY (" + PK[dono1].getName() + ")\n";
                                tablesAltenative[relacionamento] += "REFERENCES " + dono1.getName() + " (" + PK[dono1].getName() + "),\n";
                                tablesAltenative[relacionamento] += "CONTRAINT " + relacionamento.getName() + "FK2 FOREIGN KEY (" + PK[dono2].getName() + ")\n";
                                tablesAltenative[relacionamento] += "REFERENCES " + dono2.getName() + " (" + PK[dono2].getName() + ")";
                            }
                            break;
                        case 3:
                            Entidade tern1 = relacionamento.getEnvolvidos()[0];
                            Entidade tern2 = relacionamento.getEnvolvidos()[1];
                            Entidade tern3 = relacionamento.getEnvolvidos()[2];
                            Cardinalidade carT1 = relacionamento.getCards()[0];
                            Cardinalidade carT2 = relacionamento.getCards()[1];
                            Cardinalidade carT3 = relacionamento.getCards()[2];
                            //caso 1:1:1 OR N:N:N
                            if (carT1.getCardMax() == carT2.getCardMax() && carT1.getCardMax() == carT3.getCardMax())
                            {
                                tablesAltenative.Add(relacionamento, "Create Table " + relacionamento.getName() + " (\n");
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[tern1].getSql() + " FOREIGN KEY REFERENCES " + tern1.getName() +
                                        "(" + PK[tern1].getName() + "),\n";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += tern1.getName() + "ID  integer PRIMARY KEY FOREIGN " + tern1.getName() +
                                        "(" + tern1.getName() + "ID),\n";
                                    PK.Add(tern1, new Atributo(tern1.getName() + "ID", -50, -50, (Desenho)tern1));
                                    if (tern1.getQtdAtributos() > 0)
                                        sql[tern1] += ",\n" + tern1.getName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[tern1] += tern1.getName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[tern2].getSql() + " FOREIGN KEY REFERENCES " + tern2.getName() +
                                        "(" + PK[tern2].getName() + "),\n";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += tern2.getName() + "ID  integer PRIMARY KEY FOREIGN " + tern2.getName() +
                                        "(" + tern2.getName() + "ID),\n";
                                    PK.Add(tern2, new Atributo(tern2.getName() + "ID", -50, -50, (Desenho)tern2));
                                    if (tern2.getQtdAtributos() > 0)
                                        sql[tern2] += ",\n" + tern2.getName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[tern2] += tern2.getName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relacionamento] += PK[tern3].getSql() + " FOREIGN KEY REFERENCES " + tern3.getName() +
                                        "(" + PK[tern3].getName() + ")";
                                }
                                catch
                                {
                                    tablesAltenative[relacionamento] += tern3.getName() + "ID  integer PRIMARY KEY FOREIGN " + tern3.getName() +
                                        "(" + tern3.getName() + "ID)";
                                    PK.Add(tern3, new Atributo(tern3.getName() + "ID", -50, -50, (Desenho)tern3));
                                    sql[tern3] += ",\n" + tern3.getName() + "ID Integer PRIMARY KEY";
                                }
                                int atr = relacionamento.getQtdAtributos();
                                if (atr > 0)
                                {
                                    tablesAltenative[relacionamento] += ",\n";
                                    foreach (Desenho f in figuras)
                                    {
                                        if (f.QuemSou().Equals("Atributo"))
                                        {
                                            Atributo possivel = (Atributo)f;
                                            if (possivel.getProprietario() == relacionamento)
                                            {
                                                tablesAltenative[relacionamento] += possivel.getSql();
                                                atr--;
                                                if (atr > 0)
                                                    tablesAltenative[relacionamento] += ",\n";
                                                else
                                                    break;

                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                int qtdN = 0;
                                if (carT1.getCardMax() == "N")
                                    qtdN++;
                                if (carT2.getCardMax() == "N")
                                    qtdN++;
                                if (carT3.getCardMax() == "N")
                                    qtdN++;
                                if (qtdN == 2)
                                {
                                    tablesAltenative.Add(relacionamento, "Create Table " + relacionamento.getName() + " (\n");
                                    try
                                    {
                                        tablesAltenative[relacionamento] += PK[tern1].getName() + " " + PK[tern1].getIdDado();
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN KEY REFERENCES " + tern1.getName() +
                                            "(" + PK[tern1].getName() + "),\n";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relacionamento] += tern1.getName() + "ID  integer";
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN " + tern1.getName() +
                                            "(" + tern1.getName() + "ID),\n";
                                        PK.Add(tern1, new Atributo(tern1.getName() + "ID", -50, -50, (Desenho)tern1));
                                        if (tern1.getQtdAtributos() > 0)
                                            sql[tern1] += ",\n" + tern1.getName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern1] += tern1.getName() + "ID Integer PRIMARY KEY";
                                    }
                                    try
                                    {
                                        tablesAltenative[relacionamento] += PK[tern2].getName() + " " + PK[tern2].getIdDado();
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN KEY REFERENCES " + tern2.getName() +
                                            "(" + PK[tern2].getName() + "),\n";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relacionamento] += tern2.getName() + "ID  integer";
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN " + tern2.getName() +
                                            "(" + tern2.getName() + "ID),\n";
                                        PK.Add(tern2, new Atributo(tern2.getName() + "ID", -50, -50, (Desenho)tern2));
                                        if (tern2.getQtdAtributos() > 0)
                                            sql[tern2] += ",\n" + tern2.getName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern2] += tern2.getName() + "ID Integer PRIMARY KEY";
                                    }
                                    try
                                    {
                                        tablesAltenative[relacionamento] += PK[tern3].getName() + " " + PK[tern3].getIdDado();
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN KEY REFERENCES " + tern3.getName() +
                                            "(" + PK[tern3].getName() + ")";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relacionamento] += tern3.getName() + "ID  integer";
                                        if (carT1.getCardMax() == "N")
                                            tablesAltenative[relacionamento] += " PRIMARY KEY";
                                        tablesAltenative[relacionamento] += " FOREIGN " + tern3.getName() +
                                            "(" + tern3.getName() + "ID)";
                                        PK.Add(tern3, new Atributo(tern3.getName() + "ID", -50, -50, (Desenho)tern3));
                                        if (tern3.getQtdAtributos() > 0)
                                            sql[tern3] += ",\n" + tern3.getName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern3] += tern3.getName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relacionamento.getQtdAtributos();
                                    if (atr > 0)
                                    {
                                        tablesAltenative[relacionamento] += ",\n";
                                        foreach (Desenho f in figuras)
                                        {
                                            if (f.QuemSou().Equals("Atributo"))
                                            {
                                                Atributo possivel = (Atributo)f;
                                                if (possivel.getProprietario() == relacionamento)
                                                {
                                                    tablesAltenative[relacionamento] += possivel.getSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        tablesAltenative[relacionamento] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (carT1.getCardMax() == "N")
                                    {
                                        if (tern1.getQtdAtributos() > 0)
                                            sql[tern1] += ",\n";
                                        try
                                        {
                                            sql[tern1] += PK[tern2].getName() + "FK FOREIGN KEY REFERENCES " + tern2.getName() +
                                                "(" + PK[tern2].getName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern1] += tern2.getName() + "ID  integer FOREIGN " + tern2.getName() +
                                                "(" + tern2.getName() + "ID),\n";
                                            PK.Add(tern2, new Atributo(tern2.getName() + "ID", -50, -50, (Desenho)tern2));
                                            if (tern2.getQtdAtributos() > 0)
                                                sql[tern2] += ",\n" + tern2.getName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern2] += tern2.getName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern1] += PK[tern3].getName() + "FK FOREIGN KEY REFERENCES " + tern3.getName() +
                                                "(" + PK[tern3].getName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern1] += tern3.getName() + "ID  integer FOREIGN " + tern3.getName() +
                                                "(" + tern3.getName() + "ID)";
                                            PK.Add(tern3, new Atributo(tern3.getName() + "ID", -50, -50, (Desenho)tern3));
                                            if (tern3.getQtdAtributos() > 0)
                                                sql[tern3] += ",\n" + tern3.getName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern3] += tern3.getName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relacionamento.getQtdAtributos();
                                        if (atr > 0)
                                        {
                                            sql[tern1] += ",\n";
                                            foreach (Desenho f in figuras)
                                            {
                                                if (f.QuemSou().Equals("Atributo"))
                                                {
                                                    Atributo possivel = (Atributo)f;
                                                    if (possivel.getProprietario() == relacionamento)
                                                    {
                                                        sql[tern1] += possivel.getSql();
                                                        atr--;
                                                        if (atr > 0)
                                                            sql[tern1] += ",\n";
                                                        else
                                                            break;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (carT2.getCardMax() == "N")
                                    {
                                        if (tern2.getQtdAtributos() > 0)
                                            sql[tern2] += ",\n";
                                        try
                                        {
                                            sql[tern2] += PK[tern1].getName() + "FK FOREIGN KEY REFERENCES " + tern1.getName() +
                                                "(" + PK[tern1].getName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern2] += tern1.getName() + "ID  integer FOREIGN " + tern1.getName() +
                                                "(" + tern1.getName() + "ID),\n";
                                            PK.Add(tern1, new Atributo(tern1.getName() + "ID", -50, -50, (Desenho)tern1));
                                            if (tern1.getQtdAtributos() > 0)
                                                sql[tern1] += ",\n" + tern1.getName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern1] += tern1.getName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern2] += PK[tern3].getName() + "FK FOREIGN KEY REFERENCES " + tern3.getName() +
                                                "(" + PK[tern3].getName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern2] += tern3.getName() + "ID  integer FOREIGN " + tern3.getName() +
                                                "(" + tern3.getName() + "ID)";
                                            PK.Add(tern3, new Atributo(tern3.getName() + "ID", -50, -50, (Desenho)tern3));
                                            if (tern3.getQtdAtributos() > 0)
                                                sql[tern3] += ",\n" + tern3.getName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern3] += tern3.getName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relacionamento.getQtdAtributos();
                                        if (atr > 0)
                                        {
                                            sql[tern2] += ",\n";
                                            foreach (Desenho f in figuras)
                                            {
                                                if (f.QuemSou().Equals("Atributo"))
                                                {
                                                    Atributo possivel = (Atributo)f;
                                                    if (possivel.getProprietario() == relacionamento)
                                                    {
                                                        sql[tern2] += possivel.getSql();
                                                        atr--;
                                                        if (atr > 0)
                                                            sql[tern2] += ",\n";
                                                        else
                                                            break;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (tern2.getQtdAtributos() > 0)
                                            sql[tern2] += ",\n";
                                        try
                                        {
                                            sql[tern3] += PK[tern1].getName() + "FK FOREIGN KEY REFERENCES " + tern1.getName() +
                                                "(" + PK[tern1].getName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern3] += tern1.getName() + "ID  integer FOREIGN " + tern1.getName() +
                                                "(" + tern1.getName() + "ID),\n";
                                            PK.Add(tern1, new Atributo(tern1.getName() + "ID", -50, -50, (Desenho)tern1));
                                            if (tern1.getQtdAtributos() > 0)
                                                sql[tern1] += ",\n" + tern1.getName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern1] += tern1.getName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern3] += PK[tern2].getName() + "FK FOREIGN KEY REFERENCES " + tern2.getName() +
                                                "(" + PK[tern2].getName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern3] += tern2.getName() + "ID  integer FOREIGN " + tern2.getName() +
                                                "(" + tern2.getName() + "ID)";
                                            PK.Add(tern2, new Atributo(tern2.getName() + "ID", -50, -50, (Desenho)tern2));
                                            if (tern2.getQtdAtributos() > 0)
                                                sql[tern2] += ",\n" + tern2.getName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern2] += tern2.getName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relacionamento.getQtdAtributos();
                                        if (atr > 0)
                                        {
                                            sql[tern3] += ",\n";
                                            foreach (Desenho f in figuras)
                                            {
                                                if (f.QuemSou().Equals("Atributo"))
                                                {
                                                    Atributo possivel = (Atributo)f;
                                                    if (possivel.getProprietario() == relacionamento)
                                                    {
                                                        sql[tern3] += possivel.getSql();
                                                        atr--;
                                                        if (atr > 0)
                                                            sql[tern3] += ",\n";
                                                        else
                                                            break;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            foreach (KeyValuePair<Entidade, string> linha in sql)
                sqlGerado += linha.Value + "\n);\n";
            foreach (KeyValuePair<Desenho, string> linha in tablesAltenative)
                sqlGerado += linha.Value + "\n);\n";
            richTextBox1.Text = sqlGerado;
        }


        private void Salvar_Click(object sender, EventArgs e)
        {
            List<Entidade> entidades = new List<Entidade>();
            List<Relacionamento> relacionamentos = new List<Relacionamento>();
            List<Atributo> atributos = new List<Atributo>();
            List<Padronizacao> padronizacaos = new List<Padronizacao>();
            List<Especializacao> especializacaos = new List<Especializacao>();

            foreach (Desenho i in figuras)
            {
                switch (i.QuemSou())
                {
                    case "Entidade":
                        entidades.Add((Entidade)i);
                        break;
                    case "Relacionamento":
                        relacionamentos.Add((Relacionamento)i);
                        break;
                    case "Atributo":
                        atributos.Add((Atributo)i);
                        break;
                    case "Padronizacao":
                        padronizacaos.Add((Padronizacao)i);
                        break;
                    case "Especializacao":
                        especializacaos.Add((Especializacao)i);
                        break;
                }
            }
            string connString = @"Host=127.0.0.1;Username=postgres;Password=IFSP;Database=Interdiciplinar";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    string nomeProject = Nome.Text;
                    cmd.CommandText = "Delete from PROJETO";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from Entidade";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from Relacionamento";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from Cardinalidade";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from Atributo";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from Padronizacao";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from Especializacao";
                    cmd.ExecuteNonQuery();

                }
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    string nomeProject = Nome.Text;
                    cmd.CommandText = "INSERT INTO PROJETO VALUES(@nome)";

                    cmd.Parameters.AddWithValue("nome", nomeProject);
                    cmd.ExecuteNonQuery();
                }
                string nome = "";
                int x = 0;
                int y = 0;
                int qtd = 0;
                int qtdEnv = 0;

                foreach (Entidade salva in entidades)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;

                        nome = salva.getName();
                        x = salva.getX();
                        y = salva.getY();
                        qtd = salva.getQtdAtributos();

                        cmd.CommandText = "INSERT INTO Entidade (Nome, x, y, qtdAtributos)" +
                            " VALUES(@nome, @x, @y, @qtdAtributos)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                        cmd.ExecuteNonQuery();
                    }
                }
                int i = 0;
                foreach (Relacionamento salva in relacionamentos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        
                        cmd.Connection = conn;

                        nome = salva.getName();
                        x = salva.getX();
                        y = salva.getY();
                        qtd = salva.getQtdAtributos();
                        qtdEnv = salva.getQtdEnvolvidos();
                        List<Entidade> envs = salva.getEnvolvidos();
                        if (qtdEnv == 1)
                        {
                            int entidade1 = entidades.IndexOf(envs[0]);

                            cmd.CommandText = "INSERT INTO Relacionamento (Nome, x, y, qtdAtributos, qtdEnv, idEntidade1)" +
                                " VALUES(@nome, @x, @y, @qtdAtributos, @qtdEnv, @idEntidade1)";

                            cmd.Parameters.AddWithValue("nome", nome);
                            cmd.Parameters.AddWithValue("x", x);
                            cmd.Parameters.AddWithValue("y", y);
                            cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                            cmd.Parameters.AddWithValue("qtdEnv", qtdEnv);
                            cmd.Parameters.AddWithValue("idEntidade1", entidade1);
                            cmd.ExecuteNonQuery();
                        }
                        else if (qtdEnv == 2)
                        {
                            int entidade1 = entidades.IndexOf(envs[0]);
                            int entidade2 = entidades.IndexOf(envs[1]);

                            cmd.CommandText = "INSERT INTO Relacionamento (Nome, x, y, qtdAtributos, qtdEnv, idEntidade1, idEntidade2)" +
                                " VALUES(@nome, @x, @y, @qtdAtributos, @qtdEnv, @idEntidade1, @idEntidade2)";

                            cmd.Parameters.AddWithValue("nome", nome);
                            cmd.Parameters.AddWithValue("x", x);
                            cmd.Parameters.AddWithValue("y", y);
                            cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                            cmd.Parameters.AddWithValue("qtdEnv", qtdEnv);
                            cmd.Parameters.AddWithValue("idEntidade1", entidade1);
                            cmd.Parameters.AddWithValue("idEntidade2", entidade2);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            int entidade1 = entidades.IndexOf(envs[0]);
                            int entidade2 = entidades.IndexOf(envs[1]);
                            int entidade3 = entidades.IndexOf(envs[2]);

                            cmd.CommandText = "INSERT INTO Relacionamento (Nome, x, y, qtdAtributos, qtdEnv, idEntidade1, idEntidade2, idEntidade3)" +
                                " VALUES(@nome, @x, @y, @qtdAtributos, @qtdEnv, @idEntidade1, @idEntidade2, @idEntidade3)";

                            cmd.Parameters.AddWithValue("nome", nome);
                            cmd.Parameters.AddWithValue("x", x);
                            cmd.Parameters.AddWithValue("y", y);
                            cmd.Parameters.AddWithValue("qtdAtributos", qtd);
                            cmd.Parameters.AddWithValue("qtdEnv", qtdEnv);
                            cmd.Parameters.AddWithValue("idEntidade1", entidade1);
                            cmd.Parameters.AddWithValue("idEntidade2", entidade2);
                            cmd.Parameters.AddWithValue("idEntidade3", entidade3); 
                            cmd.ExecuteNonQuery();
                        }
                    }
                    foreach (Cardinalidade card in salva.getCards())
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;

                            string cardMin = card.getCardMin();
                            string cardMax = card.getCardMax();

                            x = card.getX();
                            y = card.getY();

                            int idRelacionamento = i;
                            List<Entidade> envs = salva.getEnvolvidos();
                            if (qtdEnv == 1)
                            {
                                int entidade1 = 0;
                                entidade1 = entidades.IndexOf(envs[0]);

                                cmd.CommandText = "INSERT INTO Cardinalidade (cardMin, cardMax,x, y, IdRelacionamento)" +
                                    " VALUES(@cardMin, @cardMax, @x, @y, @IdRelacionamento)";

                                cmd.Parameters.AddWithValue("cardMin", cardMin);
                                cmd.Parameters.AddWithValue("cardMax", cardMax);
                                cmd.Parameters.AddWithValue("x", x);
                                cmd.Parameters.AddWithValue("y", y);
                                cmd.Parameters.AddWithValue("IdRelacionamento", idRelacionamento);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    i++;
                }
                foreach(Padronizacao p in padronizacaos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        nome = p.getName();
                        x = p.getX();
                        y = p.getY();
                        int padrao = entidades.IndexOf(p.getEntidadePadrao());
                        string list = "";
                        foreach(Entidade g in p.getEntidades())
                        {
                            list += entidades.IndexOf(g);
                            list += ";";
                        }
                        cmd.CommandText = "INSERT INTO Padronizacao (Nome, x, y, Padrao, List)" +
                            " VALUES(@nome, @x, @y, @Padrao, @List)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("Padrao", padrao);
                        cmd.Parameters.AddWithValue("List", list);
                        cmd.ExecuteNonQuery();
                    }
                }
                foreach (Especializacao t in especializacaos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        nome = t.getName();
                        x = t.getX();
                        y = t.getY();
                        int espec = entidades.IndexOf(t.getEntidadeEspecializada());
                        string list = "";
                        foreach (Entidade g in t.getEntidades())
                        {
                            list += entidades.IndexOf(g);
                            list += ";";
                        }
                        cmd.CommandText = "INSERT INTO Especializacao (Nome, x, y, Especial, List)" +
                            " VALUES(@nome, @x, @y, @Especial, @List)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("Especial", espec);
                        cmd.Parameters.AddWithValue("List", list);
                        cmd.ExecuteNonQuery();
                    }
                }
                foreach (Atributo a in atributos)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        nome = a.getName();
                        x = a.getX();
                        y = a.getY();
                        int indice = a.getIndice();
                        int qtdAtributos = a.getQtdAtributos();
                        int dado = a.getIntDado();
                        string propriedades = "";
                        foreach (int prop in a.getPropriedade())
                        {
                            propriedades += prop + ";";
                        }
                        string Tipo_Proprietario = a.getProprietario().QuemSou();
                        int ID_Proprietario = 0;
                        switch (Tipo_Proprietario)
                        {
                            case "Entidade":
                                ID_Proprietario = entidades.IndexOf((Entidade)a.getProprietario());
                                break;
                            case "Relacionamento":
                                ID_Proprietario = relacionamentos.IndexOf((Relacionamento)a.getProprietario());
                                break;
                            case "Atributo":
                                ID_Proprietario = atributos.IndexOf((Atributo)a.getProprietario());
                                break;
                        }

                        cmd.CommandText = "INSERT INTO Atributo (Nome, x, y, indice, qtdAtributos, dado, propriedades, ID_Proprietario, Tipo_Proprietario)" +
                            " VALUES(@nome, @x, @y, @indice, @qtdAtributos, @dado, @propriedades, @ID_Proprietario, @Tipo_Proprietario)";

                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("x", x);
                        cmd.Parameters.AddWithValue("y", y);
                        cmd.Parameters.AddWithValue("indice", indice);

                        cmd.Parameters.AddWithValue("qtdAtributos", qtdAtributos);
                        cmd.Parameters.AddWithValue("dado", dado);
                        cmd.Parameters.AddWithValue("propriedades", propriedades);
                        cmd.Parameters.AddWithValue("ID_Proprietario", ID_Proprietario);
                        cmd.Parameters.AddWithValue("Tipo_Proprietario", Tipo_Proprietario);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0)
            {
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
                        f.SeDesenhe(grpImage);
                    }
                    pn_edit.Refresh();
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
                                BoxRelacionamento.Visible = true;
                                DonoRelacionamento2.Visible = false;
                                DonoRelacionamento3.Visible = false;
                                EntidadeDono2.Visible = false;
                                EntidadeDono3.Visible = false;

                                NomeRelacionamento.Text = this.selecionado.getName();
                                RelacionamentoX.Text = this.selecionado.getX().ToString();
                                RelacionamentoY.Text = this.selecionado.getY().ToString();
                                Relacionamento rela = (Relacionamento)this.selecionado;
                                EntidadeDono1.Items.Clear(); 
                                EntidadeDono2.Items.Clear();
                                EntidadeDono3.Items.Clear();

                                foreach (Desenho entidades in figuras)
                                {
                                    if(entidades.QuemSou().Equals("Entidade"))
                                    {
                                        EntidadeDono1.Items.Add(entidades);                                       
                                    }
                                }
                                foreach (Desenho entidades in figuras)
                                {
                                    if (entidades.QuemSou().Equals("Entidade"))
                                    {
                                        EntidadeDono2.Items.Add(entidades);
                                    }
                                }
                                foreach (Desenho entidades in figuras)
                                {
                                    if (entidades.QuemSou().Equals("Entidade"))
                                    {
                                        EntidadeDono3.Items.Add(entidades);
                                    }
                                }

                                List<Entidade> env = new List<Entidade>(rela.getEnvolvidos());
                                if (rela.getQtdEnvolvidos() > 0)
                                    EntidadeDono1.Text = env[0].getName();
                                if (rela.getQtdEnvolvidos() > 1)
                                {
                                    EntidadeDono2.SelectedText = "";
                                    EntidadeDono2.SelectedText = env[1].getName();
                                    DonoRelacionamento2.Visible = true;
                                    EntidadeDono2.Visible = true;
                                }
                                if (rela.getQtdEnvolvidos() > 2)
                                {
                                    EntidadeDono3.SelectedText = "";
                                    EntidadeDono3.SelectedText = env[2].getName();
                                    DonoRelacionamento3.Visible = true;
                                    EntidadeDono3.Visible = true;
                                }
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
                            figuras.Last().SeDesenhe(grpImage);
                            pn_edit.Refresh();
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
                            figuras.Last().SeDesenhe(grpImage);
                            pn_edit.Refresh();
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
                        figuras.Last().SeDesenhe(grpImage);
                        pn_edit.Refresh();
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
                        figuras.Last().SeDesenhe(grpImage);
                        pn_edit.Refresh();
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
                    figuras[figuras.Count-1].SeDesenhe(grpImage);
                    pn_edit.Refresh();
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
                            InputBox("Numero de 1 a 3", "Quantidade de Entidades envolvidas (1 a 3):", ref d);
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
                                if (r.getQtdEnvolvidos() == 1)
                                {
                                    r.SeDesenhe(grpImage);
                                    pn_edit.Refresh();
                                    desenhandoRelacionamento = false;
                                    this.textBox1.Focus(); ;
                                    click = 0;
                                }
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
                                    r.SeDesenhe(grpImage);
                                    pn_edit.Refresh();
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
                                r.SeDesenhe(grpImage);
                                pn_edit.Refresh();
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
