namespace ContaBancaria
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        void Transferir(double valor, IConta contaDestino);
        void ExibirInformacoes();

    }
}
