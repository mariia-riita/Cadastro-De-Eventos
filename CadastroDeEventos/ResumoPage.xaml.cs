using Microsoft.Maui.Controls;

namespace EventoApp
{
    public partial class ResumoPage : ContentPage
    {
        public Evento Evento { get; set; }
        public Command VoltarCommand { get; }

        public ResumoPage(Evento evento)
        {
            InitializeComponent();
            Evento = evento;
            BindingContext = this;

            VoltarCommand = new Command(async () => await Navigation.PopAsync());
        }
    }
}
