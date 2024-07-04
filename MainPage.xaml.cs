namespace MauiCalc
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string outPutData = "0";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnExecuteCommand(object sender, EventArgs e)
        {
           //screen.Text= add.Text ;
           if (sender is Button Button)         
            screen.Text = Button.Text;
           


            SemanticScreenReader.Announce(screen.Text);
        }
    }

}
