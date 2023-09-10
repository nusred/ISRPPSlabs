using isrppsLab4.Singleton;
using MyLib;

namespace isrppsLab4
{
    public partial class mainForm : Form
    {
        private Graphics g;
        private IAbstractFactory factoryRed;
        private IAbstractFactory factoryGreen;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            cbFigType.SelectedIndex = 0;
            g = this.CreateGraphics();
            factoryRed = new ConcreteFactoryRed();
            factoryGreen = new ConcreteFactoryGreen();
        }

        private void tbBuild_Click(object sender, EventArgs e)
        {
            switch (cbFigType.SelectedItem)
            {
                case "Red":
                    DrawFigure(factoryRed);
                    break;
                case "Green":
                    DrawFigure(factoryGreen);
                    break;
            }
        }
        private void DrawFigure(IAbstractFactory factory)
        {
            ICircle circle = factory.CreateCircle();
            ISquare square = factory.CreateSquare();
            SolidBrush brush = new SolidBrush(square.GetSqureColor());
            g.FillRectangle(brush, new Rectangle(100, 100, square.GetSideSize(), square.GetSideSize()));
            g.FillEllipse(brush, new Rectangle(250, 100, circle.GetRadius() * 2, circle.GetRadius() * 2));
            brush.Dispose();
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }

        private void add_Click(object sender, EventArgs e)
        {
            SingleForm singleForm = SingleForm.getInstance();
            singleForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SimpleForm simpleForm = new SimpleForm();
            simpleForm.Show();
        }
    }
}