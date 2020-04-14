using moonSql.controller;
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
                if (this.clickCounter == 3)
                {
                    string name = InputBox("new relationship", "put relationship's name");
                    Relationship new_r = new Relationship(e.X, e.Y, name);
                    this.previous = new_r;
                    new_r.DrawIt(this.graphic);
                    this.clickCounter--;
                    InputMessage("Choose a entity", "Click on entities");
                }
                else
                {
                    if (this.clickCounter > 0)
                    {
                        foreach (Drawable draw in this.drawables)
                        {
                            if (draw.IsThere(e.X, e.Y) && (draw.GetType() == typeof(Entity)))
                            {
                                Relationship pre = (Relationship)this.previous;
                                bool min = InputCardinality("Cardinality for relationship", "choose minimum cardinality");
                                bool max = InputCardinality("Cardinality for relationship", "choose maximum cardinality");
                                Cardinality new_c = new Cardinality((draw.GetX() + 50), (draw.GetY() + 35), (min ? "1" : "N"), (max ? "1" : "N"));
                                pre.AddChild(draw, new_c);
                                this.previous.DrawIt(this.graphic);
                                this.clickCounter--;
                                break;
                            }
                        }
                    }
                }
            }
            paint.Refresh();
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
        private void New_entity_Click(object sender, System.EventArgs e)
        {
            this.status = "new entity";            
        }
        private void New_relationship_Click(object sender, EventArgs e)
        {
            if (this.clickCounter == 0)
            {
                this.status = "new relationship";
                this.clickCounter = 3;
            }
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
            for(int i = drawables.Count-1; i >= 0; i--)
            {
                if (drawables[i].IsThere(e.X, e.Y))
                {
                    this.selected = drawables[i];
                    break;
                }
            }
        }
        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
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
    }
}
