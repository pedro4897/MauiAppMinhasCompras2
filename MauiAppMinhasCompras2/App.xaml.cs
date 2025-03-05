namespace MauiAppMinhasCompras2
{
    public partial class App : Application
    {
        public App()
        {
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
