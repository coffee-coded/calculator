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

namespace Calculator
{
    /// <summary>
    /// Calculator
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _previous = 0, _dCount = 1, _x = 0, _y, _z;
        int _d0 = 0, _dToggle = 0, _ex = -1, _op = -1, _equalActivated = 0, _dt = 0;

        // previous stores the previous values, present inputs are taken in x
        // while initiating any operation, it is transferred to previous
        // d_count keeps count of the number of digits entered after decimal, and uses it to insert values
        // y and z are normal local variables
        // d_0 counts number of zeros inserted to keep track of 0 if a 0 is entered continuously after decimal
        // d_toggle is a toggle to keep in mind, that the digits will be entered as a part of the decimal and not normal int
        // ex = keeps track of the last inserted digit so it can be used as a flag for the backspace
        // op is the present operation count,
        // 1. for addition 2 for subtraction
        // 3 for multiplication 
        // 4 for division
        // 5 for power
        // equal_activated is a flag used, to determine if after equal we have to continue with calculation or clear everything
        // dt is a flag that dot button has been pressed once, the toggle is done and shall not be work again


        public MainWindow()
        {
            InitializeComponent();
            text_box.Text = "0";
        }

        private void op1()
        {
            _previous = _previous + _x;
            text_box.Text = "" + _previous;
        }

        private void op2()
        {
            _previous -= _x;
        }

        private void op3()
        {
            _previous *= _x;
        }

        private void op4()
        {
            _previous /= _x;
        }

        private void op5()
        {
            _previous = Math.Pow(_previous, _x);
        }

