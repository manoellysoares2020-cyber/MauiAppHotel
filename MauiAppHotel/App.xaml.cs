using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
            Descricao = "Suíte Super Luxo",
            ValorDiariaAdulto = 150.00,
            ValorDiariaCriaca = 55.00
            },

            new Quarto()
            {
            Descricao = "Suíte Luxo",
            ValorDiariaAdulto = 80.00,
            ValorDiariaCriaca = 40.00
            },

             new Quarto()
            {
            Descricao = "Suíte Single",
            ValorDiariaAdulto = 50.00,
            ValorDiariaCriaca = 25.00
            },

             new Quarto()
            {
            Descricao = "Suíte Crise",
            ValorDiariaAdulto = 25.00,
            ValorDiariaCriaca = 12.50
            }
        };
          
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoDaHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}