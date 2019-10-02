namespace FlowModel.Screens
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextoInicial = new System.Windows.Forms.Label();
            this.SqlToImage = new System.Windows.Forms.Button();
            this.NewProject = new System.Windows.Forms.Button();
            this.OpenProject = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.TextoInicial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SqlToImage, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NewProject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenProject, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextoInicial
            // 
            this.TextoInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoInicial.AutoSize = true;
            this.TextoInicial.Font = new System.Drawing.Font("Noto Kufi Arabic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoInicial.Location = new System.Drawing.Point(310, 5);
            this.TextoInicial.Name = "TextoInicial";
            this.TextoInicial.Size = new System.Drawing.Size(180, 140);
            this.TextoInicial.TabIndex = 0;
            this.TextoInicial.Text = "Flow Model ";
            this.TextoInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SqlToImage
            // 
            this.SqlToImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SqlToImage.Cursor = System.Windows.Forms.Cursors.No;
            this.SqlToImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqlToImage.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlToImage.Location = new System.Drawing.Point(523, 153);
            this.SqlToImage.Name = "SqlToImage";
            this.SqlToImage.Size = new System.Drawing.Size(274, 88);
            this.SqlToImage.TabIndex = 1;
            this.SqlToImage.Text = "Conversão SQ";
            this.SqlToImage.UseVisualStyleBackColor = false;
            // 
            // NewProject
            // 
            this.NewProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProject.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProject.Location = new System.Drawing.Point(3, 153);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(274, 88);
            this.NewProject.TabIndex = 2;
            this.NewProject.Text = "Criar Novo";
            this.NewProject.UseVisualStyleBackColor = false;
            // 
            // OpenProject
            // 
            this.OpenProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenProject.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenProject.Location = new System.Drawing.Point(283, 153);
            this.OpenProject.Name = "OpenProject";
            this.OpenProject.Size = new System.Drawing.Size(234, 88);
            this.OpenProject.TabIndex = 3;
            this.OpenProject.Text = "Abrir Projeto";
            this.OpenProject.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TextoInicial;
        private System.Windows.Forms.Button SqlToImage;
        private System.Windows.Forms.Button NewProject;
        private System.Windows.Forms.Button OpenProject;
    }
}