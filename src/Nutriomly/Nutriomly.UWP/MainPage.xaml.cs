namespace Nutriomly.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new Nutriomly.App());
        }
    }
}