public class Evento
{
    public required string Nome { get; set; }
    public required string Local { get; set; }

    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public int NumeroParticipantes { get; set; }
    public decimal CustoPorParticipante { get; set; }

    public int Duracao => (DataTermino - DataInicio).Days;

    public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
}