        private void clear()
        {
            _previous = 0;
            _dCount = 1;
            _dToggle = 0;
            _x = 0;
            _d0 = 0;
            _dt = 0;
            _ex = -1;
            _op = -1;
            _equalActivated = 0;

            text_box.Text = "" + _x;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 7
            if (_equalActivated == 1)
                clear();
            _ex = 7;
            _d0 = 0;
            if (_dToggle == 0)
            {
                _x = (_x * 10) + 7;
            }
            else
            {
                _x = _x + (_dCount) * 7;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 8
            if (_equalActivated == 1)
                clear();
            _ex = 8;
            _d0 = 0;

            if (_dToggle == 0)
            {
                _x = (_x * 10) + 8;
            }
            else
            {
                _x = _x + (_dCount) * 8;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 9
            if (_equalActivated == 1)
                clear();
            _ex = 9;

            if (_dToggle == 0)
            {
                _x = (_x * 10) + 9;
            }
            else
            {
                _x = _x + (_dCount) * 9;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
            _d0 = 0;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 6
            if (_equalActivated == 1)
                clear();
            _ex = 6;

            if (_dToggle == 0)
            {
                _x = (_x * 10) + 6;
            }
            else
            {
                _x = _x + (_dCount) * 6;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
            _d0 = 0;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            _ex = 5;
            if (_equalActivated == 1)
                clear();
            //Button 5

            if (_dToggle == 0)
            {
                _x = (_x * 10) + 5;
            }
            else
            {
                _x = _x + (_dCount) * 5;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
            _d0 = 0;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 4
            if (_equalActivated == 1)
                clear();
            _ex = 4;

            if (_dToggle == 0)
            {
                _x = (_x * 10) + 4;
            }
            else
            {
                _x = _x + (_dCount) * 4;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
            _d0 = 0;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 3
            if (_equalActivated == 1)
                clear();
            _ex = 3;
            if (_dToggle == 0)
            {
                _x = (_x * 10) + 3;
            }
            else
            {
                _x = _x + (_dCount) * 3;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
            _d0 = 0;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 2
            if (_equalActivated == 1)
                clear();
            _ex = 2;
            if (_dToggle == 0)
            {
                _x = (_x * 10) + 2;
            }
            else
            {
                _x = _x + (_dCount) * 2;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
            _d0 = 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Backspace button
            if (_equalActivated == 1)
                clear();
            if (_ex == -1)
                return;
            else if (_dToggle == 0 && _x != 0)
            {
                _x = (int) _x / 10;
                if (_x / 10 == 0.0)
                {
                    _x = 0;
                    _ex = -1;
                }
            }
            else if (_dToggle == 1)
            {
                _dCount *= 10;
                _y = _dCount;
                _z = _x;
                while (_y != 1)
                {
                    _z *= 10;
                    _y *= 10;
                }

                _y = _z % 10;
                _x = _x - (_dCount) * _y;
                _d0--;
            }

            text_box.Text = "" + _x;
            if (_dCount == 0.1)
            {
                _dCount = 1;
                _dToggle = 0;
                _d0 = 0;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //sqrt button
            if (_equalActivated == 1 || (_x == 0 && _previous != 0))
            {
                _previous = Math.Sqrt(_previous);
                text_box.Text = "" + _previous;
            }
            else
            {
                _x = Math.Sqrt(_x);
                text_box.Text = "" + _x;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //% buttpm
            if (_equalActivated == 1 || (_x == 0 && _previous != 0))
            {
                _previous = _previous / 100;
                text_box.Text = "" + _previous;
            }
            else
            {
                _x = _x / 100;
                text_box.Text = "" + _x;
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            //^ button
            if (_equalActivated == 1)
                _equalActivated = 0;
            if (_op == -1)
            {
                _op = 5;
                _previous = _x;
            }
            else if (_op == 1)
            {
                op1();
            }
            else if (_op == 2)
            {
                op2();
            }
            else if (_op == 3)
            {
                op3();
            }
            else if (_op == 4)
            {
                op4();
            }
            else if (_op == 5)
            {
                op5();
            }

            _op = 5;

            _x = 0;
            _d0 = 0;
            _dCount = 1;
            _dToggle = 0;
            _ex = -1;
            text_box.Text = "" + _previous + "^";
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            double i, fact = 1;

            //! buttpm
            if (_equalActivated == 1 || (_x == 0 && _previous != 0))
            {
                for (i = 1; i <= _previous; i++)
                {
                    fact = fact * i;
                }

                _previous = fact;
                text_box.Text = "" + _previous;
            }
            else
            {
                for (i = 1; i <= _x; i++)
                {
                    fact = fact * i;
                }

                _x = fact;
                text_box.Text = "" + _x;
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            //Button 1
            if (_equalActivated == 1)
                clear();
            _ex = 1;
            if (_dToggle == 0)
            {
                _x = (_x * 10) + 1;
            }
            else
            {
                _x = _x + (_dCount) * 1;
                _dCount /= 10;
            }

            text_box.Text = "" + _x;
            _d0 = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _dt = 0;
            // equal button
            _equalActivated = 1;

            if (_op == -1)
            {
                _previous = _x;
            }
            else if (_op == 1)
            {
                op1();
            }
            else if (_op == 2)
            {
                op2();
            }
            else if (_op == 3)
            {
                op3();
            }
            else if (_op == 4)
            {
                op4();
            }
            else if (_op == 5)
            {
                op5();
            }

            _op = -1;
            _x = _previous;
            _d0 = 0;
            _dCount = 0;
            _dToggle = 0;
            _ex = -1;
            text_box.Text = "" + _previous;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            //dot button
            if (_equalActivated == 1)
                clear();
            if (_dToggle == 0)
            {
                _dt = 1;
                _dToggle = 1;
                _dCount /= 10;
                text_box.Text = "" + _x + ".";
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            //Button 0
            if (_equalActivated == 1)
                clear();
            _ex = 0;
            if (_dToggle == 0)
            {
                _x = (_x * 10) + 0;
                _d0++;
                text_box.Text = "" + _x;
            }
            else if (_dToggle != 0)
            {
                _x = _x + (_dCount) * 0;
                _dCount /= 10;
                _d0++;
                if (_dt == 0)
                {
                    switch (_d0)
                    {
                        case 1:
                            text_box.Text = "" + _x + "0";
                            break;
                        case 2:
                            text_box.Text = "" + _x + "00";
                            break;
                        case 3:
                            text_box.Text = "" + _x + "000";
                            break;
                        case 4:
                            text_box.Text = "" + _x + "0000";
                            break;
                        case 5:
                            text_box.Text = "" + _x + "00000";
                            break;
                        case 6:
                            text_box.Text = "" + _x + "0000000";
                            break;
                        case 7:
                            text_box.Text = "" + _x + "00000000";
                            break;
                        case 8:
                            text_box.Text = "" + _x + "000000000";
                            break;
                        case 9:
                            text_box.Text = "" + _x + "0000000000";
                            break;
                        case 10:
                            text_box.Text = "" + _x + "00000000000";
                            break;
                        case 11:
                            text_box.Text = "" + _x + "000000000000";
                            break;
                        case 12:
                            text_box.Text = "" + _x + "00000000000000";
                            break;
                    }
                }

                if (_dt == 1)
                {
                    switch (_d0)
                    {
                        case 1:
                            text_box.Text = "" + _x + ".0";
                            break;
                        case 2:
                            text_box.Text = "" + _x + ".00";
                            break;
                        case 3:
                            text_box.Text = "" + _x + ".000";
                            break;
                        case 4:
                            text_box.Text = "" + _x + ".0000";
                            break;
                        case 5:
                            text_box.Text = "" + _x + ".00000";
                            break;
                        case 6:
                            text_box.Text = "" + _x + ".0000000";
                            break;
                        case 7:
                            text_box.Text = "" + _x + ".00000000";
                            break;
                        case 8:
                            text_box.Text = "" + _x + ".000000000";
                            break;
                        case 9:
                            text_box.Text = "" + _x + ".0000000000";
                            break;
                        case 10:
                            text_box.Text = "" + _x + ".00000000000";
                            break;
                        case 11:
                            text_box.Text = "" + _x + ".000000000000";
                            break;
                        case 12:
                            text_box.Text = "" + _x + ".00000000000000";
                            break;
                    }
                }
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            //clear button
            clear();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            //+ button
            if (_equalActivated == 1)
                _equalActivated = 0;
            if (_op == -1)
            {
                _op = 1;
                _previous = _x;
            }
            else if (_op == 1)
            {
                op1();
            }
            else if (_op == 2)
            {
                op2();
            }
            else if (_op == 3)
            {
                op3();
            }
            else if (_op == 4)
            {
                op4();
            }
            else if (_op == 5)
            {
                op5();
            }

            _op = 1;

            _x = 0;
            _d0 = 0;
            _dCount = 1;
            _dToggle = 0;
            _ex = -1;
            text_box.Text = "" + _previous + "+";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Backspace button
            if (_equalActivated == 1)
                clear();
            if (_ex == -1)
                return;
            else if (_dToggle == 0 && _x != 0)
            {
                _x = (int) _x / 10;
                if (_x / 10 == 0.0)
                {
                    _x = 0;
                    _ex = -1;
                }
            }
            else if (_dToggle == 1)
            {
                _dCount *= 10;
                _y = _dCount;
                _z = _x;
                while (_y != 1)
                {
                    _z *= 10;
                    _y *= 10;
                }

                _y = _z % 10;
                _x = _x - (_dCount) * _y;
                _d0--;
            }

            text_box.Text = "" + _x;
            if (_dCount == 0.1)
            {
                _dCount = 1;
                _dToggle = 0;
                _d0 = 0;
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            //- button
            if (_equalActivated == 1)
                _equalActivated = 0;
            if (_op == -1)
            {
                _previous = _x;
            }
            else if (_op == 1)
            {
                op1();
            }
            else if (_op == 2)
            {
                op2();
            }
            else if (_op == 3)
            {
                op3();
            }
            else if (_op == 4)
            {
                op4();
            }
            else if (_op == 5)
            {
                op5();
            }

            _op = 2;

            _x = 0;
            _d0 = 0;
            _dCount = 1;
            _dToggle = 0;
            _ex = -1;
            text_box.Text = "" + _previous + "-";
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            //* button
            if (_equalActivated == 1)
                _equalActivated = 0;

            if (_op == -1)
            {
                _previous = _x;
            }
            else if (_op == 1)
            {
                op1();
            }
            else if (_op == 2)
            {
                op2();
            }
            else if (_op == 3)
            {
                op3();
            }
            else if (_op == 4)
            {
                op4();
            }
            else if (_op == 5)
            {
                op5();
            }

            _op = 3;

            _x = 0;
            _d0 = 0;
            _dCount = 1;
            _dToggle = 0;
            _ex = -1;
            text_box.Text = "" + _previous + "x";
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            // divide button
            if (_equalActivated == 1)
                _equalActivated = 0;
            if (_op == -1)
            {
                _previous = _x;
            }
            else if (_op == 1)
            {
                op1();
            }
            else if (_op == 2)
            {
                op2();
            }
            else if (_op == 3)
            {
                op3();
            }
            else if (_op == 4)
            {
                op4();
            }
            else if (_op == 5)
            {
                op5();
            }

            _op = 4;

            _x = 0;
            _d0 = 0;
            _dCount = 1;
            _dToggle = 0;
            _ex = -1;
            text_box.Text = "" + _previous + "/";
        }
    }
}