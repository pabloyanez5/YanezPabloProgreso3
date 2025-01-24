namespace MAUI_Aeropuertos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new SearchPage()) { Title = "Buscar" },
                new NavigationPage(new ListPage()) { Title = "Consultados" }
                }
            };
        }
    }
}


