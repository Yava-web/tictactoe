using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using tictactoe.model;

namespace tictactoe
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        Player player_1 = new Player();
        Player player_2 = new Player();
        public Game()
        {
            InitializeComponent();
        }
        public Game(string name1, string name2)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(name1) && string.IsNullOrEmpty(name2))
            {
                player_1.Name = "Player 1";
                player_2.Name = "Player 2";
            }
            else
            {
                player_1.Name = name1;
                player_2.Name = name2;
            }
            
            Player.State = false;

            Player_1_txt.Text = player_1.Name;
            Player_2_txt.Text = player_2.Name;

            Player_1_txt.Foreground = Brushes.Red;
            Player_2_txt.Foreground = Brushes.Black;

            player_1.Point = 0;
            player_2.Point = 0;
            
        }

        SolidColorBrush brush;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Player.State = !Player.State;

            if (!Player.State)
            {
                brush = Brushes.Red;
                Player_1_txt.Foreground = Brushes.Red;
                Player_2_txt.Foreground = Brushes.Black;
            }
            else
            {
                brush = Brushes.Green;
                Player_2_txt.Foreground = Brushes.Red;
                Player_1_txt.Foreground = Brushes.Black;
            }

            if (e.OriginalSource == btn01)
            {
                btn01.Background = brush;
                btn01.IsEnabled = false;
                btn01.Tag = 1;
            }
            else if (e.OriginalSource == btn11)
            {
                btn11.Background = brush;
                btn11.IsEnabled = false;
                btn11.Tag = 1;
            }
                
            else if (e.OriginalSource == btn21)
            {
                btn21.Background = brush;
                btn21.IsEnabled = false;
                btn21.Tag = 1;
            }
                
            else if (e.OriginalSource == btn02)
            {
                btn02.Background = brush;
                btn02.IsEnabled = false;
            }
            
            else if (e.OriginalSource == btn12)
            {
                btn12.Background = brush;
                btn12.IsEnabled = false;
            }
                
            else if (e.OriginalSource == btn22)
            {
                btn22.Background = brush;
                btn22.IsEnabled = false;
            }
                
            else if (e.OriginalSource == btn03)
            {
                btn03.Background = brush;
                btn03.IsEnabled = false;
            }
                
            else if (e.OriginalSource == btn13)
            {
                btn13.Background = brush;
                btn13.IsEnabled = false;
            }
                
            else if (e.OriginalSource == btn23)
            {
                btn23.Background = brush;
                btn23.IsEnabled = false;
            }

            whoiswin(Player.State, brush);
        }

        private void whoiswin(bool state, SolidColorBrush color)
        {
            string winner;

            if (state)
                winner = player_1.Name;
            else winner = player_2.Name;

            if ((btn01.Background == color && btn11.Background == color && btn21.Background == color) ||
               (btn02.Background == color && btn12.Background == color && btn22.Background == color) ||
               (btn03.Background == color && btn13.Background == color && btn23.Background == color))
            {
                MessageBox.Show(winner + " win", "Game over");
                nullState();
            }

            if ((btn01.Background == color && btn02.Background == color && btn03.Background == color) ||
               (btn11.Background == color && btn12.Background == color && btn13.Background == color) ||
               (btn21.Background == color && btn22.Background == color && btn23.Background == color))
            {
                MessageBox.Show(winner + " win", "Game over");
                nullState();
            }

            if ((btn01.Background == color && btn12.Background == color && btn23.Background == color) ||
               (btn21.Background == color && btn12.Background == color && btn03.Background == color))
            {
                MessageBox.Show(winner + " win", "Game over");
                nullState();
            }

        }

        private void nullState()
        {
            Player.State = false;

            Player_1_txt.Foreground = Brushes.Red;
            Player_2_txt.Foreground = Brushes.Black;

            btn01.Background = Brushes.White;
            btn01.IsEnabled = true;
            btn11.Background = Brushes.White;
            btn11.IsEnabled = true;
            btn21.Background = Brushes.White;
            btn21.IsEnabled = true;
            btn02.Background = Brushes.White;
            btn02.IsEnabled = true;
            btn12.Background = Brushes.White;
            btn12.IsEnabled = true;
            btn22.Background = Brushes.White;
            btn22.IsEnabled = true;
            btn03.Background = Brushes.White;
            btn03.IsEnabled = true;
            btn13.Background = Brushes.White;
            btn13.IsEnabled = true;
            btn23.Background = Brushes.White;
            btn23.IsEnabled = true;
        }
    }
}
