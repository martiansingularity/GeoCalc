using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ImpactsOfTechNikhil;

namespace RoundedButton
{
    public partial class ShapeCalculator : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public static Image SelectedBackgroundImage;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public ShapeCalculator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            timer1.Start();

        }


        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            // Set the background image of this form to the selected image
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();
            foreach (var form in openForms)
            {
                form.Close();
            }

        }


        Timer t1 = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                Opacity = 0;      // opacity is 0

                t1.Interval = 10;
                t1.Tick += new EventHandler(fadeIn);
                t1.Start();
            }
            panel1.BackColor = Color.FromArgb(95, Color.White);
            panel2.BackColor = Color.FromArgb(95, Color.Black);
            panel4.BackColor = Color.FromArgb(95, Color.Black);
            panel3.Visible = false;
            panel5.Visible = false;
            rectaloutput.Visible = false;
            rectalpanel.Visible = false;
            cylin.Visible = false;
            cylout.Visible = false;
            conein.Visible = false;
            coneout.Visible = false;
            triinp.Visible = false;
            triout.Visible = false;
            Shapeoutput.Visible = false;
            sphereinp.Visible = false;
            sphereout.Visible = false;
            prismin.Visible = false;
            prismout.Visible = false;
        }



        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
            panel2.Height, 30, 30));

        }


        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }





        private void label3_Click(object sender, EventArgs e)
        {

        }





        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width,
            panel4.Height, 30, 30));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            {
                Opacity = 0;      // opacity is 0

                t1.Interval = 10;
                t1.Tick += new EventHandler(fadeIn);
                t1.Start();
            }
            panel3.Visible = true;
            panel5.Visible = true;
            panel4.Visible = false;
            rectaloutput.Visible = false;
            rectalpanel.Visible = false;
            cylin.Visible = false;
            cylout.Visible = false;
            conein.Visible = false;
            coneout.Visible = false;
            triinp.Visible = false;
            triout.Visible = false;
            sphereinp.Visible = false;
            sphereout.Visible = false;
            prismin.Visible = false;
            prismout.Visible = false;
            Shapeoutput.Visible = true;
            pictureBox1.Image = ImpactsOfTechNikhil.Properties.Resources.circle;
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            {
                Opacity = 0;      // opacity is 0

                t1.Interval = 10;
                t1.Tick += new EventHandler(fadeIn);
                t1.Start();
            }
            panel3.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            rectalpanel.Visible = true;
            rectaloutput.Visible = true;
            cylin.Visible = false;
            cylout.Visible = false;
            conein.Visible = false;
            triinp.Visible = false;
            triout.Visible = false;
            coneout.Visible = false;
            sphereinp.Visible = false;
            sphereout.Visible = false;
            Shapeoutput.Visible = true;
            prismin.Visible = false;
            prismout.Visible = false;
            pictureBox1.Image = ImpactsOfTechNikhil.Properties.Resources.rectangle;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,
            panel3.Height, 30, 30));
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            {
                panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width,
                panel5.Height, 30, 30));
            }
        }

        private void rjButton3_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please Enter A Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double radius;
                double area, cir;
                radius = Convert.ToDouble(textBox2.Text);
                area = 3.14 * radius * radius;
                cir = 2 * 3.14 * radius;
                circlearea.Text = Convert.ToString("area     " + area);
                circumference.Text = Convert.ToString("circumference     " + cir);
            }

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lengthinp.Text))
            {
                MessageBox.Show("Please Enter A Length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(widthinp.Text))
            {
                MessageBox.Show("Please Enter A Width.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double length, width;
                double area, per;
                length = Convert.ToDouble(lengthinp.Text);
                width = Convert.ToDouble(widthinp.Text);
                area = length * width;
                per = 2 * length + 2 * width;
                rectalarea.Text = Convert.ToString("area     " + area);
                rectalperimeter.Text = Convert.ToString("perimeter     " + per);
            }
        }

        private void rectalpanel_Paint(object sender, PaintEventArgs e)
        {
            rectalpanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, rectalpanel.Width,
            rectalpanel.Height, 30, 30));
        }

        private void rectaloutput_Paint(object sender, PaintEventArgs e)
        {
            rectaloutput.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, rectaloutput.Width,
            rectaloutput.Height, 30, 30));
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            lengthinp.Text = " ";
            widthinp.Text = " ";
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }

        private void lengthinp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lengthinp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void widthinp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            {
                Opacity = 0;      // opacity is 0

                t1.Interval = 10;
                t1.Tick += new EventHandler(fadeIn);
                t1.Start();
            }
            panel3.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            rectalpanel.Visible = false;
            rectaloutput.Visible = false;
            cylin.Visible = true;
            cylout.Visible = true;
            conein.Visible = false;
            coneout.Visible = false;
            triinp.Visible = false;
            triout.Visible = false;
            sphereinp.Visible = false;
            sphereout.Visible = false;
            Shapeoutput.Visible = true;
            prismin.Visible = false;
            prismout.Visible = false;
            pictureBox1.Image = ImpactsOfTechNikhil.Properties.Resources.cylinder;
        }

        private void cylin_Paint(object sender, PaintEventArgs e)
        {
            cylin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cylin.Width,
            cylin.Height, 30, 30));
        }

        private void cylout_Paint(object sender, PaintEventArgs e)
        {
            cylout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cylout.Width,
            cylout.Height, 30, 30));
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            cylheight.Text = " ";
            cylrad.Text = " ";
        }

        private void cylrad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cylrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cylheight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rjButton15_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cylrad.Text))
            {
                MessageBox.Show("Please Enter A Radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(cylheight.Text))
            {
                MessageBox.Show("Please Enter A Height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double radius, height;
                double volume, surfacearea;
                radius = Convert.ToDouble(cylrad.Text);
                height = Convert.ToDouble(cylheight.Text);
                surfacearea = 2 * 3.14 * radius * height + 2 * 3.14 * radius * radius;
                volume = 3.14 * radius * radius * height;
                volc.Text = Convert.ToString("Volume     " + volume);
                surfc.Text = Convert.ToString("Surf. Area     " + surfacearea);
            }
        }

        private void conebutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Opacity = 0;      // opacity is 0

                    t1.Interval = 10;
                    t1.Tick += new EventHandler(fadeIn);
                    t1.Start();
                }
                panel3.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                rectalpanel.Visible = false;
                rectaloutput.Visible = false;
                cylin.Visible = false;
                cylout.Visible = false;
                conein.Visible = true;
                coneout.Visible = true;
                triinp.Visible = false;
                triout.Visible = false;
                sphereinp.Visible = false;
                sphereout.Visible = false;
                Shapeoutput.Visible = true;
                prismin.Visible = false;
                prismout.Visible = false;
                pictureBox1.Image = ImpactsOfTechNikhil.Properties.Resources.cone;
            }
        }

        private void conein_Paint(object sender, PaintEventArgs e)
        {
            conein.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, conein.Width,
            conein.Height, 30, 30));
        }

        private void coneout_Paint(object sender, PaintEventArgs e)
        {
            coneout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, coneout.Width,
            coneout.Height, 30, 30));
        }

        private void rjButton16_Click(object sender, EventArgs e)
        {
            conerad.Text = " ";
            coneheight.Text = " ";
        }

        private void rjButton17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(conerad.Text))
            {
                MessageBox.Show("Please Enter A Radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(coneheight.Text))
            {
                MessageBox.Show("Please Enter A Height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double radius, height;
                double volume, surfacearea;
                radius = Convert.ToDouble(conerad.Text);
                height = Convert.ToDouble(coneheight.Text);
                surfacearea = 3.14 * radius * (radius + Math.Sqrt((height * height + radius * radius)));
                volume = 3.14 * radius * radius * height / 3;
                conevol.Text = Convert.ToString("Volume     " + volume);
                conesurf.Text = Convert.ToString("Surf. Area     " + surfacearea);
            }
        }

        private void rjButton13_Click(object sender, EventArgs e)
        {
            trilength.Text = " ";
            tribase.Text = " ";
            triheight.Text = " ";
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            {
                {
                    Opacity = 0;      // opacity is 0

                    t1.Interval = 10;
                    t1.Tick += new EventHandler(fadeIn);
                    t1.Start();
                }
                panel3.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                rectalpanel.Visible = false;
                rectaloutput.Visible = false;
                cylin.Visible = false;
                cylout.Visible = false;
                conein.Visible = false;
                coneout.Visible = false;
                triinp.Visible = true;
                triout.Visible = true;
                sphereinp.Visible = false;
                sphereout.Visible = false;
                Shapeoutput.Visible = true;
                prismin.Visible = false;
                prismout.Visible = false;
                pictureBox1.Image = ImpactsOfTechNikhil.Properties.Resources.triangularprism;
            }
        }

        private void triinp_Paint(object sender, PaintEventArgs e)
        {
            triinp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, triinp.Width,
            triinp.Height, 30, 30));
        }

        private void triout_Paint(object sender, PaintEventArgs e)
        {
            triout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, triinp.Width,
            triinp.Height, 30, 30));
        }

        private void trisidea_TextChanged(object sender, EventArgs e)
        {

        }

        private void trisidea_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trisideb_TextChanged(object sender, EventArgs e)
        {

        }

        private void trisideb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trisidec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trisided_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rjButton18_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(trilength.Text))
            {
                MessageBox.Show("Please Enter A Side Length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(tribase.Text))
            {
                MessageBox.Show("Please Enter A Side Length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(triheight.Text))
            {
                MessageBox.Show("Please Enter A Height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double length, baseedge, height;
                double volume, surfacearea;
                length = Convert.ToDouble(trilength.Text);
                baseedge = Convert.ToDouble(tribase.Text);
                height = Convert.ToDouble(triheight.Text);
                surfacearea = baseedge * height + baseedge * length + 2 * (Math.Sqrt(height * height + baseedge * baseedge) * length);
                volume = (baseedge * height * length) / 2;
                trivol.Text = Convert.ToString("Volume     " + volume);
                trisurf.Text = Convert.ToString("Surf. Area     " + surfacearea);
            }
        }

        private void triheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shapeoutput_Paint(object sender, PaintEventArgs e)
        {
            Shapeoutput.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Shapeoutput.Width,
           Shapeoutput.Height, 30, 30));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void sphereinp_Paint(object sender, PaintEventArgs e)
        {
            sphereinp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sphereinp.Width,
           sphereinp.Height, 30, 30));
        }

        private void sphereout_Paint(object sender, PaintEventArgs e)
        {
            sphereout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sphereout.Width,
           sphereout.Height, 30, 30));
        }

        private void rjButton11_Click(object sender, EventArgs e)
        {
            {
                {
                    Opacity = 0;      // opacity is 0

                    t1.Interval = 10;
                    t1.Tick += new EventHandler(fadeIn);
                    t1.Start();
                }
                panel3.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                rectalpanel.Visible = false;
                rectaloutput.Visible = false;
                cylin.Visible = false;
                cylout.Visible = false;
                conein.Visible = false;
                coneout.Visible = false;
                triinp.Visible = false;
                triout.Visible = false;
                sphereinp.Visible = false;
                sphereout.Visible = false;
                Shapeoutput.Visible = true;
                pictureBox1.Image = ImpactsOfTechNikhil.Properties.Resources.sphere;
                sphereinp.Visible = true;
                sphereout.Visible = true;
                prismin.Visible = false;
                prismout.Visible = false;
            }
        }

        private void rjButton20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sphererad.Text))
            {
                MessageBox.Show("Please Enter A Radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double radius;
                double volume, surfacearea;
                radius = Convert.ToDouble(sphererad.Text);
                surfacearea = 4 * 3.14 * radius * radius;
                volume =  (4 * (3.14 * radius * radius * radius))/3;
                spherevol.Text = Convert.ToString("Volume     " + volume);
                spheresurf.Text = Convert.ToString("Surf. Area     " + surfacearea);
            }
        }

        private void sphererad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rjButton19_Click(object sender, EventArgs e)
        {
            sphererad.Text = " ";
        }

        private void rjButton14_Click(object sender, EventArgs e)
        {
            {
                {
                    Opacity = 0;      // opacity is 0

                    t1.Interval = 10;
                    t1.Tick += new EventHandler(fadeIn);
                    t1.Start();
                }
                panel3.Visible = false;
                panel5.Visible = false;
                panel4.Visible = false;
                rectalpanel.Visible = false;
                rectaloutput.Visible = false;
                cylin.Visible = false;
                cylout.Visible = false;
                conein.Visible = false;
                coneout.Visible = false;
                triinp.Visible = false;
                triout.Visible = false;
                sphereinp.Visible = false;
                sphereout.Visible = false;
                Shapeoutput.Visible = true;
                pictureBox1.Image = ImpactsOfTechNikhil.Properties.Resources.prism;
                sphereinp.Visible = false;
                sphereout.Visible = false;
                prismin.Visible = true;
                prismout.Visible = true;
            }
        }

        private void rjButton21_Click(object sender, EventArgs e)
        {
            prismheight.Text = " ";
            prismwidth.Text = " ";
            prismlength.Text = " ";
        }

        private void rjButton22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(prismlength.Text))
            {
                MessageBox.Show("Please Enter A length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(prismheight.Text))
            {
                MessageBox.Show("Please Enter A height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(prismwidth.Text))
            {
                MessageBox.Show("Please Enter A width.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double height, length, width;
                double volume, surfacearea;
                height = Convert.ToDouble(prismheight.Text);
                length = Convert.ToDouble(prismlength.Text);
                width= Convert.ToDouble(prismwidth.Text);
                surfacearea = 2 * (width * length + height * length + height * width);
                volume = length * height * width;
                prismvol.Text = Convert.ToString("Volume     " + volume);
                prismsurf.Text = Convert.ToString("Surf. Area     " + surfacearea);
            }
        }

        private void prismheight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void prismlength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void prismwidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void prismin_Paint(object sender, PaintEventArgs e)
        {
            prismin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, prismin.Width,
           prismin.Height, 30, 30));
        }

        private void prismout_Paint(object sender, PaintEventArgs e)
        {
           prismout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, prismout.Width,
           prismout.Height, 30, 30));
        }
    }
}
    
