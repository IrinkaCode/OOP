namespace Lesson20._1
{
    public partial class Form1 : Form
    {
        private string pictureDirectory;
        private CancellationTokenSource cancelToken = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Поворот картинок";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureDirectory = folderBrowserDialog1.SelectedPath;
                label1.Text = pictureDirectory;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

            }
        }
        private void Process()
        {

        }
        private void ProcessFile()
        {
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = cancelToken.Token;
            parallelOptions.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
            string[] files Directory.GetFiles(pictureDirectory+@"\TestPictures","*.jpg",SearchOption.AllDirectories);
            string outPut = pictureDirectory + @"\TestPictures";
            Directory.CreateDirectory(outPut);
            try
            {
                Parallel.ForEach(files, parallelOptions, curFile =>
                {
                    parallelOptions.CancellationToken.ThrowIfCancellationRequested();
                    string fileName = Path.GetFileName(curFile);
                    this.Invoke(new Action(() =>
                    {
                        this.Text = 
                    }));


                });
            
            }
              catch(OperationCanceledException ex)
            {
                this.Invoke
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cancelToken.Cancel();
        }
    }

}
