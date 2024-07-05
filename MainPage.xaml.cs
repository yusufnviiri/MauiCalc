namespace MauiCalc
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string outPutData = "0";
        string mathsymbol = string.Empty;
        List<string> updateScreen = new List<string>();
        List<string> selections = new List<string>();

        string changer = "";
        List<string> mathSymbols = new() { "+", "-", "/", "x" };

        public MainPage()
        {
            InitializeComponent();
        }



        private void OnGetAnswer(object sender, EventArgs e)
        {
            var numOne = Convert.ToDecimal(firstNumber.Text);
            var numTwo = Convert.ToDecimal(screen.Text);
            switch (mathsymbol)
            {
                case "+":
                    screen.Text = Convert.ToString(numOne + numTwo);
                    break;
                case "-":
                    screen.Text = Convert.ToString(Math.Abs(numOne - numTwo));
                    break;
                case "/":
                    if (numTwo == 0)
                    {
                        screen.Text = "NAN";
                    }
                    else
                    {

                        screen.Text = Convert.ToString(numOne / numTwo);
                    }
                    break;
                case "x":
                    screen.Text = Convert.ToString(numOne * numTwo);
                    break;
                default: screen.Text = "0"; break;
            }

            selectedOperation.Text = goTo.Text;

        }




                private void OnAllClear(object sender, EventArgs e) {
            {
                screen.Text = string.Empty;
                changer = "";
                firstNumber.Text = string.Empty;

                SemanticScreenReader.Announce(screen.Text);
                SemanticScreenReader.Announce(firstNumber.Text);
            }


        }

        private void OnExecuteCommand(object sender, EventArgs e)
        {
            updateScreen.Clear();
            
            //screen.Text= add.Text ;
            if (sender is Button Button)
            {


               
                    string mathOperation = mathSymbols.Where(p => p == Button.Text).FirstOrDefault();
                    if (mathOperation == null)
                    {

                        screen.Text = changer + Button.Text;
                        changer = screen.Text;
                    }
                    else
                    {
                        mathsymbol = mathOperation;
                        firstNumber.Text = screen.Text;
                        selectedOperation.Text = mathsymbol;
                        screen.Text = "";
                        changer = "";
                    }
                
            }


            SemanticScreenReader.Announce(screen.Text);
        }
    }

}
