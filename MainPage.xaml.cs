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
             private void OnAllClear(object sender, EventArgs e)
        {
            screen.Text = string.Empty;
            changer = "";
           firstNumber.Text = string.Empty;

            SemanticScreenReader.Announce(screen.Text);
            SemanticScreenReader.Announce(firstNumber.Text);

        }

        private void OnExecuteCommand(object sender, EventArgs e)
        {
            updateScreen.Clear();
            
            //screen.Text= add.Text ;
            if (sender is Button Button)
            {

                //selections.Add(Button.Text);
                //updateScreen = selections;
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
