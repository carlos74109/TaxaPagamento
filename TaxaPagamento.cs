namespace UltimoDesafioModulo.Entidades
{
    abstract internal class TaxaPagamento
    {

        public string nome;
        public double rendaAnual;

        protected TaxaPagamento(string nome, double rendaAnual)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
        }

        public abstract double taxa();

    }
}
