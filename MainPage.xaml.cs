namespace MauiCalc
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string outPutData = "0";
        List<string> buttons = new() { "3","5"};
        string changer = "test";

        public MainPage()
        {
            InitializeComponent();
        }


        
             private void OnAllClear(object sender, EventArgs e)
        {
            screen.Text = string.Empty;
            SemanticScreenReader.Announce(screen.Text);
        }

        private void OnExecuteCommand(object sender, EventArgs e)
        {
            //screen.Text= add.Text ;
            if (sender is Button Button)
            {
                foreach (string button in buttons)
                {
                    changer = changer + button;
                }


                screen.Text = Button.Text + changer;
            }


                SemanticScreenReader.Announce(screen.Text);
        }
    }

}
