using CadastrodeEventos.Models;

namespace CadastrodeEventos
{
    public partial class ResumoPage : ContentPage
    {
        public ResumoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}
