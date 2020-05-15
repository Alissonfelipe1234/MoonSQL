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
                if ((draw != null) && (draw.GetType() == typeof(Entity) || draw.GetType() == typeof(Relationship)))
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
                    return (Entity)drawables[i];
                }
            }

            return null;
        }
        private void AddOwner(Attr attr, Drawable draw)
        {
            if (draw.GetType() == typeof(Entity))
                ((Entity)draw).AddChild(attr);
            else
                ((Relationship)draw).AddAttr(attr);
        }
        private void New_entity_Click(object sender, System.EventArgs e)
        {
            if (this.status == "")
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
            this.Hide();
            this.Visible = false;
            string finale = SQL_generator();

            Result window = new Result(finale, this);
            window.Show();
            window.Visible = true;

        }
        private string SQL_generator()
        {
            string generate = "CREATE DATABASE IF NOT EXISTS moonsql ;\nUSE moonsql;\n";
            Dictionary<Entity, string> sql = new Dictionary<Entity, string>();
            Dictionary<Drawable, string> tablesAltenative = new Dictionary<Drawable, string>();
            Dictionary<Entity, Attr> PK = new Dictionary<Entity, Attr>();
            foreach (Drawable draw in drawables)
            {
                if (draw.GetType() == typeof(Entity))
                {

                    Entity ent = (Entity)draw;
                    sql.Add(ent, "Create Table " + ent.GetName() + " (\n");
                }
            }
            foreach (Drawable attrs in drawables)
            {
                if (attrs.GetType() == typeof(Attr))
                {
                    Attr attribute = (Attr)attrs;
                    if (attribute.GetOwner().GetType() == typeof(Entity))
                    {
                        if (attribute.Primary)
                        {
                            try
                            {
                                PK.Add((Entity)attribute.GetOwner(), attribute);
                            }
                            catch { }
                        }
                        if (attribute.Max == 1)
                        {
                            Entity ownerEntity = (Entity)attribute.GetOwner();
                            sql[ownerEntity] += attribute.GetSql();
                            if (attribute.GetIndex() + 1 != ownerEntity.GetAttrs())
                                sql[ownerEntity] += ",\n";
                        }
                        else
                        {
                            Entity entityMulti = (Entity)attribute.GetOwner();
                            string name = attribute.GetName().Split(' ')[0];
                            sql[entityMulti] += name + "FK integer";
                            if (attribute.Min != 0)
                                sql[entityMulti] += " NOT NULL";
                            if (attribute.GetIndex() + 1 != entityMulti.GetAttrs())
                                sql[entityMulti] += ",\n";

                            tablesAltenative.Add(attribute, "Create Table " + name + " (\n");
                            tablesAltenative[attribute] += "ID" + name + " serial Primary Key,\n";
                            tablesAltenative[attribute] += attribute.GetSql() + ",\n";
                            tablesAltenative[attribute] += entityMulti.GetName() + "FK integer,\n";
                            tablesAltenative[attribute] += "CONSTRAINT " + name + "_" + entityMulti.GetName() + " FOREIGN KEY(FK" + entityMulti.GetName() + ")\n";
                            tablesAltenative[attribute] += "REFERENCES " + entityMulti.GetName() + "(" + name + "FK)\n)";
                            tablesAltenative[attribute] += ");";
                        }
                    }
                }
            }
            foreach (Drawable relations in drawables)
            {
                if (relations.GetType() == typeof(Relationship))
                {
                    Relationship relaty = (Relationship)relations;
                    int envolvidos = relaty.GetSize();
                    switch (envolvidos)
                    {
                        case 1:
                            Entity major = (Entity)relaty.GetChilds()[0].Item1;
                            if (PK.ContainsKey(major))
                            {
                                if (major.GetAttrs() > 0)
                                    sql[major] += ",\n" + major.GetName() + "ID Integer PRIMARY KEY";
                                else
                                    sql[major] += major.GetName() + "ID Integer PRIMARY KEY";
                            }

                            sql[major] += ",\n" + relaty.GetName();
                            if (relaty.GetChilds()[0].Item2.GetMin().Equals("1"))
                                sql[major] += " NOT NULL";
                            try { sql[major] += " FOREIGN KEY REFERENCES " + major.GetName() + "(" + PK[major].GetName() + ")"; }
                            catch { sql[major] += " FOREIGN KEY REFERENCES " + major.GetName() + "(" + major.GetName() + "ID  )"; }
                            break;
                        case 2:
                            Entity major1 = (Entity)relaty.GetChilds()[0].Item1;
                            Entity major2 = (Entity)relaty.GetChilds()[0].Item1;
                            Cardinality card1 = relaty.GetChilds()[0].Item2;
                            Cardinality card2 = relaty.GetChilds()[0].Item2;
                            if (card1.GetMax().Equals("1") && card2.GetMax().Equals("1"))
                            {
                                if (card1.GetMin().Equals("1"))
                                {
                                    if (major1.GetAttrs() > 0)
                                        sql[major1] += ",\n" + major2.GetName() + " Integer";
                                    else
                                        sql[major1] += major2.GetName() + " Integer";
                                    if (card2.GetMin().Equals("1"))
                                        sql[major1] += " NOT NULL";
                                    try { sql[major1] += " FOREIGN KEY REFERENCES " + major2.GetName() + "(" + PK[major2].GetName() + ")"; }
                                    catch
                                    {
                                        sql[major1] += " FOREIGN KEY REFERENCES " + major2.GetName() + "(" + major2.GetName() + "ID  )";
                                        if (major2.GetAttrs() > 0)
                                            sql[major2] += ",\n" + major2.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[major2] += major2.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relaty.GetAttrs();
                                    if (atr > 0)
                                    {
                                        sql[major1] += ",\n";
                                        foreach (Drawable figuresIT in drawables)
                                        {
                                            if (figuresIT.GetType() == typeof(Attr))
                                            {
                                                Attr maybe = (Attr)figuresIT;
                                                if (maybe.GetOwner() == relaty)
                                                {
                                                    sql[major1] += maybe.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[major1] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (major2.GetAttrs() > 0)
                                        sql[major2] += ",\n" + major1.GetName() + " Integer";
                                    else
                                        sql[major2] += major1.GetName() + " Integer";
                                    if (card2.GetMin().Equals("1"))
                                        sql[major2] += " NOT NULL";
                                    try { sql[major2] += " FOREIGN KEY REFERENCES " + major1.GetName() + "(" + PK[major1].GetName() + ")"; }
                                    catch
                                    {
                                        sql[major2] += " FOREIGN KEY REFERENCES " + major1.GetName() + "(" + major1.GetName() + "ID  )";
                                        if (major1.GetAttrs() > 0)
                                            sql[major1] += ",\n" + major1.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[major1] += major1.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relaty.GetAttrs();
                                    if (atr > 0)
                                    {
                                        sql[major2] += ",\n";
                                        foreach (Drawable figuresIR in drawables)
                                        {
                                            if (figuresIR.GetType() == typeof(Attr))
                                            {
                                                Attr maybe = (Attr)figuresIR;
                                                if (maybe.GetOwner() == relaty)
                                                {
                                                    sql[major2] += maybe.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[major2] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }

                                }
                            }
                            else if (!card1.GetMax().Equals(card2.GetMax()))
                            {
                                if (card1.GetMax().Equals("N"))
                                {
                                    sql[major1] += ",\n" + major2.GetName() + " Integer";
                                    if (card2.GetMin().Equals("1"))
                                        sql[major1] += " NOT NULL";
                                    try { sql[major1] += " FOREIGN KEY REFERENCES " + major2.GetName() + "(" + PK[major2].GetName() + ")"; }
                                    catch
                                    {

                                        sql[major1] += " FOREIGN KEY REFERENCES " + major2.GetName() + "(" + major2.GetName() + "ID  )";
                                        if (major2.GetAttrs() > 0)
                                            sql[major2] += ",\n" + major2.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[major2] += major2.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relaty.GetAttrs();
                                    if (atr > 0)
                                    {
                                        sql[major1] += ",\n";
                                        foreach (Drawable figuresIE in drawables)
                                        {
                                            if (figuresIE.GetType() == typeof(Attr))
                                            {
                                                Attr maybe = (Attr)figuresIE;
                                                if (maybe.GetOwner() == relaty)
                                                {
                                                    sql[major1] += maybe.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[major1] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    sql[major2] += ",\n" + major1.GetName() + " Integer";
                                    if (card2.GetMin().Equals("1"))
                                        sql[major2] += " NOT NULL";
                                    try { sql[major2] += " FOREIGN KEY REFERENCES " + major1.GetName() + "(" + PK[major1].GetName() + ")"; }
                                    catch
                                    {
                                        sql[major2] += " FOREIGN KEY REFERENCES " + major1.GetName() + "(" + major1.GetName() + "ID  )";
                                        if (major1.GetAttrs() > 0)
                                            sql[major1] += ",\n" + major1.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[major1] += major1.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relaty.GetAttrs();
                                    if (atr > 0)
                                    {
                                        sql[major2] += ",\n";
                                        foreach (Drawable figuresIW in drawables)
                                        {
                                            if (figuresIW.GetType() == typeof(Attr))
                                            {
                                                Attr maybe = (Attr)figuresIW;
                                                if (maybe.GetOwner() == relaty)
                                                {
                                                    sql[major2] += maybe.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        sql[major2] += ",\n";
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
                                tablesAltenative.Add(relaty, "Create Table " + relaty.GetSize() + " (\n");
                                try
                                {
                                    tablesAltenative[relaty] += PK[major1].GetSql() + ",\n";
                                }
                                catch
                                {
                                    tablesAltenative[relaty] += major1.GetName() + "ID  integer,\n";
                                    Attr newd = new Attr(-50, -50, major1);
                                    newd.SetName(major1.GetName() + "ID");
                                    PK.Add(major1, newd);
                                    if (major1.GetAttrs() > 0)
                                        sql[major1] += ",\n" + major1.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[major1] += major1.GetName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relaty] += PK[major2].GetSql();
                                }
                                catch
                                {
                                    tablesAltenative[relaty] += major2.GetName() + "ID  integer";
                                    Attr newd = new Attr(-50, -50, major2);
                                    newd.SetName(major2.GetName() + "ID");
                                    PK.Add(major2, newd);
                                    if (major1.GetAttrs() > 0)
                                        sql[major2] += ",\n" + major2.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[major2] += major2.GetName() + "ID Integer PRIMARY KEY";
                                }
                                int atr = relaty.GetAttrs();
                                if (atr > 0)
                                {
                                    foreach (Drawable figuresIQ in drawables)
                                    {

                                        if (figuresIQ.GetType() == typeof(Attr))
                                        {
                                            Attr maybe = (Attr)figuresIQ;
                                            if (maybe.GetOwner() == relaty)
                                            {
                                                tablesAltenative[relaty] += ",\n";
                                                tablesAltenative[relaty] += maybe.GetSql();
                                                atr--;
                                                if (atr > 0)
                                                    tablesAltenative[relaty] += ",\n";
                                                else
                                                    break;

                                            }
                                        }
                                    }
                                }
                                tablesAltenative[relaty] += ",\nPRIMARY KEY (" + PK[major1].GetName() + ", " + PK[major2].GetName() + "),\n";
                                tablesAltenative[relaty] += "CONTRAINT " + relaty.GetName() + "FK1 FOREIGN KEY (" + PK[major1].GetName() + ")\n";
                                tablesAltenative[relaty] += "REFERENCES " + major1.GetName() + " (" + PK[major1].GetName() + "),\n";
                                tablesAltenative[relaty] += "CONTRAINT " + relaty.GetName() + "FK2 FOREIGN KEY (" + PK[major2].GetName() + ")\n";
                                tablesAltenative[relaty] += "REFERENCES " + major2.GetName() + " (" + PK[major2].GetName() + ")";
                            }
                            break;
                        case 3:
                            Entity tern1 = (Entity)relaty.GetChilds()[0].Item1;
                            Entity tern2 = (Entity)relaty.GetChilds()[1].Item1;
                            Entity tern3 = (Entity)relaty.GetChilds()[2].Item1;
                            Cardinality carT1 = relaty.GetChilds()[0].Item2;
                            Cardinality carT2 = relaty.GetChilds()[1].Item2;
                            Cardinality carT3 = relaty.GetChilds()[2].Item2;

                            //case 1:1:1 or N:N:N
                            if (carT1.GetMax() == carT2.GetMax() && carT1.GetMax() == carT3.GetMax())
                            {
                                tablesAltenative.Add(relaty, "Create Table " + relaty.GetName() + " (\n");
                                try
                                {
                                    tablesAltenative[relaty] += PK[tern1].GetSql() + " FOREIGN KEY REFERENCES " + tern1.GetName() +
                                        "(" + PK[tern1].GetName() + "),\n";
                                }
                                catch
                                {
                                    tablesAltenative[relaty] += tern1.GetName() + "ID  integer PRIMARY KEY FOREIGN " + tern1.GetName() +
                                        "(" + tern1.GetName() + "ID),\n";
                                    PK.Add(tern1, new Attr(-50, -50, tern1));
                                    if (tern1.GetAttrs() > 0)
                                        sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relaty] += PK[tern2].GetSql() + " FOREIGN KEY REFERENCES " + tern2.GetName() +
                                        "(" + PK[tern2].GetName() + "),\n";
                                }
                                catch
                                {
                                    tablesAltenative[relaty] += tern2.GetName() + "ID  integer PRIMARY KEY FOREIGN " + tern2.GetName() +
                                        "(" + tern2.GetName() + "ID),\n";
                                    Attr newd = new Attr(-50, -50, tern2);
                                    newd.SetName(tern2.GetName() + "ID");
                                    PK.Add(tern2, newd);
                                    if (tern2.GetAttrs() > 0)
                                        sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                    else
                                        sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                }
                                try
                                {
                                    tablesAltenative[relaty] += PK[tern3].GetSql() + " FOREIGN KEY REFERENCES " + tern3.GetName() +
                                        "(" + PK[tern3].GetName() + ")";
                                }
                                catch
                                {
                                    tablesAltenative[relaty] += tern3.GetName() + "ID  integer PRIMARY KEY FOREIGN " + tern3.GetName() +
                                        "(" + tern3.GetName() + "ID)";
                                    Attr newd = new Attr(-50, -50, tern3);
                                    newd.SetName(tern3.GetName() + "ID");
                                    PK.Add(tern3, newd);
                                    sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                }
                                int atr = relaty.GetAttrs();
                                if (atr > 0)
                                {
                                    tablesAltenative[relaty] += ",\n";
                                    foreach (Drawable f in drawables)
                                    {
                                        if (f.GetType() == typeof(Attr))
                                        {
                                            Attr maybe = (Attr)f;
                                            if (maybe.GetOwner() == relaty)
                                            {
                                                tablesAltenative[relaty] += maybe.GetSql();
                                                atr--;
                                                if (atr > 0)
                                                    tablesAltenative[relaty] += ",\n";
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
                                if (carT1.GetMax() == "N")
                                    qtdN++;
                                if (carT2.GetMax() == "N")
                                    qtdN++;
                                if (carT3.GetMax() == "N")
                                    qtdN++;
                                if (qtdN == 2)
                                {
                                    tablesAltenative.Add(relaty, "Create Table " + relaty.GetName() + " (\n");
                                    try
                                    {
                                        tablesAltenative[relaty] += PK[tern1].GetName() + " " + PK[tern1].data;
                                        if (carT1.GetMax() == "N")
                                            tablesAltenative[relaty] += " PRIMARY KEY";
                                        tablesAltenative[relaty] += " FOREIGN KEY REFERENCES " + tern1.GetName() +
                                            "(" + PK[tern1].GetName() + "),\n";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relaty] += tern1.GetName() + "ID  integer";
                                        if (carT1.GetMax() == "N")
                                            tablesAltenative[relaty] += " PRIMARY KEY";
                                        tablesAltenative[relaty] += " FOREIGN " + tern1.GetName() +
                                            "(" + tern1.GetName() + "ID),\n";
                                        Attr newd = new Attr(-50, -50, tern1);
                                        newd.SetName(tern1.GetName() + "ID");
                                        PK.Add(tern1, newd);
                                        if (tern1.GetAttrs() > 0)
                                            sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    try
                                    {
                                        tablesAltenative[relaty] += PK[tern2].GetName() + " " + PK[tern2].data;
                                        if (carT1.GetMax() == "N")
                                            tablesAltenative[relaty] += " PRIMARY KEY";
                                        tablesAltenative[relaty] += " FOREIGN KEY REFERENCES " + tern2.GetName() +
                                            "(" + PK[tern2].GetName() + "),\n";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relaty] += tern2.GetName() + "ID  integer";
                                        if (carT1.GetMax() == "N")
                                            tablesAltenative[relaty] += " PRIMARY KEY";
                                        tablesAltenative[relaty] += " FOREIGN " + tern2.GetName() +
                                            "(" + tern2.GetName() + "ID),\n";
                                        Attr newd = new Attr(-50, -50, tern2);
                                        newd.SetName(tern2.GetName() + "ID");
                                        PK.Add(tern2, newd);
                                        if (tern2.GetAttrs() > 0)
                                            sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    try
                                    {
                                        tablesAltenative[relaty] += PK[tern3].GetName() + " " + PK[tern3].data;
                                        if (carT1.GetMax() == "N")
                                            tablesAltenative[relaty] += " PRIMARY KEY";
                                        tablesAltenative[relaty] += " FOREIGN KEY REFERENCES " + tern3.GetName() +
                                            "(" + PK[tern3].GetName() + ")";
                                    }
                                    catch
                                    {
                                        tablesAltenative[relaty] += tern3.GetName() + "ID  integer";
                                        if (carT1.GetMax() == "N")
                                            tablesAltenative[relaty] += " PRIMARY KEY";
                                        tablesAltenative[relaty] += " FOREIGN " + tern3.GetName() +
                                            "(" + tern3.GetName() + "ID)";
                                        Attr newd = new Attr(-50, -50, tern3);
                                        newd.SetName(tern3.GetName() + "ID");
                                        PK.Add(tern3, newd);
                                        if (tern3.GetAttrs() > 0)
                                            sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                        else
                                            sql[tern3] += tern3.GetName() + "ID Integer PRIMARY KEY";
                                    }
                                    int atr = relaty.GetAttrs();
                                    if (atr > 0)
                                    {
                                        tablesAltenative[relaty] += ",\n";
                                        foreach (Drawable f in drawables)
                                        {
                                            if (f.GetType() == typeof(Attr))
                                            {
                                                Attr maybe = (Attr)f;
                                                if (maybe.GetOwner() == relaty)
                                                {
                                                    tablesAltenative[relaty] += maybe.GetSql();
                                                    atr--;
                                                    if (atr > 0)
                                                        tablesAltenative[relaty] += ",\n";
                                                    else
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (carT1.GetMax() == "N")
                                    {
                                        if (tern1.GetAttrs() > 0)
                                            sql[tern1] += ",\n";
                                        try
                                        {
                                            sql[tern1] += PK[tern2].GetName() + "FK FOREIGN KEY REFERENCES " + tern2.GetName() +
                                                "(" + PK[tern2].GetName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern1] += tern2.GetName() + "ID  integer FOREIGN " + tern2.GetName() +
                                                "(" + tern2.GetName() + "ID),\n";
                                            Attr newd = new Attr(-50, -50, tern2);
                                            newd.SetName(tern2.GetName() + "ID");
                                            PK.Add(tern2, newd);
                                            if (tern2.GetAttrs() > 0)
                                                sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern1] += PK[tern3].GetName() + "FK FOREIGN KEY REFERENCES " + tern3.GetName() +
                                                "(" + PK[tern3].GetName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern1] += tern3.GetName() + "ID  integer FOREIGN " + tern3.GetName() +
                                                "(" + tern3.GetName() + "ID)";
                                            Attr newd = new Attr(-50, -50, tern3);
                                            newd.SetName(tern3.GetName() + "ID");
                                            PK.Add(tern3, newd);
                                            if (tern3.GetAttrs() > 0)
                                                sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern3] += tern3.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relaty.GetAttrs();
                                        if (atr > 0)
                                        {
                                            sql[tern1] += ",\n";
                                            foreach (Drawable f in drawables)
                                            {
                                                if (f.GetType() == typeof(Attr))
                                                {
                                                    Attr maybe = (Attr)f;
                                                    if (maybe.GetOwner() == relaty)
                                                    {
                                                        sql[tern1] += maybe.GetSql();
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
                                    else if (carT2.GetMax() == "N")
                                    {
                                        if (tern2.GetAttrs() > 0)
                                            sql[tern2] += ",\n";
                                        try
                                        {
                                            sql[tern2] += PK[tern1].GetName() + "FK FOREIGN KEY REFERENCES " + tern1.GetName() +
                                                "(" + PK[tern1].GetName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern2] += tern1.GetName() + "ID  integer FOREIGN " + tern1.GetName() +
                                                "(" + tern1.GetName() + "ID),\n";
                                            Attr newd = new Attr(-50, -50, tern1);
                                            newd.SetName(tern1.GetName() + "ID");
                                            PK.Add(tern1, newd);
                                            if (tern1.GetAttrs() > 0)
                                                sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern2] += PK[tern3].GetName() + "FK FOREIGN KEY REFERENCES " + tern3.GetName() +
                                                "(" + PK[tern3].GetName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern2] += tern3.GetName() + "ID  integer FOREIGN " + tern3.GetName() +
                                                "(" + tern3.GetName() + "ID)";
                                            Attr newd = new Attr(-50, -50, tern3);
                                            newd.SetName(tern3.GetName() + "ID");
                                            PK.Add(tern3, newd);
                                            if (tern3.GetAttrs() > 0)
                                                sql[tern3] += ",\n" + tern3.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern3] += tern3.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relaty.GetAttrs();
                                        if (atr > 0)
                                        {
                                            sql[tern2] += ",\n";
                                            foreach (Drawable f in drawables)
                                            {
                                                if (f.GetType() == typeof(Attr))
                                                {
                                                    Attr maybe = (Attr)f;
                                                    if (maybe.GetOwner() == relaty)
                                                    {
                                                        sql[tern2] += maybe.GetSql();
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
                                        if (tern2.GetAttrs() > 0)
                                            sql[tern2] += ",\n";
                                        try
                                        {
                                            sql[tern3] += PK[tern1].GetName() + "FK FOREIGN KEY REFERENCES " + tern1.GetName() +
                                                "(" + PK[tern1].GetName() + "),\n";
                                        }
                                        catch
                                        {
                                            sql[tern3] += tern1.GetName() + "ID  integer FOREIGN " + tern1.GetName() +
                                                "(" + tern1.GetName() + "ID),\n";
                                            Attr newd = new Attr(-50, -50, tern1);
                                            newd.SetName(tern1.GetName() + "ID");
                                            PK.Add(tern1, newd);
                                            if (tern1.GetAttrs() > 0)
                                                sql[tern1] += ",\n" + tern1.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern1] += tern1.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        try
                                        {
                                            sql[tern3] += PK[tern2].GetName() + "FK FOREIGN KEY REFERENCES " + tern2.GetName() +
                                                "(" + PK[tern2].GetName() + ")";
                                        }
                                        catch
                                        {
                                            sql[tern3] += tern2.GetName() + "ID  integer FOREIGN " + tern2.GetName() +
                                                "(" + tern2.GetName() + "ID)";
                                            Attr newd = new Attr(-50, -50, tern2);
                                            newd.SetName(tern2.GetName() + "ID");
                                            PK.Add(tern2, newd);
                                            if (tern2.GetAttrs() > 0)
                                                sql[tern2] += ",\n" + tern2.GetName() + "ID Integer PRIMARY KEY";
                                            else
                                                sql[tern2] += tern2.GetName() + "ID Integer PRIMARY KEY";
                                        }
                                        int atr = relaty.GetAttrs();
                                        if (atr > 0)
                                        {
                                            sql[tern3] += ",\n";
                                            foreach (Drawable f in drawables)
                                            {
                                                if (f.GetType() == typeof(Attr))
                                                {
                                                    Attr maybe = (Attr)f;
                                                    if (maybe.GetOwner() == relaty)
                                                    {
                                                        sql[tern3] += maybe.GetSql();
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
            foreach (KeyValuePair<Entity, string> linha in sql)
                generate += linha.Value + "\n);\n";
            foreach (KeyValuePair<Drawable, string> linha in tablesAltenative)
                generate += linha.Value + "\n);\n";

            return generate;
        }
    }
}
