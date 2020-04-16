using moonSql.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace moonSql
{
    public partial class Home : Form
    {
        private Bitmap bitmap;
        private Graphics graphic;

        private readonly List<Drawable> drawables;
        private string status;
        private int clickCounter;
        private Drawable selected;
        private Drawable previous;
        public Home()
        {
            drawables = new List<Drawable>();
            InitializeComponent();
            RestartPaint();
            this.status = "";
            this.clickCounter = 0;
        }
              
        private void Home_Resize(object sender, System.EventArgs e)
        {
            RestartPaint();
        }
        private void Paint_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.status.Equals("new entity"))
            {
                string name = InputBox("new entity", "give the name");
                Entity new_e = new Entity(e.X, e.Y, name);
                new_e.DrawIt(this.graphic);
                drawables.Add(new_e);
                this.status = "";
            }
            else if (this.status.Equals("new relationship"))
            {
                string name = InputBox("new relationship", "put relationship's name");
                Relationship new_r = new Relationship(e.X, e.Y, name);
                this.previous = new_r;
                new_r.DrawIt(this.graphic);
                InputMessage("Choose entity", "Click on " + this.clickCounter + " entities");
                this.status = "creating relationship";
            }
            else if (this.status.Equals("creating relationship"))
            {
                if (this.clickCounter > 0)
                {
                    this.selected = EntityHere(e.X, e.Y);
                    if (this.selected != null)
                    {
                        Relationship pre = (Relationship)this.previous;
                        bool min = InputCardinality("Cardinality for relationship", "choose minimum cardinality");
                        bool max = InputCardinality("Cardinality for relationship", "choose maximum cardinality");
                        Cardinality new_c = new Cardinality((this.selected.GetX() + 50), (this.selected.GetY() + 35), (min ? "1" : "N"), (max ? "1" : "N"));
                        this.drawables.Add(new_c);
                        pre.AddChild(this.selected, new_c);
                        this.previous.DrawIt(this.graphic);
                        this.clickCounter--;
                        if (this.clickCounter == 0)
                        {
                            this.drawables.Add(this.previous);
                            this.previous = null;
                            this.status = "";
                        }
                    }
                }
            }
            else if (this.status.Equals("new special"))
            {
                Specialization new_s = new Specialization(e.X, e.Y);
                this.previous = new_s;
                this.drawables.Add(new_s);
                this.status = "selecting special";
                new_s.DrawIt(this.graphic);
            }
            else if (this.status.Equals("selecting special"))
            {
                this.selected = EntityHere(e.X, e.Y);
                if (this.selected != null)
                {
                    Specialization new_s = (Specialization)this.previous;
                    new_s.SetSpecial((Entity)this.selected);

                    new_s.DrawIt(this.graphic);
                    string click = InputBox("Specialization configuration", "number of specializations");
                    this.clickCounter = Int32.Parse(click);
                    this.status = "creating a special";
                }
            }
            else if (this.status.Equals("creating a special"))
            {
                this.selected = EntityHere(e.X, e.Y);
                if (this.selected != null && this.clickCounter > 0)
                {
                    Specialization new_s = (Specialization)this.previous;

                    new_s.addEntity((Entity)this.selected);
                    new_s.DrawIt(this.graphic);
                    this.clickCounter--;
                    if (this.clickCounter == 0)
                        this.status = "";
                }
            }
            else if (this.status.Equals("new generic"))
            {
                Generalization new_s = new Generalization(e.X, e.Y);
                this.previous = new_s;
                this.drawables.Add(new_s);
                this.status = "selecting generic";
                new_s.DrawIt(this.graphic);
            }
            else if (this.status.Equals("selecting generic"))
            {
                this.selected = EntityHere(e.X, e.Y);
                if (this.selected != null)
                {
                    Generalization new_s = (Generalization)this.previous;
                    new_s.SetGeneric((Entity)this.selected);

                    new_s.DrawIt(this.graphic);
                    string click = InputBox("Generalization configuration", "number of generalizations");
                    this.clickCounter = Int32.Parse(click);
                    this.status = "creating a generic";
                }
            }
            else if (this.status.Equals("creating a generic"))
            {
                this.selected = EntityHere(e.X, e.Y);
                if (this.selected != null && this.clickCounter > 0)
                {
                    Generalization new_s = (Generalization)this.previous;

                    new_s.addEntity((Entity)this.selected);
                    new_s.DrawIt(this.graphic);
                    this.clickCounter--;
                    if (this.clickCounter == 0)
                        this.status = "";
                }
            }
            else if (this.status.Equals("new attribute"))
            {
                Drawable draw = WhatIsThere(e.X, e.Y);
                if((draw != null) && (draw.GetType() == typeof(Entity) || draw.GetType() == typeof(Relationship)))
                {
                    Attr attr = new Attr(draw.GetX(), draw.GetY(), draw);
                    attr.DrawIt(graphic);
                    AddOwner(attr, draw);
                    this.drawables.Add(attr);
                    this.previous = attr;
                    RestoreAttr();
                    this.status = "";
                }
            }
            else
                status = "";
            paint.Refresh();
        }
        public void RestoreAttr()
        {
            Attr attr = (Attr)this.previous;
            name_attr.Text = attr.GetName();
            combo_attr.Text = attr.data;
            cb_opcional.Checked = attr.Optional;
            cb_primary.Checked = attr.Primary;
            layout.Enabled = false;
            attr_table.Visible = true;

        }
        private void RestartPaint()
        {
            bitmap = new Bitmap(paint.Width, paint.Height);
            graphic = Graphics.FromImage(bitmap);
            graphic.Clear(Color.FloralWhite);
            paint.BackgroundImage = bitmap;
            DrawAll();
            paint.Refresh();
        }
        private void DrawAll()
        {
            foreach (Drawable draw in drawables)
                draw.DrawIt(this.graphic);
        }
        private Drawable WhatIsThere(int x, int y)
        {
            for (int i = drawables.Count - 1; i >= 0; i--)
            {
                if (drawables[i].IsThere(x, y))
                {
                    return drawables[i];
                }
            }

            return null;
        }
        private Entity EntityHere(int x, int y)
        {
            for (int i = drawables.Count - 1; i >= 0; i--)
            {
                if (drawables[i].IsThere(x, y) && drawables[i].GetType() == typeof(Entity))
                {
                    return (Entity) drawables[i];
                }
            }

            return null;
        }
        private void AddOwner(Attr attr, Drawable draw)
        {
            if(draw.GetType() == typeof(Entity))
                ((Entity)draw).AddChild(attr);
            else
                ((Relationship)draw).AddAttr(attr);
        }
        private void New_entity_Click(object sender, System.EventArgs e)
        {
            if(this.status == "")
                this.status = "new entity";            
        }
        private void New_relationship_Click(object sender, EventArgs e)
        {
            if (this.status == "")
            {
                string kind = InputBox("Relationshiop configuration", "how many entities? 1(unary), 2(binary), 3(ternary)");
                this.status = "new relationship";
                switch (kind)
                {
                    case "1":
                        this.clickCounter = 1;
                        break;
                    case "3":
                        this.clickCounter = 3;
                        break;
                    default:
                        this.clickCounter = 2;
                        break;
                }
            }
        }
        private void new_specialization_Click(object sender, EventArgs e)
        {
            if (this.status == "")
                this.status = "new special";
        }
        private void new_generalization_Click(object sender, EventArgs e)
        {
            if (this.status == "")
                this.status = "new generic";
        }
        private void new_attribute_Click(object sender, EventArgs e)
        {
            if (this.status == "")
                this.status = "new attribute";
        }
        private void save_attr_Click(object sender, EventArgs e)
        {
            layout.Enabled = true;
            attr_table.Visible = false;
        }
        private void name_attr_TextChanged(object sender, EventArgs e)
        {
            ((Attr)this.previous).SetName(name_attr.Text);
            graphic.Clear(Color.FloralWhite);
            DrawAll();
            paint.Refresh();
        }
        private void cb_primary_CheckedChanged(object sender, EventArgs e)
        {
            Attr attr = (Attr)this.previous;
            if (attr.Optional && cb_primary.Checked)
            {
                attr.Optional = false;
                cb_opcional.Checked = false;
            }
            if (cb_primary.Checked)
                attr.SetXY(attr.GetX(), attr.GetY() - 75);
            else
                attr.SetXY(attr.GetX(), attr.GetY() + 75);
            attr.Primary = cb_primary.Checked;
            graphic.Clear(Color.FloralWhite);
            DrawAll();
            paint.Refresh();
        }
        private void cb_opcional_CheckedChanged(object sender, EventArgs e)
        {
            Attr attr = (Attr)this.previous;
            if (attr.Primary && cb_opcional.Checked)
            {
                attr.Primary = false;
                cb_primary.Checked = false;
            }
            if (cb_opcional.Checked)
                attr.SetXY(attr.GetX() - 52, attr.GetY() - 75);
            else
                attr.SetXY(attr.GetX() + 52, attr.GetY() + 75);
            attr.Optional = cb_opcional.Checked;
            graphic.Clear(Color.FloralWhite);
            DrawAll();
            paint.Refresh();
        }
        public static string InputBox(string title, string promptText)
        {
            Form form = new Form();

            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = "";

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(35, 15, 100, 25);
            textBox.SetBounds(35, 30, 350, 25);
            buttonOk.SetBounds(310, 70, 75, 25);

            label.AutoSize = true;
            textBox.Anchor |= AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 110);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            form.ShowDialog();
            return textBox.Text;

        }
        public static bool InputMessage(string title, string promptText)
        {
            Form form = new Form();


            Label label = new Label();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(35, 35, 100, 25);
            buttonOk.SetBounds(220, 70, 75, 25);
            buttonCancel.SetBounds(310, 70, 75, 25);

            label.AutoSize = true;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 110);
            form.Controls.AddRange(new Control[] { label, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            return DialogResult.OK == form.ShowDialog();
        }
        public static bool InputCardinality(string title, string promptText)
        {
            Form form = new Form();

            Label label = new Label();
            Button button1 = new Button();
            Button buttonN = new Button();

            form.Text = title;
            label.Text = promptText;

            button1.Text = "1";
            button1.DialogResult = DialogResult.OK;
            buttonN.Text = "N";
            buttonN.DialogResult = DialogResult.Cancel;

            label.SetBounds(35, 15, 100, 25);
            button1.SetBounds(135, 70, 75, 25);
            buttonN.SetBounds(300, 70, 75, 25);

            label.AutoSize = true;
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(400, 110);
            form.Controls.AddRange(new Control[] { label, button1, buttonN });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonN;


            return (DialogResult.OK == form.ShowDialog());
        }
        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            this.selected = WhatIsThere(e.X, e.Y);            
        }
        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            if (selected != null && selected.GetType() == typeof(Attr))
            {
                previous = selected;
                RestoreAttr();
            }
            this.selected = null;
        }
        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (null != this.selected)
            {
                this.selected.SetXY(e.X, e.Y);
                this.graphic.Clear(Color.FloralWhite);
                DrawAll();
                paint.Refresh();
            }
        }

        private void generate_sql_Click(object sender, EventArgs e)
        {
            string sqlGerado = "teste";
            this.Hide();
            this.Visible = false;

            Result window = new Result(sqlGerado, this);
            window.Show();
            window.Visible = true;
            
        }
    }
}
