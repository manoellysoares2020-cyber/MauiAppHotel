namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private async void Avancar2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }

        private async void Voltar2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Volta para a tela anterior
        }
    }
}