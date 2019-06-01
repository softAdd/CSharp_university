using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pj_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            loadImageAs(getDir("files/rocket.png"), Rocket);
            loadImageAs(getDir("files/cloud.png"), Cloud);
            ready();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation go = new ThicknessAnimation();
            go.From = Cloud.Margin;
            go.To = new Thickness(1000, 0, 0, 0);
            go.Duration = TimeSpan.FromSeconds(40);
            Cloud.BeginAnimation(MarginProperty, go);
        }

        private void loadImageAs(string path, System.Windows.Controls.Image elem)
        {
            ImageSourceConverter imgs = new ImageSourceConverter();
            elem.SetValue(Image.SourceProperty, imgs.ConvertFromString(path));
        }

        public string getDir(string endPath)
        {
            string dirPath = "";
            string[] path = Environment.CurrentDirectory.ToString().Split('\\');
            for (int i = 0; i < 5; i++)
            {
                dirPath += path[i] + "/";
            }
            dirPath += endPath;
            return dirPath;
        }

        DispatcherTimer timer = new DispatcherTimer();

        private void ready()
        {
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            int time = int.Parse(tenTime.Text);
            time--;
            tenTime.Text = time.ToString();
            if (time == 0)
            {
                tenTime.Visibility = Visibility.Collapsed;
                rocketStart();
                timer.Stop();
            }
        }

        private void rocketStart()
        {
            ThicknessAnimation go = new ThicknessAnimation();
            go.From = Rocket.Margin;
            go.To = new Thickness(0, 0, 0, 100);
            go.Duration = TimeSpan.FromSeconds(3);
            go.Completed += rocketAcceleration;
            Rocket.BeginAnimation(MarginProperty, go);
        }

        private void rocketAcceleration(object sender, EventArgs e)
        {
            ThicknessAnimation go = new ThicknessAnimation();
            go.From = Rocket.Margin;
            go.To = new Thickness(0, 0, 0, 750);
            go.Completed += secondStage;
            go.Duration = TimeSpan.FromSeconds(3);
            Rocket.BeginAnimation(MarginProperty, go);
            
        }

        private void secondStage(object sender, EventArgs e)
        {
            loadImageAs(getDir("files/rocket.png"), Rocket2);
            loadImageAs(getDir("files/ast1.png"), Ast1);
            loadImageAs(getDir("files/ast2.png"), Ast2);
            loadImageAs(getDir("files/ast3.png"), Ast3);
            loadImageAs(getDir("files/star.png"), Star);
            ImageBrush imBrush = new ImageBrush()
            {
                ImageSource = new BitmapImage(new Uri(getDir("files/space.png")))
            };
            SecondStage.Background = imBrush;
            FirstStage.Visibility = Visibility.Collapsed;
            LongRoad.Visibility = Visibility.Visible;
            SecondStage.Visibility = Visibility.Visible;
            rocketThroughAsteroids();
        }

        private void rocketThroughAsteroids()
        {
            ThicknessAnimation go = new ThicknessAnimation();
            go.From = Rocket2.Margin;
            go.To = new Thickness(300, 0, 0, 300);
            go.Completed += thirdStage;
            go.Duration = TimeSpan.FromSeconds(9);
            Rocket2.BeginAnimation(MarginProperty, go);
        }

        private int delay;

        private void thirdStage(object sender, EventArgs e)
        {
            SecondStage.Visibility = Visibility.Collapsed;
            LongRoad.Visibility = Visibility.Collapsed;
            atHome.Visibility = Visibility.Visible;
            ImageBrush imBrush = new ImageBrush()
            {
                ImageSource = new BitmapImage(new Uri(getDir("files/thirdPlanet.jpg")))
            };
            ThirdStage.Background = imBrush;
            ThirdStage.Visibility = Visibility.Visible;
            delay = 8;
            timer.Start();
            timer.Tick += new EventHandler(timerTick2);
        }

        private void timerTick2(object sender, EventArgs e)
        {
            delay--;
            if (delay == 0)
            {
                timer.Stop();
                atHome.Visibility = Visibility.Collapsed;
                loadImageAs(getDir("files/rocket.png"), Rocket3);
                Rocket3.Visibility = Visibility.Visible;
                delay = 3;
                timer.Start();
                timer.Tick += new EventHandler(timerTick3);
            }
        }

        private void timerTick3(object sender, EventArgs e)
        {
            delay--;
            if (delay == 0)
            {
                lastStage();
            }
        }

        private void lastStage()
        {
            ThirdStage.Visibility = Visibility.Collapsed;
            LastStage.Visibility = Visibility.Visible;
            
        }
    }
}
