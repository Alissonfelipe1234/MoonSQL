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
            this.category_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_primary = new System.Windows.Forms.CheckBox();
            this.cb_opcional = new System.Windows.Forms.CheckBox();
            this.card_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.attr_btn4 = new System.Windows.Forms.Button();
            this.attr_btn2 = new System.Windows.Forms.Button();
            this.attr_btn3 = new System.Windows.Forms.Button();
            this.attr_btn1 = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_attr = new System.Windows.Forms.TextBox();
            this.type_lbl = new System.Windows.Forms.Label();
            this.combo_attr = new System.Windows.Forms.ComboBox();
            this.attr_table = new System.Windows.Forms.TableLayoutPanel();
            this.save_attr = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            this.toolBox.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.attr_table.SuspendLayout();
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
            this.layout.Controls.Add(this.toolBox, 1, 1);
            this.layout.Controls.Add(this.paint, 2, 1);
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
            this.new_attribute.Click += new System.EventHandler(this.new_attribute_Click);
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
            this.new_specialization.Click += new System.EventHandler(this.new_specialization_Click);
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
            this.new_generalization.Click += new System.EventHandler(this.new_generalization_Click);
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
            this.generate_sql.Click += new System.EventHandler(this.generate_sql_Click);
            // 
            // category_lbl
            // 
            this.category_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.category_lbl.AutoSize = true;
            this.category_lbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.category_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.category_lbl.Location = new System.Drawing.Point(213, 149);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(204, 23);
            this.category_lbl.TabIndex = 11;
            this.category_lbl.Text = "Category";
            this.category_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cb_opcional, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_primary, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(423, 110);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cb_primary
            // 
            this.cb_primary.AutoSize = true;
            this.cb_primary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_primary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_primary.Location = new System.Drawing.Point(3, 3);
            this.cb_primary.Name = "cb_primary";
            this.cb_primary.Size = new System.Drawing.Size(72, 20);
            this.cb_primary.TabIndex = 1;
            this.cb_primary.Text = "Primary";
            this.cb_primary.UseVisualStyleBackColor = true;
            this.cb_primary.CheckedChanged += new System.EventHandler(this.cb_primary_CheckedChanged);
            // 
            // cb_opcional
            // 
            this.cb_opcional.AutoSize = true;
            this.cb_opcional.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_opcional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_opcional.Location = new System.Drawing.Point(3, 53);
            this.cb_opcional.Name = "cb_opcional";
            this.cb_opcional.Size = new System.Drawing.Size(78, 20);
            this.cb_opcional.TabIndex = 2;
            this.cb_opcional.Text = "Opcional";
            this.cb_opcional.UseVisualStyleBackColor = true;
            this.cb_opcional.CheckedChanged += new System.EventHandler(this.cb_opcional_CheckedChanged);
            // 
            // card_lbl
            // 
            this.card_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.card_lbl.AutoSize = true;
            this.card_lbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.card_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.card_lbl.Location = new System.Drawing.Point(633, 149);
            this.card_lbl.Name = "card_lbl";
            this.card_lbl.Size = new System.Drawing.Size(204, 23);
            this.card_lbl.TabIndex = 12;
            this.card_lbl.Text = "Cardinality";
            this.card_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.attr_btn1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.attr_btn3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.attr_btn2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.attr_btn4, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(843, 110);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // attr_btn4
            // 
            this.attr_btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.attr_btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attr_btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attr_btn4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn4.Location = new System.Drawing.Point(102, 63);
            this.attr_btn4.Name = "attr_btn4";
            this.attr_btn4.Size = new System.Drawing.Size(65, 23);
            this.attr_btn4.TabIndex = 3;
            this.attr_btn4.Text = "N, N";
            this.attr_btn4.UseVisualStyleBackColor = false;
            // 
            // attr_btn2
            // 
            this.attr_btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.attr_btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attr_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attr_btn2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn2.Location = new System.Drawing.Point(102, 13);
            this.attr_btn2.Name = "attr_btn2";
            this.attr_btn2.Size = new System.Drawing.Size(65, 23);
            this.attr_btn2.TabIndex = 2;
            this.attr_btn2.Text = "1, N";
            this.attr_btn2.UseVisualStyleBackColor = false;
            // 
            // attr_btn3
            // 
            this.attr_btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.attr_btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attr_btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attr_btn3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn3.Location = new System.Drawing.Point(31, 63);
            this.attr_btn3.Name = "attr_btn3";
            this.attr_btn3.Size = new System.Drawing.Size(65, 23);
            this.attr_btn3.TabIndex = 1;
            this.attr_btn3.Text = "N, 1";
            this.attr_btn3.UseVisualStyleBackColor = false;
            // 
            // attr_btn1
            // 
            this.attr_btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.attr_btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attr_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attr_btn1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn1.Location = new System.Drawing.Point(31, 13);
            this.attr_btn1.Name = "attr_btn1";
            this.attr_btn1.Size = new System.Drawing.Size(65, 23);
            this.attr_btn1.TabIndex = 0;
            this.attr_btn1.Text = "1, 1";
            this.attr_btn1.UseVisualStyleBackColor = false;
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.name_lbl.Location = new System.Drawing.Point(213, 42);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(204, 23);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Name";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name_attr
            // 
            this.name_attr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_attr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_attr.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_attr.Location = new System.Drawing.Point(423, 40);
            this.name_attr.Name = "name_attr";
            this.name_attr.Size = new System.Drawing.Size(204, 26);
            this.name_attr.TabIndex = 4;
            this.name_attr.TextChanged += new System.EventHandler(this.name_attr_TextChanged);
            // 
            // type_lbl
            // 
            this.type_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.type_lbl.AutoSize = true;
            this.type_lbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.type_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.type_lbl.Location = new System.Drawing.Point(633, 42);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(204, 23);
            this.type_lbl.TabIndex = 10;
            this.type_lbl.Text = "Type";
            this.type_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combo_attr
            // 
            this.combo_attr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_attr.AutoCompleteCustomSource.AddRange(new string[] {
            "varchar",
            "char",
            "text",
            "integer",
            "int",
            "float",
            "double",
            "boolean",
            "json",
            "binary",
            "decimal",
            "date",
            "time",
            "datetime",
            "year"});
            this.combo_attr.DisplayMember = "(nenhum)";
            this.combo_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_attr.FormattingEnabled = true;
            this.combo_attr.Items.AddRange(new object[] {
            "varchar",
            "char",
            "text",
            "integer",
            "int",
            "float",
            "double",
            "boolean",
            "json",
            "binary",
            "decimal",
            "date",
            "time",
            "datetime",
            "year"});
            this.combo_attr.Location = new System.Drawing.Point(843, 40);
            this.combo_attr.Name = "combo_attr";
            this.combo_attr.Size = new System.Drawing.Size(204, 26);
            this.combo_attr.TabIndex = 5;
            // 
            // attr_table
            // 
            this.attr_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(2)))), ((int)(((byte)(221)))));
            this.attr_table.ColumnCount = 6;
            this.attr_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.attr_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.attr_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.attr_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.attr_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.attr_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.attr_table.Controls.Add(this.combo_attr, 4, 0);
            this.attr_table.Controls.Add(this.type_lbl, 3, 0);
            this.attr_table.Controls.Add(this.name_attr, 2, 0);
            this.attr_table.Controls.Add(this.name_lbl, 1, 0);
            this.attr_table.Controls.Add(this.tableLayoutPanel3, 4, 1);
            this.attr_table.Controls.Add(this.card_lbl, 3, 1);
            this.attr_table.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.attr_table.Controls.Add(this.category_lbl, 1, 1);
            this.attr_table.Controls.Add(this.save_attr, 3, 2);
            this.attr_table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.attr_table.Location = new System.Drawing.Point(0, 357);
            this.attr_table.Name = "attr_table";
            this.attr_table.RowCount = 3;
            this.attr_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.attr_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.attr_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.attr_table.Size = new System.Drawing.Size(1264, 324);
            this.attr_table.TabIndex = 1;
            this.attr_table.Visible = false;
            // 
            // save_attr
            // 
            this.save_attr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.save_attr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(1)))), ((int)(((byte)(124)))));
            this.save_attr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_attr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_attr.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_attr.Location = new System.Drawing.Point(633, 257);
            this.save_attr.Name = "save_attr";
            this.save_attr.Size = new System.Drawing.Size(204, 23);
            this.save_attr.TabIndex = 13;
            this.save_attr.Text = "Save";
            this.save_attr.UseVisualStyleBackColor = false;
            this.save_attr.Click += new System.EventHandler(this.save_attr_Click);
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
            this.Controls.Add(this.attr_table);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.attr_table.ResumeLayout(false);
            this.attr_table.PerformLayout();
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
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cb_opcional;
        private System.Windows.Forms.CheckBox cb_primary;
        private System.Windows.Forms.Label card_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button attr_btn1;
        private System.Windows.Forms.Button attr_btn3;
        private System.Windows.Forms.Button attr_btn2;
        private System.Windows.Forms.Button attr_btn4;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_attr;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.ComboBox combo_attr;
        private System.Windows.Forms.TableLayoutPanel attr_table;
        private System.Windows.Forms.Button save_attr;
    }
}

