using System.Drawing.Drawing2D;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace LR13
{
    public partial class MainForm : Form
    {
        private FormModel model;

        private Point start;
        private bool drawing = false;
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        private PointF[] Points = new PointF[4];
        private int NextPoint = 0;
        Graphics graphics;
        private Image orig;
        Pen pen;
        Bitmap bm = new Bitmap(830, 530);
        Bitmap bm2 = new Bitmap(830, 530);

        public MainForm()
        {
            pen = new Pen(Color.Black, 1f);
            this.model = new FormModel(this);
            InitializeComponent();
        }

        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints (int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }

            public void setPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }

            public void resetPoints()
            {
                index = 0;
            }

            public int getCountPoints()
            {
                return index;
            }

            public Point[] getPoints()
            {
                return points;
            }
        }

        private void WorkArea_Bezie_MouseClick(object sender, MouseEventArgs e)
        {
            clearArea.Enabled = true;
            if (NextPoint > 3) NextPoint = 0;
            Points[NextPoint].X = e.X;
            Points[NextPoint].Y = e.Y;
            NextPoint++;
            WorkArea.Invalidate();
        }

        private void WorkArea_Bezie_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(WorkArea.BackColor);
            if (NextPoint >= 4)
            {
                e.Graphics.DrawBezier(Pens.Black,
                    Points[0], Points[1], Points[2], Points[3]);
            }

            for (int i = 0; i < NextPoint; i++)
            {
                e.Graphics.FillRectangle(Brushes.White,
                    Points[i].X - 3, Points[i].Y - 3, 6, 6);
                e.Graphics.DrawRectangle(Pens.Black,
                    Points[i].X - 3, Points[i].Y - 3, 6, 6);
            }
        }

        private void WorkArea_Curve_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            clearArea.Enabled = true;

        }

        private void WorkArea_Curve_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.resetPoints();
        }

        private void WorkArea_Curve_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }

            graphics = Graphics.FromImage(bm);
            arrayPoints.setPoint(e.X, e.Y);
            if (arrayPoints.getCountPoints() >= 2) 
            {
                graphics.DrawLines(pen, arrayPoints.getPoints());
                WorkArea.Image = bm;
                arrayPoints.setPoint(e.X, e.Y);
            }
        }

        private void WorkArea_Line_MouseDown(object sender, MouseEventArgs e)
        {
            clearArea.Enabled = true;
            start = new Point(e.X, e.Y);
            orig = bm;
            drawing = true;
        }

        private void WorkArea_Line_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            var finish = new Point(e.X, e.Y);
            bm2 = new Bitmap(bm);
            WorkArea.Image = bm2;
            var g = Graphics.FromImage(bm2);
            g.DrawLine(pen, start, finish);
            g.Dispose();
            WorkArea.Invalidate();
        }

        private void WorkArea_Line_MouseUp(object sender, MouseEventArgs e)
        {
            var finish = new Point(e.X, e.Y);
            var g = Graphics.FromImage(bm);
            g.DrawLine(pen, start, finish);
            g.Save();
            drawing = false;
            g.Dispose();
            WorkArea.Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LineSet_Click(object sender, EventArgs e)
        {
            WorkArea.MouseDown += WorkArea_Line_MouseDown;
            WorkArea.MouseUp += WorkArea_Line_MouseUp;
            WorkArea.MouseMove += WorkArea_Line_MouseMove;
            LineSet.Enabled = false;
            curveSet.Enabled = false;
            bezieSet.Enabled = false;
            ClearDrawer.Enabled = true;

        }

        private void ClearDrawer_Click(object sender, EventArgs e)
        {
            WorkArea.MouseDown -= WorkArea_Line_MouseDown;
            WorkArea.MouseUp -= WorkArea_Line_MouseUp;
            WorkArea.MouseMove -= WorkArea_Line_MouseMove;
            WorkArea.MouseDown -= WorkArea_Curve_MouseDown;
            WorkArea.MouseUp -= WorkArea_Curve_MouseUp;
            WorkArea.MouseMove -= WorkArea_Curve_MouseMove;
            WorkArea.MouseClick -= WorkArea_Bezie_MouseClick;
            WorkArea.Paint -= WorkArea_Bezie_Paint;
            LineSet.Enabled = true;
            curveSet.Enabled = true;
            bezieSet.Enabled = true;
            ClearDrawer.Enabled = false;
        }

        private void clearArea_Click(object sender, EventArgs e)
        {
            bm.Dispose();
            bm = new Bitmap(830, 530);
            WorkArea.Image = bm;
            clearArea.Enabled = false;
            WorkArea.Refresh();
        }

        private void curveSet_Click(object sender, EventArgs e)
        {
            WorkArea.MouseDown += WorkArea_Curve_MouseDown;
            WorkArea.MouseUp += WorkArea_Curve_MouseUp;
            WorkArea.MouseMove += WorkArea_Curve_MouseMove;
            LineSet.Enabled = false;
            bezieSet.Enabled = false;
            ClearDrawer.Enabled = true;
            curveSet.Enabled = false;
        }

        private void bezieSet_Click(object sender, EventArgs e)
        {
            WorkArea.MouseClick += WorkArea_Bezie_MouseClick;
            WorkArea.Paint += WorkArea_Bezie_Paint;
            ClearDrawer.Enabled = true;
            clearArea.Enabled = true;
            bezieSet.Enabled = false;
            LineSet.Enabled = false;
            curveSet.Enabled = false;
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            pen.Color = Color1.BackColor;
        }

        private void Color2_Click(object sender, EventArgs e)
        {
            pen.Color = Color2.BackColor;
        }

        private void Color3_Click(object sender, EventArgs e)
        {
            pen.Color = Color3.BackColor;
        }

        private void Color4_Click(object sender, EventArgs e)
        {
            pen.Color = Color4.BackColor;
        }

        private void Color5_Click(object sender, EventArgs e)
        {
            pen.Color = Color5.BackColor;
        }

        private void Color6_Click(object sender, EventArgs e)
        {
            pen.Color = Color6.BackColor;
        }

        private void Color7_Click(object sender, EventArgs e)
        {
            pen.Color = Color7.BackColor;
        }

        private void Color8_Click(object sender, EventArgs e)
        {
            pen.Color = Color8.BackColor;
        }

        private void Color9_Click(object sender, EventArgs e)
        {
            pen.Color = Color9.BackColor;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int delta = 0;
            delta += trackBar1.Value;
            pen.Width = delta;
        }
    }
}