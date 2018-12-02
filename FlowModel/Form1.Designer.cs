namespace FlowModel
{
    partial class EditPanel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.Label();
            this.BoxEntidade = new System.Windows.Forms.GroupBox();
            this.txtEntidadeY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntidadeX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeEntidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxAtributo = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCardAtributoMax = new System.Windows.Forms.TextBox();
            this.cbDerivado = new System.Windows.Forms.ComboBox();
            this.Composto = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDonoAtributo = new System.Windows.Forms.ComboBox();
            this.Derivado = new System.Windows.Forms.CheckBox();
            this.Primario = new System.Windows.Forms.CheckBox();
            this.txtCardAtributoMin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoAtributo = new System.Windows.Forms.ComboBox();
            this.NomeAtributo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxRelacionamento = new System.Windows.Forms.GroupBox();
            this.DonoRelacionamento2 = new System.Windows.Forms.Label();
            this.EntidadeDono2 = new System.Windows.Forms.ComboBox();
            this.DonoRelacionamento3 = new System.Windows.Forms.Label();
            this.EntidadeDono3 = new System.Windows.Forms.ComboBox();
            this.DonoRelacionamento1 = new System.Windows.Forms.Label();
            this.EntidadeDono1 = new System.Windows.Forms.ComboBox();
            this.RelacionamentoY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RelacionamentoX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeRelacionamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InfoOqueFazer = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_padrao = new System.Windows.Forms.Button();
            this.btn_heranca = new System.Windows.Forms.Button();
            this.btn_atributo = new System.Windows.Forms.Button();
            this.btn_relacionamento = new System.Windows.Forms.Button();
            this.btn_entidade = new System.Windows.Forms.Button();
            this.pn_edit = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.BoxEntidade.SuspendLayout();
            this.BoxAtributo.SuspendLayout();
            this.BoxRelacionamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.gerarSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarComoToolStripMenuItem,
            this.salvarToolStripMenuItem1});
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como";
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // gerarSQLToolStripMenuItem
            // 
            this.gerarSQLToolStripMenuItem.Name = "gerarSQLToolStripMenuItem";
            this.gerarSQLToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.gerarSQLToolStripMenuItem.Text = "Gerar SQL";
            this.gerarSQLToolStripMenuItem.Click += new System.EventHandler(this.gerarSQLToolStripMenuItem_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Noto Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(139, 629);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(35, 18);
            this.Info.TabIndex = 5;
            this.Info.Text = "0,0";
            // 
            // BoxEntidade
            // 
            this.BoxEntidade.Controls.Add(this.BoxRelacionamento);
            this.BoxEntidade.Controls.Add(this.txtEntidadeY);
            this.BoxEntidade.Controls.Add(this.label3);
            this.BoxEntidade.Controls.Add(this.txtEntidadeX);
            this.BoxEntidade.Controls.Add(this.label2);
            this.BoxEntidade.Controls.Add(this.NomeEntidade);
            this.BoxEntidade.Controls.Add(this.label1);
            this.BoxEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxEntidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEntidade.Location = new System.Drawing.Point(1080, 27);
            this.BoxEntidade.Name = "BoxEntidade";
            this.BoxEntidade.Size = new System.Drawing.Size(283, 196);
            this.BoxEntidade.TabIndex = 0;
            this.BoxEntidade.TabStop = false;
            this.BoxEntidade.Text = "Propriedades";
            this.BoxEntidade.Visible = false;
            // 
            // txtEntidadeY
            // 
            this.txtEntidadeY.Location = new System.Drawing.Point(84, 151);
            this.txtEntidadeY.Name = "txtEntidadeY";
            this.txtEntidadeY.Size = new System.Drawing.Size(51, 23);
            this.txtEntidadeY.TabIndex = 7;
            this.txtEntidadeY.TextChanged += new System.EventHandler(this.txtEntidadeY_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEntidadeX
            // 
            this.txtEntidadeX.Location = new System.Drawing.Point(84, 122);
            this.txtEntidadeX.Name = "txtEntidadeX";
            this.txtEntidadeX.Size = new System.Drawing.Size(51, 23);
            this.txtEntidadeX.TabIndex = 4;
            this.txtEntidadeX.TextChanged += new System.EventHandler(this.txtEntidadeX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // NomeEntidade
            // 
            this.NomeEntidade.Location = new System.Drawing.Point(84, 61);
            this.NomeEntidade.Name = "NomeEntidade";
            this.NomeEntidade.Size = new System.Drawing.Size(182, 23);
            this.NomeEntidade.TabIndex = 2;
            this.NomeEntidade.TextChanged += new System.EventHandler(this.NomeEntidade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // BoxAtributo
            // 
            this.BoxAtributo.Controls.Add(this.label12);
            this.BoxAtributo.Controls.Add(this.label8);
            this.BoxAtributo.Controls.Add(this.txtCardAtributoMax);
            this.BoxAtributo.Controls.Add(this.cbDerivado);
            this.BoxAtributo.Controls.Add(this.Composto);
            this.BoxAtributo.Controls.Add(this.label7);
            this.BoxAtributo.Controls.Add(this.cbDonoAtributo);
            this.BoxAtributo.Controls.Add(this.Derivado);
            this.BoxAtributo.Controls.Add(this.Primario);
            this.BoxAtributo.Controls.Add(this.txtCardAtributoMin);
            this.BoxAtributo.Controls.Add(this.label11);
            this.BoxAtributo.Controls.Add(this.label10);
            this.BoxAtributo.Controls.Add(this.cbTipoAtributo);
            this.BoxAtributo.Controls.Add(this.NomeAtributo);
            this.BoxAtributo.Controls.Add(this.label9);
            this.BoxAtributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxAtributo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAtributo.Location = new System.Drawing.Point(1080, 27);
            this.BoxAtributo.Name = "BoxAtributo";
            this.BoxAtributo.Size = new System.Drawing.Size(283, 375);
            this.BoxAtributo.TabIndex = 0;
            this.BoxAtributo.TabStop = false;
            this.BoxAtributo.Text = "Propriedades";
            this.BoxAtributo.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Min";
            // 
            // txtCardAtributoMax
            // 
            this.txtCardAtributoMax.Location = new System.Drawing.Point(167, 262);
            this.txtCardAtributoMax.Name = "txtCardAtributoMax";
            this.txtCardAtributoMax.Size = new System.Drawing.Size(33, 23);
            this.txtCardAtributoMax.TabIndex = 18;
            this.txtCardAtributoMax.TextChanged += new System.EventHandler(this.txtCardAtributoMax_TextChanged);
            // 
            // cbDerivado
            // 
            this.cbDerivado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDerivado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDerivado.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbDerivado.FormattingEnabled = true;
            this.cbDerivado.Location = new System.Drawing.Point(131, 317);
            this.cbDerivado.Name = "cbDerivado";
            this.cbDerivado.Size = new System.Drawing.Size(128, 24);
            this.cbDerivado.TabIndex = 17;
            this.cbDerivado.UseWaitCursor = true;
            this.cbDerivado.Visible = false;
            this.cbDerivado.SelectedIndexChanged += new System.EventHandler(this.cbDerivado_SelectedIndexChanged);
            // 
            // Composto
            // 
            this.Composto.AutoSize = true;
            this.Composto.Enabled = false;
            this.Composto.Location = new System.Drawing.Point(33, 348);
            this.Composto.Name = "Composto";
            this.Composto.Size = new System.Drawing.Size(101, 20);
            this.Composto.TabIndex = 16;
            this.Composto.Text = "Composto";
            this.Composto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dono:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbDonoAtributo
            // 
            this.cbDonoAtributo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDonoAtributo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDonoAtributo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDonoAtributo.FormattingEnabled = true;
            this.cbDonoAtributo.Location = new System.Drawing.Point(84, 121);
            this.cbDonoAtributo.Name = "cbDonoAtributo";
            this.cbDonoAtributo.Size = new System.Drawing.Size(182, 24);
            this.cbDonoAtributo.TabIndex = 14;
            this.cbDonoAtributo.SelectedIndexChanged += new System.EventHandler(this.cbDonoAtributo_SelectedIndexChanged);
            // 
            // Derivado
            // 
            this.Derivado.AutoSize = true;
            this.Derivado.Location = new System.Drawing.Point(33, 319);
            this.Derivado.Name = "Derivado";
            this.Derivado.Size = new System.Drawing.Size(92, 20);
            this.Derivado.TabIndex = 13;
            this.Derivado.Text = "Derivado";
            this.Derivado.UseVisualStyleBackColor = true;
            this.Derivado.CheckedChanged += new System.EventHandler(this.Derivado_CheckedChanged);
            // 
            // Primario
            // 
            this.Primario.AutoSize = true;
            this.Primario.Location = new System.Drawing.Point(33, 293);
            this.Primario.Name = "Primario";
            this.Primario.Size = new System.Drawing.Size(88, 20);
            this.Primario.TabIndex = 12;
            this.Primario.Text = "Primario";
            this.Primario.UseVisualStyleBackColor = true;
            this.Primario.CheckedChanged += new System.EventHandler(this.Primario_CheckedChanged);
            // 
            // txtCardAtributoMin
            // 
            this.txtCardAtributoMin.Location = new System.Drawing.Point(167, 233);
            this.txtCardAtributoMin.Name = "txtCardAtributoMin";
            this.txtCardAtributoMin.Size = new System.Drawing.Size(33, 23);
            this.txtCardAtributoMin.TabIndex = 11;
            this.txtCardAtributoMin.TextChanged += new System.EventHandler(this.txtCardAtributoMin_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cardinalidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tipo: ";
            // 
            // cbTipoAtributo
            // 
            this.cbTipoAtributo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTipoAtributo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoAtributo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoAtributo.FormattingEnabled = true;
            this.cbTipoAtributo.Location = new System.Drawing.Point(84, 177);
            this.cbTipoAtributo.Name = "cbTipoAtributo";
            this.cbTipoAtributo.Size = new System.Drawing.Size(182, 24);
            this.cbTipoAtributo.TabIndex = 8;
            this.cbTipoAtributo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // NomeAtributo
            // 
            this.NomeAtributo.Location = new System.Drawing.Point(84, 61);
            this.NomeAtributo.Name = "NomeAtributo";
            this.NomeAtributo.Size = new System.Drawing.Size(182, 23);
            this.NomeAtributo.TabIndex = 2;
            this.NomeAtributo.TextChanged += new System.EventHandler(this.NomeAtributo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nome:";
            // 
            // BoxRelacionamento
            // 
            this.BoxRelacionamento.Controls.Add(this.DonoRelacionamento2);
            this.BoxRelacionamento.Controls.Add(this.EntidadeDono2);
            this.BoxRelacionamento.Controls.Add(this.DonoRelacionamento3);
            this.BoxRelacionamento.Controls.Add(this.EntidadeDono3);
            this.BoxRelacionamento.Controls.Add(this.DonoRelacionamento1);
            this.BoxRelacionamento.Controls.Add(this.EntidadeDono1);
            this.BoxRelacionamento.Controls.Add(this.RelacionamentoY);
            this.BoxRelacionamento.Controls.Add(this.label4);
            this.BoxRelacionamento.Controls.Add(this.RelacionamentoX);
            this.BoxRelacionamento.Controls.Add(this.label5);
            this.BoxRelacionamento.Controls.Add(this.NomeRelacionamento);
            this.BoxRelacionamento.Controls.Add(this.label6);
            this.BoxRelacionamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxRelacionamento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRelacionamento.Location = new System.Drawing.Point(0, 0);
            this.BoxRelacionamento.Name = "BoxRelacionamento";
            this.BoxRelacionamento.Size = new System.Drawing.Size(283, 291);
            this.BoxRelacionamento.TabIndex = 0;
            this.BoxRelacionamento.TabStop = false;
            this.BoxRelacionamento.Text = "Propriedades";
            this.BoxRelacionamento.Visible = false;
            // 
            // DonoRelacionamento2
            // 
            this.DonoRelacionamento2.AutoSize = true;
            this.DonoRelacionamento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonoRelacionamento2.Location = new System.Drawing.Point(25, 225);
            this.DonoRelacionamento2.Name = "DonoRelacionamento2";
            this.DonoRelacionamento2.Size = new System.Drawing.Size(81, 18);
            this.DonoRelacionamento2.TabIndex = 26;
            this.DonoRelacionamento2.Text = "Entidade 2:";
            this.DonoRelacionamento2.Visible = false;
            // 
            // EntidadeDono2
            // 
            this.EntidadeDono2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EntidadeDono2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EntidadeDono2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntidadeDono2.FormattingEnabled = true;
            this.EntidadeDono2.Location = new System.Drawing.Point(112, 225);
            this.EntidadeDono2.Name = "EntidadeDono2";
            this.EntidadeDono2.Size = new System.Drawing.Size(165, 24);
            this.EntidadeDono2.TabIndex = 25;
            this.EntidadeDono2.Visible = false;
            this.EntidadeDono2.SelectedIndexChanged += new System.EventHandler(this.EntidadeDono2_SelectedIndexChanged);
            // 
            // DonoRelacionamento3
            // 
            this.DonoRelacionamento3.AutoSize = true;
            this.DonoRelacionamento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonoRelacionamento3.Location = new System.Drawing.Point(25, 255);
            this.DonoRelacionamento3.Name = "DonoRelacionamento3";
            this.DonoRelacionamento3.Size = new System.Drawing.Size(81, 18);
            this.DonoRelacionamento3.TabIndex = 24;
            this.DonoRelacionamento3.Text = "Entidade 3:";
            this.DonoRelacionamento3.Visible = false;
            // 
            // EntidadeDono3
            // 
            this.EntidadeDono3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EntidadeDono3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EntidadeDono3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntidadeDono3.FormattingEnabled = true;
            this.EntidadeDono3.Location = new System.Drawing.Point(111, 255);
            this.EntidadeDono3.Name = "EntidadeDono3";
            this.EntidadeDono3.Size = new System.Drawing.Size(165, 24);
            this.EntidadeDono3.TabIndex = 23;
            this.EntidadeDono3.Visible = false;
            this.EntidadeDono3.SelectedIndexChanged += new System.EventHandler(this.EntidadeDono3_SelectedIndexChanged);
            // 
            // DonoRelacionamento1
            // 
            this.DonoRelacionamento1.AutoSize = true;
            this.DonoRelacionamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonoRelacionamento1.Location = new System.Drawing.Point(25, 195);
            this.DonoRelacionamento1.Name = "DonoRelacionamento1";
            this.DonoRelacionamento1.Size = new System.Drawing.Size(81, 18);
            this.DonoRelacionamento1.TabIndex = 22;
            this.DonoRelacionamento1.Text = "Entidade 1:";
            // 
            // EntidadeDono1
            // 
            this.EntidadeDono1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EntidadeDono1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EntidadeDono1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntidadeDono1.FormattingEnabled = true;
            this.EntidadeDono1.Location = new System.Drawing.Point(112, 195);
            this.EntidadeDono1.Name = "EntidadeDono1";
            this.EntidadeDono1.Size = new System.Drawing.Size(165, 24);
            this.EntidadeDono1.TabIndex = 21;
            this.EntidadeDono1.SelectedIndexChanged += new System.EventHandler(this.EntidadeDono1_SelectedIndexChanged);
            // 
            // RelacionamentoY
            // 
            this.RelacionamentoY.Location = new System.Drawing.Point(206, 122);
            this.RelacionamentoY.Name = "RelacionamentoY";
            this.RelacionamentoY.Size = new System.Drawing.Size(51, 23);
            this.RelacionamentoY.TabIndex = 7;
            this.RelacionamentoY.TextChanged += new System.EventHandler(this.RelacionamentoY_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y:";
            // 
            // RelacionamentoX
            // 
            this.RelacionamentoX.Location = new System.Drawing.Point(84, 122);
            this.RelacionamentoX.Name = "RelacionamentoX";
            this.RelacionamentoX.Size = new System.Drawing.Size(51, 23);
            this.RelacionamentoX.TabIndex = 4;
            this.RelacionamentoX.TextChanged += new System.EventHandler(this.RelacionamentoX_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "X:";
            // 
            // NomeRelacionamento
            // 
            this.NomeRelacionamento.Location = new System.Drawing.Point(84, 61);
            this.NomeRelacionamento.Name = "NomeRelacionamento";
            this.NomeRelacionamento.Size = new System.Drawing.Size(182, 23);
            this.NomeRelacionamento.TabIndex = 2;
            this.NomeRelacionamento.TextChanged += new System.EventHandler(this.NomeRelacionamento_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // InfoOqueFazer
            // 
            this.InfoOqueFazer.AutoSize = true;
            this.InfoOqueFazer.Font = new System.Drawing.Font("Noto Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoOqueFazer.Location = new System.Drawing.Point(404, 629);
            this.InfoOqueFazer.Name = "InfoOqueFazer";
            this.InfoOqueFazer.Size = new System.Drawing.Size(0, 18);
            this.InfoOqueFazer.TabIndex = 812;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 557);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(49, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Noto Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 605);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 18);
            this.label13.TabIndex = 814;
            this.label13.Text = "Battery Save";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FlowModel.Properties.Resources.flower_512;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(67, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 58);
            this.button2.TabIndex = 813;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_padrao
            // 
            this.btn_padrao.BackColor = System.Drawing.Color.White;
            this.btn_padrao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_padrao.BackgroundImage")));
            this.btn_padrao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_padrao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_padrao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_padrao.Location = new System.Drawing.Point(0, 350);
            this.btn_padrao.Name = "btn_padrao";
            this.btn_padrao.Size = new System.Drawing.Size(130, 80);
            this.btn_padrao.TabIndex = 1;
            this.btn_padrao.Text = "Padronização";
            this.btn_padrao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_padrao.UseVisualStyleBackColor = false;
            this.btn_padrao.Click += new System.EventHandler(this.btn_padrao_Click);
            // 
            // btn_heranca
            // 
            this.btn_heranca.BackColor = System.Drawing.Color.White;
            this.btn_heranca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_heranca.BackgroundImage")));
            this.btn_heranca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_heranca.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_heranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_heranca.Location = new System.Drawing.Point(0, 436);
            this.btn_heranca.Name = "btn_heranca";
            this.btn_heranca.Size = new System.Drawing.Size(130, 80);
            this.btn_heranca.TabIndex = 1;
            this.btn_heranca.Text = "Especialização";
            this.btn_heranca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_heranca.UseVisualStyleBackColor = false;
            this.btn_heranca.Click += new System.EventHandler(this.btn_heranca_Click);
            // 
            // btn_atributo
            // 
            this.btn_atributo.BackColor = System.Drawing.Color.White;
            this.btn_atributo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_atributo.BackgroundImage")));
            this.btn_atributo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atributo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_atributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atributo.Location = new System.Drawing.Point(0, 264);
            this.btn_atributo.Name = "btn_atributo";
            this.btn_atributo.Size = new System.Drawing.Size(130, 80);
            this.btn_atributo.TabIndex = 1;
            this.btn_atributo.Text = "Atributo";
            this.btn_atributo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_atributo.UseVisualStyleBackColor = false;
            this.btn_atributo.Click += new System.EventHandler(this.btn_atributo_Click);
            // 
            // btn_relacionamento
            // 
            this.btn_relacionamento.BackColor = System.Drawing.Color.White;
            this.btn_relacionamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_relacionamento.BackgroundImage")));
            this.btn_relacionamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_relacionamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relacionamento.Location = new System.Drawing.Point(0, 178);
            this.btn_relacionamento.Name = "btn_relacionamento";
            this.btn_relacionamento.Size = new System.Drawing.Size(130, 80);
            this.btn_relacionamento.TabIndex = 1;
            this.btn_relacionamento.Text = "Relacionamento";
            this.btn_relacionamento.UseVisualStyleBackColor = false;
            this.btn_relacionamento.Click += new System.EventHandler(this.btn_relacionamento_Click);
            // 
            // btn_entidade
            // 
            this.btn_entidade.BackColor = System.Drawing.Color.White;
            this.btn_entidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entidade.BackgroundImage")));
            this.btn_entidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_entidade.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_entidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entidade.Location = new System.Drawing.Point(0, 92);
            this.btn_entidade.Name = "btn_entidade";
            this.btn_entidade.Size = new System.Drawing.Size(130, 80);
            this.btn_entidade.TabIndex = 1;
            this.btn_entidade.Text = "Entidade";
            this.btn_entidade.UseVisualStyleBackColor = false;
            this.btn_entidade.Click += new System.EventHandler(this.btn_entidade_Click);
            // 
            // pn_edit
            // 
            this.pn_edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_edit.Location = new System.Drawing.Point(142, 27);
            this.pn_edit.Name = "pn_edit";
            this.pn_edit.Size = new System.Drawing.Size(932, 600);
            this.pn_edit.TabIndex = 1;
            this.pn_edit.TabStop = true;
            this.pn_edit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseClick);
            this.pn_edit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseDown);
            this.pn_edit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseMove);
            this.pn_edit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1080, 408);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 220);
            this.richTextBox1.TabIndex = 815;
            this.richTextBox1.Text = "";
            // 
            // EditPanel
            // 
            this.AccessibleDescription = "FlowModel for entity relationship model";
            this.AccessibleName = "Flow Model";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 647);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.InfoOqueFazer);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.btn_padrao);
            this.Controls.Add(this.btn_heranca);
            this.Controls.Add(this.btn_atributo);
            this.Controls.Add(this.btn_relacionamento);
            this.Controls.Add(this.btn_entidade);
            this.Controls.Add(this.pn_edit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BoxEntidade);
            this.Controls.Add(this.BoxAtributo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditPanel";
            this.Text = "FlowModel a entity-relationship modeler ";
            this.Load += new System.EventHandler(this.EditPanel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditPanel_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditPanel_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BoxEntidade.ResumeLayout(false);
            this.BoxEntidade.PerformLayout();
            this.BoxAtributo.ResumeLayout(false);
            this.BoxAtributo.PerformLayout();
            this.BoxRelacionamento.ResumeLayout(false);
            this.BoxRelacionamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_entidade;
        private System.Windows.Forms.Button btn_relacionamento;
        private System.Windows.Forms.Button btn_atributo;
        private System.Windows.Forms.Button btn_heranca;
        private System.Windows.Forms.Button btn_padrao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarSQLToolStripMenuItem;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.GroupBox BoxEntidade;
        private System.Windows.Forms.TextBox NomeEntidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntidadeY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEntidadeX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BoxRelacionamento;
        private System.Windows.Forms.TextBox RelacionamentoY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RelacionamentoX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomeRelacionamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox BoxAtributo;
        private System.Windows.Forms.TextBox NomeAtributo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox Primario;
        private System.Windows.Forms.TextBox txtCardAtributoMin;
        private System.Windows.Forms.CheckBox Derivado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbDonoAtributo;
        private System.Windows.Forms.ComboBox cbTipoAtributo;
        private System.Windows.Forms.CheckBox Composto;
        private System.Windows.Forms.ComboBox cbDerivado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCardAtributoMax;
        private System.Windows.Forms.Label InfoOqueFazer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label DonoRelacionamento2;
        private System.Windows.Forms.ComboBox EntidadeDono2;
        private System.Windows.Forms.Label DonoRelacionamento3;
        private System.Windows.Forms.ComboBox EntidadeDono3;
        private System.Windows.Forms.Label DonoRelacionamento1;
        private System.Windows.Forms.ComboBox EntidadeDono1;
        private System.Windows.Forms.Panel pn_edit;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

