using Microsoft.Maui.Controls;

namespace EventoApp
{
    public partial class MainPage : ContentPage
    {
        public Evento Evento { get; set; }
        public Command CadastrarEventoCommand { get; }

        public MainPage()
        {
            InitializeComponent();
            
            // Inicializando o objeto Evento com valores padrão
            Evento = new Evento
            {
                Nome = string.Empty, // Ou um valor padrão
                Local = string.Empty // Ou um valor padrão
            };

            BindingContext = this;

            CadastrarEventoCommand = new Command(CadastrarEvento);
        }

        private async void CadastrarEvento()
        {
            // Navegar para a página de resumo com o evento cadastrado
            await Navigation.PushAsync(new ResumoPage(Evento));
        }
    }
}
