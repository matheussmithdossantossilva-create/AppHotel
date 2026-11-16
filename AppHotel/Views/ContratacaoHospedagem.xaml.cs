
namespace AppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        DataEntradaPicker.Date = DateTime.Today;
        AcomodacaoPicker.SelectedIndex = 0;
    }

    private void OnQuantidadeChanged(object sender, ValueChangedEventArgs e)
    {
        int quantidade = (int)e.NewValue;

        QuantidadeLabel.Text = quantidade == 1
            ? "1 hóspede"
            : $"{quantidade} hóspedes";
    }

    private async void OnContratarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NomeEntry.Text))
        {
            await DisplayAlert("Atenção", "Digite o nome do hóspede.", "OK");
            return;
        }

        if (AcomodacaoPicker.SelectedIndex == -1)
        {
            await DisplayAlert("Atenção", "Selecione uma acomodação.", "OK");
            return;
        }

        ReservaDados.Nome = NomeEntry.Text;
        ReservaDados.Quantidade = (int)QuantidadeStepper.Value;
        ReservaDados.Data = DataEntradaPicker.Date ?? DateTime.Today;
        ReservaDados.Acomodacao = AcomodacaoPicker.SelectedItem?.ToString() ?? "";

        // Navega para a página de hospedagem contratada
        await Shell.Current.GoToAsync("///HospedagemContratada");
    }
}
