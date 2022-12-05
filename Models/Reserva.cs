namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      if (Suite.Capacidade >= hospedes.Count)
      {
        Hospedes = hospedes;
      }
      else
      {

        Console.WriteLine($"Falha no Cadastro. Esta Suite tem capacidade para {Suite.Capacidade} Hospedes");

      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      try
      {
        int qtdHospedes = Hospedes.Count;
        return qtdHospedes;
      }
      catch (Exception)
      {
        DiasReservados = 0;
        Console.WriteLine("Suite não Localizada");

        return 0;

      }
    }

    public decimal CalcularValorDiaria()
    {

      decimal valor = DiasReservados * Suite.ValorDiaria;

      if (DiasReservados >= 10)
      {
        decimal descontoDiaria = valor * Convert.ToDecimal(0.10);

        valor += -descontoDiaria;
      }
      return valor;
    }
  }
}