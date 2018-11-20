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
            this.sqlGerado = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_edit
            // 
            this.pn_edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pn_edit.Location = new System.Drawing.Point(171, 27);
            this.pn_edit.Name = "pn_edit";
            this.pn_edit.Size = new System.Drawing.Size(720, 599);
            this.pn_edit.TabIndex = 0;
            this.pn_edit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseClick);
            this.pn_edit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_edit_MouseMove);
            // 
            // btn_entidade
            // 
            this.btn_entidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entidade.BackgroundImage")));
            this.btn_entidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entidade.Location = new System.Drawing.Point(12, 58);
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
            this.btn_relacionamento.Location = new System.Drawing.Point(12, 144);
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
            this.btn_atributo.Location = new System.Drawing.Point(12, 230);
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
            this.btn_heranca.Location = new System.Drawing.Point(12, 402);
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
            this.btn_padrao.Location = new System.Drawing.Point(12, 316);
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
            this.menuStrip1.Size = new System.Drawing.Size(1265, 24);
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
            this.btn_del.Location = new System.Drawing.Point(12, 560);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(71, 66);
            this.btn_del.TabIndex = 0;
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // sqlGerado
            // 
            this.sqlGerado.Location = new System.Drawing.Point(897, 27);
            this.sqlGerado.Name = "sqlGerado";
            this.sqlGerado.Size = new System.Drawing.Size(368, 267);
            this.sqlGerado.TabIndex = 4;
            this.sqlGerado.Text = "";
            // 
            // EditPanel
            // 
            this.AccessibleDescription = "FlowModel for entity relationship model";
            this.AccessibleName = "Flow Model";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1265, 648);
            this.Controls.Add(this.sqlGerado);
            this.Controls.Add(this.btn_del);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.RichTextBox sqlGerado;
    }
}

