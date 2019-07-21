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

namespace Tic_Tac_Toe_WPF
{
    public partial class MainWindow : Window
    {
        // --- CONSTs
        public const int IloscPol = 9;  // liczba pól w grze

        // --- CONSTs

        // --- Zmienne
        static public int Xpts;         // Liczba punktów X
        static public int Opts;         // Liczba punktów O
        static public int WolnePola;    // Liczba wolnych pól
        static public bool Xruch;       // Czy aktualny ruch należy do gracza X
        // --- Zmienne
        public MainWindow()
        {
            Xpts = 0;
            Opts = 0;
            InitializeComponent();
            TextboxRightBottom.Visibility = Visibility.Hidden;
            UpdateTextBoxTop();    // wypisuje górny TextBox
            UpdateTextBoxRightTop();    // wypisuje prawy górny TextBox

            CzyscMape();
        }
        private void CzyscMape()
        {
            for (int i = 0; i < IloscPol; i++)
            {
                Button temp=((Button)FindName("Btn" + i));
                temp.Content = " ";
            }
            WolnePola = 9;
            Xruch = true;
            UpdateTextBoxRightTop();
            TextboxRightBottom.Visibility = Visibility.Hidden;

        }
        private void UpdateTextBoxTop() {
            TextboxTOP.Text = "X   " + Xpts + ":" + Opts + "   O";
        }
        private void UpdateTextBoxRightTop()
        {
            if (Xruch) { TextboxRightTOP.Text = "Ruch: X"; }
            else { TextboxRightTOP.Text = "Ruch: O"; }
            WolnePola--;
        }
        //  Sprawdzanie czy są 3 znaki z rzędu
        private void Row()
        {
            List<Button> temps = new List<Button>();
                            for (int i = 0; i < IloscPol; i++)
                            {
                                temps.Add((Button)FindName("Btn" + i));
                            }
            string znak;
            for (int x = 0; x < (Math.Sqrt(IloscPol)); x++)
            {
                
                for (int z = 0; z < 2; z++)
                {
                    znak = z == 0 ? "X" : "O";  // warunek znak=X jesli 0 lub O jesli 1
                    if ((string)temps[(x * 3)].Content == znak && (string)temps[(x * 3) + 1].Content == znak && (string)temps[(x * 3) + 2].Content == znak)
                    {   // POZIOMO
                        if (z == 0) { Xpts++; } else { Opts++; }
                        UpdateTextBoxTop();
                        Stop();

                    }
                    if ((string)temps[x].Content == znak && (string)temps[x + 3].Content == znak && (string)temps[x + 6].Content == znak)
                    {   // PIONOWO
                        if (z == 0) { Xpts++; } else { Opts++; }
                        UpdateTextBoxTop();
                        Stop();

                    }

                }
            }
                            for (int z = 0; z < 2; z++)
                            {
                                znak = z == 0 ? "X" : "O";
                                            if ((string)Btn4.Content == znak&&(string)Btn0.Content==znak&&(string)Btn8.Content==znak)
                                            {
                                                if (z == 0) { Xpts++; } else { Opts++; }
                                                UpdateTextBoxTop();
                                                Stop();
                                                break;

                                            }
                                             if ((string)Btn4.Content == znak && (string)Btn2.Content == znak && (string)Btn6.Content == znak)
                                            {
                                                if (z == 0) { Xpts++; } else { Opts++; }
                                                UpdateTextBoxTop();
                                                Stop();
                                                break;
                                            }

                            }

            

        }
        private void Stop()
        {
            for (int i=0; i < IloscPol; i++)
            {
                Button temp = (Button)FindName("Btn" + i);
                if ((string)temp.Content==" ") { temp.Content = "  "; }
            }
            TextboxRightBottom.Text = Xruch ? "Wygrywa O" : "Wygrywa O";
            TextboxRightBottom.Visibility = Visibility.Visible;

        }

        //  Sprawdzanie czy są 3 znaki z rzędu
        // ================= PRZYCISKI =================
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn0.Content==" ")
            {
                if (Xruch) { Btn0.Content = "X"; } else { Btn0.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn1.Content == " ")
            {
                if (Xruch) { Btn1.Content = "X"; } else { Btn1.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn2.Content == " ")
            {
                if (Xruch) { Btn2.Content = "X"; } else { Btn2.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn3.Content == " ")
            {
                if (Xruch) { Btn3.Content = "X"; } else { Btn3.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn4.Content == " ")
            {
                if (Xruch) { Btn4.Content = "X"; } else { Btn4.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn5.Content == " ")
            {
                if (Xruch) { Btn5.Content = "X"; } else { Btn5.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn6.Content == " ")
            {
                if (Xruch) { Btn6.Content = "X"; } else { Btn6.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn7.Content == " ")
            {
                if (Xruch) { Btn7.Content = "X"; } else { Btn7.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn8.Content == " ")
            {
                if (Xruch) { Btn8.Content = "X"; } else { Btn8.Content = "O"; }
                Xruch = !Xruch;
                Row();
                UpdateTextBoxRightTop();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CzyscMape();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            CzyscMape();
            Xpts = 0;
            Opts = 0;
            TextboxRightBottom.Visibility = Visibility.Hidden;
            Xruch = true;
            UpdateTextBoxRightTop();
            UpdateTextBoxTop();
        }
    }
}
