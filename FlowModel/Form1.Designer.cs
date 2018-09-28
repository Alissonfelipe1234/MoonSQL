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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_entidade = new System.Windows.Forms.Button();
            this.btn_relacionamento = new System.Windows.Forms.Button();
            this.btn_atributo = new System.Windows.Forms.Button();
            this.btn_heranca = new System.Windows.Forms.Button();
            this.btn_padrao = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 626);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_entidade
            // 
            this.btn_entidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entidade.BackgroundImage")));
            this.btn_entidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entidade.Location = new System.Drawing.Point(30, 15);
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
            this.btn_relacionamento.Location = new System.Drawing.Point(30, 101);
            this.btn_relacionamento.Name = "btn_relacionamento";
            this.btn_relacionamento.Size = new System.Drawing.Size(130, 80);
            this.btn_relacionamento.TabIndex = 1;
            this.btn_relacionamento.Text = "Relacionamento";
            this.btn_relacionamento.UseVisualStyleBackColor = true;
            // 
            // btn_atributo
            // 
            this.btn_atributo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_atributo.BackgroundImage")));
            this.btn_atributo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atributo.Location = new System.Drawing.Point(30, 187);
            this.btn_atributo.Name = "btn_atributo";
            this.btn_atributo.Size = new System.Drawing.Size(130, 80);
            this.btn_atributo.TabIndex = 1;
            this.btn_atributo.Text = "Atributo";
            this.btn_atributo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_atributo.UseVisualStyleBackColor = true;
            // 
            // btn_heranca
            // 
            this.btn_heranca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_heranca.BackgroundImage")));
            this.btn_heranca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_heranca.Location = new System.Drawing.Point(30, 359);
            this.btn_heranca.Name = "btn_heranca";
            this.btn_heranca.Size = new System.Drawing.Size(130, 80);
            this.btn_heranca.TabIndex = 1;
            this.btn_heranca.Text = "Especialização";
            this.btn_heranca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_heranca.UseVisualStyleBackColor = true;
            // 
            // btn_padrao
            // 
            this.btn_padrao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_padrao.BackgroundImage")));
            this.btn_padrao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_padrao.Location = new System.Drawing.Point(30, 273);
            this.btn_padrao.Name = "btn_padrao";
            this.btn_padrao.Size = new System.Drawing.Size(130, 80);
            this.btn_padrao.TabIndex = 1;
            this.btn_padrao.Text = "Padronização";
            this.btn_padrao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_padrao.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 461);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(89, 32);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(12, 499);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(89, 32);
            this.btn_limpar.TabIndex = 0;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // EditPanel
            // 
            this.AccessibleDescription = "FlowModel for entity relationship model";
            this.AccessibleName = "Flow Model";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 628);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_padrao);
            this.Controls.Add(this.btn_heranca);
            this.Controls.Add(this.btn_atributo);
            this.Controls.Add(this.btn_relacionamento);
            this.Controls.Add(this.btn_entidade);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPanel";
            this.Text = "FlowModel a entity-relationship modeler ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_entidade;
        private System.Windows.Forms.Button btn_relacionamento;
        private System.Windows.Forms.Button btn_atributo;
        private System.Windows.Forms.Button btn_heranca;
        private System.Windows.Forms.Button btn_padrao;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_limpar;
    }
}

