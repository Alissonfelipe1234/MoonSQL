namespace moonSql
{
    partial class Form1
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
            this.attr_table = new System.Windows.Forms.TableLayoutPanel();
            this.cb_primary = new System.Windows.Forms.CheckBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_attr = new System.Windows.Forms.TextBox();
            this.combo_attr = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.attr_btn1 = new System.Windows.Forms.Button();
            this.type_lbl = new System.Windows.Forms.Label();
            this.category_lbl = new System.Windows.Forms.Label();
            this.card_lbl = new System.Windows.Forms.Label();
            this.attr_btn3 = new System.Windows.Forms.Button();
            this.attr_btn2 = new System.Windows.Forms.Button();
            this.attr_btn4 = new System.Windows.Forms.Button();
            this.cb_opcional = new System.Windows.Forms.CheckBox();
            this.attr_table.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // attr_table
            // 
            this.attr_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(2)))), ((int)(((byte)(121)))));
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
            this.attr_table.Location = new System.Drawing.Point(0, 357);
            this.attr_table.Name = "attr_table";
            this.attr_table.RowCount = 3;
            this.attr_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.attr_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.attr_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.attr_table.Size = new System.Drawing.Size(1264, 324);
            this.attr_table.TabIndex = 0;
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
            this.name_attr.Location = new System.Drawing.Point(423, 44);
            this.name_attr.Name = "name_attr";
            this.name_attr.Size = new System.Drawing.Size(204, 26);
            this.name_attr.TabIndex = 4;
            // 
            // combo_attr
            // 
            this.combo_attr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_attr.FormattingEnabled = true;
            this.combo_attr.Location = new System.Drawing.Point(843, 40);
            this.combo_attr.Name = "combo_attr";
            this.combo_attr.Size = new System.Drawing.Size(204, 26);
            this.combo_attr.TabIndex = 5;
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
            // attr_btn1
            // 
            this.attr_btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn1.Location = new System.Drawing.Point(31, 13);
            this.attr_btn1.Name = "attr_btn1";
            this.attr_btn1.Size = new System.Drawing.Size(65, 23);
            this.attr_btn1.TabIndex = 0;
            this.attr_btn1.Text = "1, 1";
            this.attr_btn1.UseVisualStyleBackColor = true;
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
            // attr_btn3
            // 
            this.attr_btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn3.Location = new System.Drawing.Point(31, 63);
            this.attr_btn3.Name = "attr_btn3";
            this.attr_btn3.Size = new System.Drawing.Size(65, 23);
            this.attr_btn3.TabIndex = 1;
            this.attr_btn3.Text = "N, 1";
            this.attr_btn3.UseVisualStyleBackColor = true;
            // 
            // attr_btn2
            // 
            this.attr_btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn2.Location = new System.Drawing.Point(102, 13);
            this.attr_btn2.Name = "attr_btn2";
            this.attr_btn2.Size = new System.Drawing.Size(65, 23);
            this.attr_btn2.TabIndex = 2;
            this.attr_btn2.Text = "1, N";
            this.attr_btn2.UseVisualStyleBackColor = true;
            // 
            // attr_btn4
            // 
            this.attr_btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attr_btn4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attr_btn4.Location = new System.Drawing.Point(102, 63);
            this.attr_btn4.Name = "attr_btn4";
            this.attr_btn4.Size = new System.Drawing.Size(65, 23);
            this.attr_btn4.TabIndex = 3;
            this.attr_btn4.Text = "N, N";
            this.attr_btn4.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.attr_table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.attr_table.ResumeLayout(false);
            this.attr_table.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel attr_table;
        private System.Windows.Forms.CheckBox cb_primary;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_attr;
        private System.Windows.Forms.ComboBox combo_attr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button attr_btn1;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.Label card_lbl;
        private System.Windows.Forms.Button attr_btn3;
        private System.Windows.Forms.Button attr_btn2;
        private System.Windows.Forms.Button attr_btn4;
        private System.Windows.Forms.CheckBox cb_opcional;
    }
}