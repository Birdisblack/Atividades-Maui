using CadastrodeEventos.Models;
using System.ComponentModel;

namespace CadastrodeEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new EventoViewModel();
        }
    }

    public class EventoViewModel : INotifyPropertyChanged
    {
        public Evento Evento { get; set; } = new Evento();
        public Command SalvarCommand { get; }

        public EventoViewModel()
        {
            SalvarCommand = new Command(OnSalvar);
        }

        private async void OnSalvar()
        {
            // Navegar para a página de resumo
            await Application.Current.MainPage.Navigation.PushAsync(new ResumoPage(Evento));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
