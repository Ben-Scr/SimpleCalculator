using BenScr.Math.Parser;
using System.ComponentModel;
using System.Data;
using System.Windows;

namespace BenScr.SimpleCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Display.TextChanged += Display_TextChanged;
            RegisterButtonEvents();
            this.Closing += MainWindow_OnClosing;
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            UnRegisterButtonEvents();
        }

        private void Display_TextChanged(object sender, RoutedEventArgs e)
        {
            const string allowedChars = "0123456789 +-/%^x()*,.";
            Display.Text = new string(Display.Text.Where(c => allowedChars.Contains(c)).ToArray());
        }

        private void RegisterButtonEvents()
        {
            BtnZero.Click += BtnZero_OnClick;
            BtnOne.Click += BtnOne_OnClick;
            BtnTwo.Click += BtnTwo_OnClick;
            BtnThree.Click += BtnThree_OnClick;
            BtnFour.Click += BtnFour_OnClick;
            BtnFive.Click += BtnFive_OnClick;
            BtnSix.Click += BtnSix_OnClick;
            BtnSeven.Click += BtnSeven_OnClick;
            BtnEight.Click += BtnEight_OnClick;
            BtnNine.Click += BtnNine_OnClick;
            BtnComma.Click += BtnComma_OnClick;

            BtnPlus.Click += BtnPlus_OnClick;
            BtnMinus.Click += BtnMinus_OnClick;
            BtnMultiply.Click += BtnMultiply_OnClick;
            BtnDivide.Click += BtnDivide_OnClick;
            BtnModulo.Click += BtnModulo_OnClick;

            BtnClear.Click += BtnClear_OnClick;
            BtnDelete.Click += BtnDelete_OnClick;
            BtnCalculate.Click += BtnCalculate_OnClick;
        }
        private void UnRegisterButtonEvents()
        {
            BtnZero.Click -= BtnZero_OnClick;
            BtnOne.Click -= BtnOne_OnClick;
            BtnTwo.Click -= BtnTwo_OnClick;
            BtnThree.Click -= BtnThree_OnClick;
            BtnFour.Click -= BtnFour_OnClick;
            BtnFive.Click -= BtnFive_OnClick;
            BtnSix.Click -= BtnSix_OnClick;
            BtnSeven.Click -= BtnSeven_OnClick;
            BtnEight.Click -= BtnEight_OnClick;
            BtnNine.Click -= BtnNine_OnClick;
            BtnComma.Click += BtnComma_OnClick;

            BtnPlus.Click -= BtnPlus_OnClick;
            BtnMinus.Click -= BtnMinus_OnClick;
            BtnMultiply.Click -= BtnMultiply_OnClick;
            BtnDivide.Click -= BtnDivide_OnClick;
            BtnModulo.Click -= BtnModulo_OnClick;

            BtnClear.Click -= BtnClear_OnClick;
            BtnDelete.Click -= BtnDelete_OnClick;
            BtnCalculate.Click -= BtnCalculate_OnClick;
        }

        private void AddDisplayText<T>(T obj) // Note: Generic function for adding the numbers and operators to the display text
        {
            if (Display.Text == "Error" || Display.Text == "0") Display.Text = string.Empty;

            Display.Text += obj?.ToString() ?? "";
        }

        private void BtnCalculate_OnClick(object sender, RoutedEventArgs e)
        {
            Display.Text = Calculator.Evaluate<string>(Display.Text);
        }

        private void BtnClear_OnClick(object sender, RoutedEventArgs e)
        {
            Display.Text = string.Empty;
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            string text = Display.Text;
            int count = text[text.Length - 1] == ' ' ? 3 : 1;
            int startIndex = text.Length - count;
            Display.Text = Display.Text.Remove(startIndex, count);
        }

        #region Operator Button Events
        private void BtnPlus_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(" + ");
        }
        private void BtnComma_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(",");
        }
        private void BtnMinus_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(" - ");
        }
        private void BtnMultiply_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(" * ");
        }
        private void BtnDivide_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(" / ");
        }

        private void BtnModulo_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(" % ");
        }
        #endregion

        #region Number Button Events
        private void BtnZero_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(0);
        }
        private void BtnOne_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(1);
        }
        private void BtnTwo_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(2);
        }
        private void BtnThree_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(3);
        }
        private void BtnFour_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(4);
        }
        private void BtnFive_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(5);
        }
        private void BtnSix_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(6);
        }
        private void BtnSeven_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(7);
        }
        private void BtnEight_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(8);
        }
        private void BtnNine_OnClick(object sender, RoutedEventArgs e)
        {
            AddDisplayText(9);
        }
        #endregion
    }
}