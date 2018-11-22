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
            this.pn_edit = new System.Windows.Forms.Panel();
            this.btn_entidade = new System.Windows.Forms.Button();
            this.btn_relacionamento = new System.Windows.Forms.Button();
            this.btn_atributo = new System.Windows.Forms.Button();
            this.btn_heranca = new System.Windows.Forms.Button();
            this.btn_padrao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_del = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.BoxEntidade = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeEntidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntidadeX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntidadeY = new System.Windows.Forms.TextBox();
            this.BoxRelacionamento = new System.Windows.Forms.GroupBox();
            this.RelacionamentoY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RelacionamentoX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeRelacionamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BoxAtributo = new System.Windows.Forms.GroupBox();
            this.AtributoA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AtributoX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NomeAtributo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_edit.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.BoxEntidade.SuspendLayout();
            this.BoxRelacionamento.SuspendLayout();
            this.BoxAtributo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_edit
            // 
            this.pn_edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_edit.Controls.Add(this.BoxAtributo);
            this.pn_edit.Controls.Add(this.BoxRelacionamento);
            this.pn_edit.Controls.Add(this.BoxEntidade);
            this.pn_edit.Location = new System.Drawing.Point(142, 27);
            this.pn_edit.Name = "pn_edit";
            this.pn_edit.Size = new System.Drawing.Size(1014, 599);
            this.pn_edit.TabIndex = 0;
            this.pn_edit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseClick);
            this.pn_edit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseMove);
            // 
            // btn_entidade
            // 
            this.btn_entidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entidade.BackgroundImage")));
            this.btn_entidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entidade.Location = new System.Drawing.Point(0, 92);
            this.btn_entidade.Name = "btn_entidade";
            this.btn_entidade.Size = new System.Drawing.Size(130, 80);
            this.btn_entidade.TabIndex = 0;
            this.btn_entidade.Text = "Entidade";
            this.btn_entidade.UseVisualStyleBackColor = true;
            this.btn_entidade.Click += new System.EventHandler(this.btn_entidade_Click);
            // 
            // btn_relacionamento
            // 
            this.btn_relacionamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_relacionamento.BackgroundImage")));
            this.btn_relacionamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_relacionamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relacionamento.Location = new System.Drawing.Point(0, 178);
            this.btn_relacionamento.Name = "btn_relacionamento";
            this.btn_relacionamento.Size = new System.Drawing.Size(130, 80);
            this.btn_relacionamento.TabIndex = 1;
            this.btn_relacionamento.Text = "Relacionamento";
            this.btn_relacionamento.UseVisualStyleBackColor = true;
            this.btn_relacionamento.Click += new System.EventHandler(this.btn_relacionamento_Click);
            // 
            // btn_atributo
            // 
            this.btn_atributo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_atributo.BackgroundImage")));
            this.btn_atributo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atributo.Location = new System.Drawing.Point(0, 264);
            this.btn_atributo.Name = "btn_atributo";
            this.btn_atributo.Size = new System.Drawing.Size(130, 80);
            this.btn_atributo.TabIndex = 1;
            this.btn_atributo.Text = "Atributo";
            this.btn_atributo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_atributo.UseVisualStyleBackColor = true;
            this.btn_atributo.Click += new System.EventHandler(this.btn_atributo_Click);
            // 
            // btn_heranca
            // 
            this.btn_heranca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_heranca.BackgroundImage")));
            this.btn_heranca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_heranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_heranca.Location = new System.Drawing.Point(0, 436);
            this.btn_heranca.Name = "btn_heranca";
            this.btn_heranca.Size = new System.Drawing.Size(130, 80);
            this.btn_heranca.TabIndex = 1;
            this.btn_heranca.Text = "Especialização";
            this.btn_heranca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_heranca.UseVisualStyleBackColor = true;
            this.btn_heranca.Click += new System.EventHandler(this.btn_heranca_Click);
            // 
            // btn_padrao
            // 
            this.btn_padrao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_padrao.BackgroundImage")));
            this.btn_padrao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_padrao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_padrao.Location = new System.Drawing.Point(0, 350);
            this.btn_padrao.Name = "btn_padrao";
            this.btn_padrao.Size = new System.Drawing.Size(130, 80);
            this.btn_padrao.TabIndex = 1;
            this.btn_padrao.Text = "Padronização";
            this.btn_padrao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_padrao.UseVisualStyleBackColor = true;
            this.btn_padrao.Click += new System.EventHandler(this.btn_padrao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.gerarSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como";
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
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
            // btn_del
            // 
            this.btn_del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_del.BackgroundImage")));
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(206, 527);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(71, 66);
            this.btn_del.TabIndex = 0;
            this.btn_del.UseVisualStyleBackColor = true;
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
            this.BoxEntidade.Controls.Add(this.txtEntidadeY);
            this.BoxEntidade.Controls.Add(this.label3);
            this.BoxEntidade.Controls.Add(this.txtEntidadeX);
            this.BoxEntidade.Controls.Add(this.label2);
            this.BoxEntidade.Controls.Add(this.NomeEntidade);
            this.BoxEntidade.Controls.Add(this.label1);
            this.BoxEntidade.Controls.Add(this.btn_del);
            this.BoxEntidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEntidade.Location = new System.Drawing.Point(728, 0);
            this.BoxEntidade.Name = "BoxEntidade";
            this.BoxEntidade.Size = new System.Drawing.Size(283, 605);
            this.BoxEntidade.TabIndex = 6;
            this.BoxEntidade.TabStop = false;
            this.BoxEntidade.Text = "Propriedades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // NomeEntidade
            // 
            this.NomeEntidade.Location = new System.Drawing.Point(84, 61);
            this.NomeEntidade.Name = "NomeEntidade";
            this.NomeEntidade.Size = new System.Drawing.Size(182, 23);
            this.NomeEntidade.TabIndex = 2;
            this.NomeEntidade.TextChanged += new System.EventHandler(this.NomeEntidade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // txtEntidadeX
            // 
            this.txtEntidadeX.Location = new System.Drawing.Point(84, 122);
            this.txtEntidadeX.Name = "txtEntidadeX";
            this.txtEntidadeX.Size = new System.Drawing.Size(51, 23);
            this.txtEntidadeX.TabIndex = 4;
            this.txtEntidadeX.TextChanged += new System.EventHandler(this.txtEntidadeX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // txtEntidadeY
            // 
            this.txtEntidadeY.Location = new System.Drawing.Point(206, 122);
            this.txtEntidadeY.Name = "txtEntidadeY";
            this.txtEntidadeY.Size = new System.Drawing.Size(51, 23);
            this.txtEntidadeY.TabIndex = 7;
            this.txtEntidadeY.TextChanged += new System.EventHandler(this.txtEntidadeY_TextChanged);
            // 
            // BoxRelacionamento
            // 
            this.BoxRelacionamento.Controls.Add(this.RelacionamentoY);
            this.BoxRelacionamento.Controls.Add(this.label4);
            this.BoxRelacionamento.Controls.Add(this.RelacionamentoX);
            this.BoxRelacionamento.Controls.Add(this.label5);
            this.BoxRelacionamento.Controls.Add(this.NomeRelacionamento);
            this.BoxRelacionamento.Controls.Add(this.label6);
            this.BoxRelacionamento.Controls.Add(this.button1);
            this.BoxRelacionamento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRelacionamento.Location = new System.Drawing.Point(439, 3);
            this.BoxRelacionamento.Name = "BoxRelacionamento";
            this.BoxRelacionamento.Size = new System.Drawing.Size(283, 605);
            this.BoxRelacionamento.TabIndex = 8;
            this.BoxRelacionamento.TabStop = false;
            this.BoxRelacionamento.Text = "Propriedades";
            // 
            // RelacionamentoY
            // 
            this.RelacionamentoY.Location = new System.Drawing.Point(206, 122);
            this.RelacionamentoY.Name = "RelacionamentoY";
            this.RelacionamentoY.Size = new System.Drawing.Size(51, 23);
            this.RelacionamentoY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y:";
            // 
            // RelacionamentoX
            // 
            this.RelacionamentoX.Location = new System.Drawing.Point(84, 122);
            this.RelacionamentoX.Name = "RelacionamentoX";
            this.RelacionamentoX.Size = new System.Drawing.Size(51, 23);
            this.RelacionamentoX.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "X:";
            // 
            // NomeRelacionamento
            // 
            this.NomeRelacionamento.Location = new System.Drawing.Point(84, 61);
            this.NomeRelacionamento.Name = "NomeRelacionamento";
            this.NomeRelacionamento.Size = new System.Drawing.Size(182, 23);
            this.NomeRelacionamento.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(206, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 66);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BoxAtributo
            // 
            this.BoxAtributo.Controls.Add(this.AtributoA);
            this.BoxAtributo.Controls.Add(this.label7);
            this.BoxAtributo.Controls.Add(this.AtributoX);
            this.BoxAtributo.Controls.Add(this.label8);
            this.BoxAtributo.Controls.Add(this.NomeAtributo);
            this.BoxAtributo.Controls.Add(this.label9);
            this.BoxAtributo.Controls.Add(this.button2);
            this.BoxAtributo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAtributo.Location = new System.Drawing.Point(150, 3);
            this.BoxAtributo.Name = "BoxAtributo";
            this.BoxAtributo.Size = new System.Drawing.Size(283, 605);
            this.BoxAtributo.TabIndex = 8;
            this.BoxAtributo.TabStop = false;
            this.BoxAtributo.Text = "Propriedades";
            // 
            // AtributoA
            // 
            this.AtributoA.Location = new System.Drawing.Point(206, 122);
            this.AtributoA.Name = "AtributoA";
            this.AtributoA.Size = new System.Drawing.Size(51, 23);
            this.AtributoA.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Y:";
            // 
            // AtributoX
            // 
            this.AtributoX.Location = new System.Drawing.Point(84, 122);
            this.AtributoX.Name = "AtributoX";
            this.AtributoX.Size = new System.Drawing.Size(51, 23);
            this.AtributoX.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "X:";
            // 
            // NomeAtributo
            // 
            this.NomeAtributo.Location = new System.Drawing.Point(84, 61);
            this.NomeAtributo.Name = "NomeAtributo";
            this.NomeAtributo.Size = new System.Drawing.Size(182, 23);
            this.NomeAtributo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dutch801 XBd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nome:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(206, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 66);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EditPanel
            // 
            this.AccessibleDescription = "FlowModel for entity relationship model";
            this.AccessibleName = "Flow Model";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1457, 644);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.btn_padrao);
            this.Controls.Add(this.btn_heranca);
            this.Controls.Add(this.btn_atributo);
            this.Controls.Add(this.btn_relacionamento);
            this.Controls.Add(this.btn_entidade);
            this.Controls.Add(this.pn_edit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditPanel";
            this.Text = "FlowModel a entity-relationship modeler ";
            this.Load += new System.EventHandler(this.EditPanel_Load);
            this.pn_edit.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BoxEntidade.ResumeLayout(false);
            this.BoxEntidade.PerformLayout();
            this.BoxRelacionamento.ResumeLayout(false);
            this.BoxRelacionamento.PerformLayout();
            this.BoxAtributo.ResumeLayout(false);
            this.BoxAtributo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_edit;
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
        private System.Windows.Forms.Button btn_del;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox BoxAtributo;
        private System.Windows.Forms.TextBox AtributoA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AtributoX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NomeAtributo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}

