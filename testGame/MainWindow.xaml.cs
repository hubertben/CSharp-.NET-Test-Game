
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace testGame
{
    public partial class MainWindow : Window
    {
        public Circle C;
        public MainWindow()
        {
            InitializeComponent();

            C = new Circle(100, 100, 100, makeColor(128, 230, 255), MyCanvas);
            
            DispatcherTimer gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromSeconds(0.01);
            gameTimer.Tick += tick;
            gameTimer.Start();
        }

        private void tick(object sender, EventArgs e)
        {
            update();
            draw();
        }

        private void update()
        {
            C.move(1, 0.5f); 
        }
        private void draw()
        {
            C.draw();
        }

        public Color makeColor(int r = 0, int g = 0, int b = 0, int a = 255) {
            Color C = Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b);
            return C;
        }
    }

}
