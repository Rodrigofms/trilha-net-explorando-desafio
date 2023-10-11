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
            bool verificacao = Suite.Capacidade >= hospedes.Count;

            if (verificacao)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Aviso! A quantidade de hóspedes não pode ultrapassar a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;

            if (DiasReservados >= 10)
            {

                valor = DiasReservados * Suite.ValorDiaria;
                decimal valorComDesconto = 0;
                valorComDesconto = valor * 0.10M;
                valor -= valorComDesconto;
                return valor;
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
                decimal valorComVirgula = Convert.ToDecimal(string.Format("{0:0.00}", valor));
                return valorComVirgula;
            }
        }
    }
}