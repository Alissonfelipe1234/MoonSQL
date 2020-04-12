namespace moonSql
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.paint = new System.Windows.Forms.Panel();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.new_entity = new System.Windows.Forms.Button();
            this.New_relationship = new System.Windows.Forms.Button();
            this.new_attribute = new System.Windows.Forms.Button();
            this.new_specialization = new System.Windows.Forms.Button();
            this.new_generalization = new System.Windows.Forms.Button();
            this.generate_sql = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            this.toolBox.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(0)))), ((int)(((byte)(72)))));
            this.layout.ColumnCount = 4;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.layout.Controls.Add(this.paint, 2, 1);
            this.layout.Controls.Add(this.toolBox, 1, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.layout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.503006F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.29459F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.202405F));
            this.layout.Size = new System.Drawing.Size(1264, 681);
            this.layout.TabIndex = 0;
            // 
            // paint
            // 
            this.paint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paint.BackColor = System.Drawing.Color.FloralWhite;
            this.paint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paint.Location = new System.Drawing.Point(204, 13);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(1043, 656);
            this.paint.TabIndex = 1;
            this.paint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseClick);
            this.paint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseDown);
            this.paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseMove);
            this.paint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseUp);
            // 
            // toolBox
            // 
            this.toolBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(0)))), ((int)(((byte)(172)))));
            this.toolBox.Controls.Add(this.tableButtons);
            this.toolBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolBox.Location = new System.Drawing.Point(15, 13);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(183, 656);
            this.toolBox.TabIndex = 0;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Tool Box";
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 1;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Controls.Add(this.new_entity, 0, 0);
            this.tableButtons.Controls.Add(this.New_relationship, 0, 1);
            this.tableButtons.Controls.Add(this.new_attribute, 0, 2);
            this.tableButtons.Controls.Add(this.new_specialization, 0, 3);
            this.tableButtons.Controls.Add(this.new_generalization, 0, 4);
            this.tableButtons.Controls.Add(this.generate_sql, 0, 9);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtons.Location = new System.Drawing.Point(3, 24);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 10;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableButtons.Size = new System.Drawing.Size(177, 629);
            this.tableButtons.TabIndex = 1;
            // 
            // new_entity
            // 
            this.new_entity.AccessibleDescription = "click to create an entity";
            this.new_entity.AccessibleName = "Entity";
            this.new_entity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_entity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.new_entity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_entity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_entity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_entity.ForeColor = System.Drawing.Color.Cornsilk;
            this.new_entity.Location = new System.Drawing.Point(3, 3);
            this.new_entity.Name = "new_entity";
            this.new_entity.Size = new System.Drawing.Size(171, 56);
            this.new_entity.TabIndex = 1;
            this.new_entity.Text = "Entity";
            this.new_entity.UseVisualStyleBackColor = false;
            this.new_entity.Click += new System.EventHandler(this.New_entity_Click);
            // 
            // New_relationship
            // 
            this.New_relationship.AccessibleDescription = "click to create a relationship";
            this.New_relationship.AccessibleName = "Relationship";
            this.New_relationship.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_relationship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.New_relationship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New_relationship.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_relationship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_relationship.ForeColor = System.Drawing.Color.Cornsilk;
            this.New_relationship.Location = new System.Drawing.Point(3, 65);
            this.New_relationship.Name = "New_relationship";
            this.New_relationship.Size = new System.Drawing.Size(171, 56);
            this.New_relationship.TabIndex = 2;
            this.New_relationship.Text = "Relationship";
            this.New_relationship.UseVisualStyleBackColor = false;
            this.New_relationship.Click += new System.EventHandler(this.New_relationship_Click);
            // 
            // new_attribute
            // 
            this.new_attribute.AccessibleDescription = "click to create an attribute";
            this.new_attribute.AccessibleName = "Attribute";
            this.new_attribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_attribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.new_attribute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_attribute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_attribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_attribute.ForeColor = System.Drawing.Color.Cornsilk;
            this.new_attribute.Location = new System.Drawing.Point(3, 127);
            this.new_attribute.Name = "new_attribute";
            this.new_attribute.Size = new System.Drawing.Size(171, 56);
            this.new_attribute.TabIndex = 3;
            this.new_attribute.Text = "Attribute";
            this.new_attribute.UseVisualStyleBackColor = false;
            // 
            // new_specialization
            // 
            this.new_specialization.AccessibleDescription = "click to create a specialization";
            this.new_specialization.AccessibleName = "Specialization";
            this.new_specialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_specialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.new_specialization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_specialization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_specialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_specialization.ForeColor = System.Drawing.Color.Cornsilk;
            this.new_specialization.Location = new System.Drawing.Point(3, 189);
            this.new_specialization.Name = "new_specialization";
            this.new_specialization.Size = new System.Drawing.Size(171, 56);
            this.new_specialization.TabIndex = 4;
            this.new_specialization.Text = "Specialization";
            this.new_specialization.UseVisualStyleBackColor = false;
            // 
            // new_generalization
            // 
            this.new_generalization.AccessibleDescription = "click to create a generalization";
            this.new_generalization.AccessibleName = "Generalization";
            this.new_generalization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_generalization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.new_generalization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_generalization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_generalization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_generalization.ForeColor = System.Drawing.Color.Cornsilk;
            this.new_generalization.Location = new System.Drawing.Point(3, 251);
            this.new_generalization.Name = "new_generalization";
            this.new_generalization.Size = new System.Drawing.Size(171, 56);
            this.new_generalization.TabIndex = 5;
            this.new_generalization.Text = "Generalization";
            this.new_generalization.UseVisualStyleBackColor = false;
            // 
            // generate_sql
            // 
            this.generate_sql.AccessibleDescription = "click to generate SQL";
            this.generate_sql.AccessibleName = "SQL";
            this.generate_sql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generate_sql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(1)))), ((int)(((byte)(154)))));
            this.generate_sql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generate_sql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_sql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_sql.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_sql.ForeColor = System.Drawing.Color.Yellow;
            this.generate_sql.Location = new System.Drawing.Point(3, 561);
            this.generate_sql.Name = "generate_sql";
            this.generate_sql.Size = new System.Drawing.Size(171, 56);
            this.generate_sql.TabIndex = 6;
            this.generate_sql.Text = "SQL generator ⚡";
            this.generate_sql.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AccessibleDescription = "Inital screen\'s moonSql";
            this.AccessibleName = "home";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.layout);
            this.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moon SQL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.layout.ResumeLayout(false);
            this.toolBox.ResumeLayout(false);
            this.tableButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.GroupBox toolBox;
        private System.Windows.Forms.Panel paint;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button new_entity;
        private System.Windows.Forms.Button New_relationship;
        private System.Windows.Forms.Button new_attribute;
        private System.Windows.Forms.Button new_specialization;
        private System.Windows.Forms.Button new_generalization;
        private System.Windows.Forms.Button generate_sql;
    }
}

