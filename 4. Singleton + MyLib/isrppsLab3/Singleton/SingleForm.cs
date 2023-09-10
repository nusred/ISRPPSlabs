namespace isrppsLab4.Singleton
{
    partial class SingleForm : Form
    {
        private static SingleForm instance;
        protected SingleForm()
        {
            InitializeComponent();
        }
        public static SingleForm getInstance()
        {
            if (instance == null)
                instance = new SingleForm();
            return instance;
        }
    }
}
