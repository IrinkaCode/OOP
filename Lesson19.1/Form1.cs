namespace Lesson19._1
{
    public partial class StartBTN : Form
    {
        public StartBTN()
        {
            InitializeComponent();
        }

        private void Strartbutton_Click(object sender, EventArgs e)
        {
            Thread firstThread = new Thread(Loading);
            firstThread.Start();
        }
        public void Loading()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressPB.Invoke(new Action(() => progressPB.Value = i));
                Thread.Sleep(250);
            }
        }

    }
}
