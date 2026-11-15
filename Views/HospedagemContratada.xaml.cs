
namespace AppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        NomeLabel.Text = $"Hóspede: {ReservaDados.Nome}";
        QuantidadeLabel.Text = $"Quantidade: {ReservaDados.Quantidade} hóspede(s)";
        DataLabel.Text = $"Data de entrada: {ReservaDados.Data:dd/MM/yyyy}";
        AcomodacaoLabel.Text = $"Acomodação: {ReservaDados.Acomodacao}";
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // Volta para a página de contratação
        await Shell.Current.GoToAsync("///ContratacaoHospedagem");
    }
}
