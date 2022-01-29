namespace UltimoDesafioModulo.Entidades
{
    internal class PessoaJuridica : TaxaPagamento
    {

        public int qtdeFuncionario;
        
        public PessoaJuridica(string nome, double rendaAnual, int qtdeFuncionario) : base(nome, rendaAnual)
        {
            this.qtdeFuncionario = qtdeFuncionario;
        }
        public override double taxa()
        {
            double soma = 0;
            if(qtdeFuncionario <= 10)
            {
                soma = rendaAnual * 0.16;
            }else if(qtdeFuncionario > 10)
            {
                soma = rendaAnual * 0.14;
            }

            return soma;
        }
    }
}
