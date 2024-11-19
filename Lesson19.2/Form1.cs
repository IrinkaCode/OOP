using Lesson19._2.Properties;

namespace Lesson19._2
{
    public partial class FormGame : Form
    {
        private Player player;
        private Random random;
        private List<Enemy> enemies = new List<Enemy>(3);
        private List<PictureBox>pictureBox = new List<PictureBox>(3);
        public FormGame()
        {
            InitializeComponent();
            player = new Player(Resources.plain, 500, 700);
            UpdatePlayer();
            StartGame();
            timer1.Start();
        }
        private void StartGame()
        {
            for (int i = 0; i < enemies.Capacity; i++)
            {
                Enemy enemy = new Enemy(random.Next(0, this.Width), 0);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = enemy.GetImage();
                pictureBox.Location = new Point(enemy.X, enemy.Y);
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pictureBox);
                pictureBox = new PictureBox();
                enemies.Add(enemy);
            }
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        player.Up();

                    }
                    break;
                case Keys.Down:
                    {
                        player.Down();
                    }
                    break;
                case Keys.Left:
                    {
                        player.Left();
                    }
                    break;
                case Keys.Right:
                    {
                        player.Right();
                    }
                    break;
            }

        }
        private void UpdatePlayer()
        {
            pictureBoxPlayer.Location = new Point(player.X, player.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Down();
                pictureBox[i].Location = new Point(enemies[i].X, enemies[i].Y);
                if (enemies[i].Y > this.Height + pictureBox.Height)
                {
                    Thread.Sleep(random.Next(2000));
                    enemies[i].X = random.Next(0, this.Width);
                    enemies[i].Y = 0;
                }
            }
        }
    }
}
