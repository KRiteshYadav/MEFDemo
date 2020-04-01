using System;
using System.Windows;
using CalHelper;

namespace CalciUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalciCompositionHelper objCalciFactory;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DoCalciOperation("Add");
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            DoCalciOperation("Subtract");
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            DoCalciOperation("Multiply");
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            DoCalciOperation("Divide");
        }

        private void btnModDivide_Click(object sender, RoutedEventArgs e)
        {
            DoCalciOperation("ModuloDivision");
        }

        private void DoCalciOperation(string operationType)
        {
            objCalciFactory = new CalciCompositionHelper();

            //Assembles the calculator components that will participate in composition
            objCalciFactory.AssembleCalculatorComponents();

            //Gets the result
            var result = objCalciFactory.GetResult(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text), operationType);

            //Display the result
            txtResult.Text = result.ToString();
        }


    }
}