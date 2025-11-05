using MauiAppHotel.Views;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoDaHospedagem : ContentPage
    {

        App PropriedadesApp;

        public ContratacaoDaHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day );

            dtpck_checkout.MinimumDate = dtpck_checkin.Date.Value.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.Value.AddMonths(6);

        }

        private async void btnAvancar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }
    }
}
