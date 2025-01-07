//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Threading;
//using System.Windows.Forms;
//using Timer = System.Windows.Forms.Timer;

//namespace FallingSnowflakes
//{
//    public class Snowflake
//    {
//        public float X { get; set; }
//        public float Y { get; set; }
//        public float Speed { get; set; }
//        public float Size { get; set; }

//        public Snowflake(float x, float speed, float size)
//        {
//            X = x;
//            Y = 0;
//            Speed = speed;
//            Size = size;
//        }

//        public void Fall()
//        {
//            Y += Speed;
//        }
//    }

//    public partial class Form1 : Form
//    {
//        private List<Snowflake> snowflakes = new List<Snowflake>();
//        private Random random = new Random();
//        private Snowflake playerSnowflake;
//        private Thread playerThread;
//        public volatile bool isRunning; // Флаг для завершения потока

//        public Form1()
//        {
//            InitializeComponent();
//            this.DoubleBuffered = true;
//            this.KeyDown += Form1_KeyDown;

//            for (int i = 0; i < 20; i++)
//            {
//                snowflakes.Add(CreateSnowflake());
//            }

//            playerSnowflake = new Snowflake(this.ClientSize.Width / 2, 3, 15);

//            isRunning = true;  // Запускаем поток 
//            playerThread = new Thread(PlayerControlledSnowflake);
//            playerThread.Start();

//            Timer timer = new Timer();
//            timer.Interval = 16;
//            timer.Tick += Timer_Tick;
//            timer.Start();
//        }

//        private Snowflake CreateSnowflake()
//        {
//            float x = random.Next(0, this.ClientSize.Width);
//            float speed = random.Next(2, 5);
//            float size = random.Next(5, 20);
//            return new Snowflake(x, speed, size);
//        }

//        private void Timer_Tick(object sender, EventArgs e)
//        {
//            foreach (var snowflake in snowflakes)
//            {
//                snowflake.Fall();
//                ResetSnowflakePosition(snowflake);
//            }

//            playerSnowflake.Fall();
//            ResetPlayerSnowflakePosition();

//            this.Invalidate();
//        }

//        private void ResetSnowflakePosition(Snowflake snowflake)
//        {
//            if (snowflake.Y > this.ClientSize.Height)
//            {
//                snowflake.Y = 0;
//                snowflake.X = random.Next(0, this.ClientSize.Width);
//            }
//        }

//        private void ResetPlayerSnowflakePosition()
//        {
//            if (playerSnowflake.Y > this.ClientSize.Height)
//            {
//                playerSnowflake.Y = 0;
//                playerSnowflake.X = this.ClientSize.Width / 2;
//            }
//        }

//        private void Form1_KeyDown(object sender, KeyEventArgs e)
//        {
//            switch (e.KeyCode)
//            {
//                case Keys.Left:
//                    playerSnowflake.X = Math.Max(0, playerSnowflake.X - 10);
//                    break;
//                case Keys.Right:
//                    playerSnowflake.X = Math.Min(this.ClientSize.Width - playerSnowflake.Size, playerSnowflake.X + 10);
//                    break;
//            }
//        }

//        private void PlayerControlledSnowflake()
//        {
//            while (isRunning)
//            {
//                Thread.Sleep(10);
//            }
//        }

//        protected override void OnPaint(PaintEventArgs e)
//        {
//            base.OnPaint(e);
//            Graphics g = e.Graphics;

//            foreach (var snowflake in snowflakes)
//            {
//                g.FillEllipse(Brushes.Blue, snowflake.X, snowflake.Y, snowflake.Size, snowflake.Size);
//            }

//            // Draw the player-controlled snowflake
//            g.FillEllipse(Brushes.Red, playerSnowflake.X, playerSnowflake.Y, playerSnowflake.Size, playerSnowflake.Size);
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                isRunning = false; // Устанавливаем флаг для завершения потока
//                if (playerThread.IsAlive)
//                {
//                    playerThread.Join(); // Ждем завершения потока
//                }
//            }

//            base.Dispose(disposing);
//        }

//        //private void Form1_Load(object sender, EventArgs e)
//        //{

//        //}
//    }
//}



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FallingSnowflakes
{
    public class Snowflake
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Speed { get; set; }
        public float Size { get; set; }

        public Snowflake(float x, float speed, float size)
        {
            X = x;
            Y = 0;
            Speed = speed;
            Size = size;
        }

        public void Fall()
        {
            Y += Speed;
        }
    }

    public partial class Form1 : Form
    {
        private List<Snowflake> snowflakes = new List<Snowflake>();
        private Random random = new Random();
        private Snowflake playerSnowflake;
        private Thread playerThread;
        public volatile bool isRunning;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;

            for (int i = 0; i < 20; i++)
            {
                snowflakes.Add(new Snowflake(random.Next(0, this.ClientSize.Width), random.Next(2, 5), random.Next(5, 20)));
            }

            playerSnowflake = new Snowflake(this.ClientSize.Width / 2, 3, 15);
            isRunning = true;

            playerThread = new Thread(PlayerControlledSnowflake);
            playerThread.Start();

            Timer timer = new Timer();
            timer.Interval = 16;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var snowflake in snowflakes)
            {
                snowflake.Fall();
                if (snowflake.Y > this.ClientSize.Height)
                {
                    snowflake.Y = 0;
                    snowflake.X = random.Next(0, this.ClientSize.Width);
                }
            }

            playerSnowflake.Fall();
            if (playerSnowflake.Y > this.ClientSize.Height)
            {
                playerSnowflake.Y = 0;
                playerSnowflake.X = this.ClientSize.Width / 2;
            }

            this.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerSnowflake.X = Math.Max(0, playerSnowflake.X - 10);
                    break;
                case Keys.Right:
                    playerSnowflake.X = Math.Min(this.ClientSize.Width - playerSnowflake.Size, playerSnowflake.X + 10);
                    break;
            }
        }

        private void PlayerControlledSnowflake()
        {
            while (isRunning)
            {
                Thread.Sleep(10);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (var snowflake in snowflakes)
            {
                g.FillEllipse(Brushes.Blue, snowflake.X, snowflake.Y, snowflake.Size, snowflake.Size);
            }

            g.FillEllipse(Brushes.Red, playerSnowflake.X, playerSnowflake.Y, playerSnowflake.Size, playerSnowflake.Size);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                isRunning = false;
                if (playerThread.IsAlive)
                {
                    playerThread.Join();
                }
            }

            base.Dispose(disposing);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
