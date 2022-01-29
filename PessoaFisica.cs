namespace UltimoDesafioModulo.Entidades
{
    internal class PessoaFisica : TaxaPagamento
    {

        public double gastoSaude;

        public PessoaFisica(double gastoSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            this.gastoSaude = gastoSaude;
        }

        public override double taxa()
        {
            double soma = 0;
            if(rendaAnual < 20000)
            {
                if(gastoSaude > 0)
                {
                    soma = (rendaAnual * 0.15) - (gastoSaude * 0.50);
                }else
                {
                    soma = rendaAnual * 0.15;
                }
            } else if(rendaAnual > 20000)
            {
                if (gastoSaude > 0)
                {
                    soma = (rendaAnual * 0.25) - (gastoSaude * 0.50);
                }
                else
                {
                    soma = rendaAnual * 0.25;
                }
            }

            return soma;
        }
    }
}
