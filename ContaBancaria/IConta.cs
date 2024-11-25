namespace ContaBancaria
{
    public interface IConta
    {
        void Depositar(decimal valor);
        bool Sacar(decimal valor);
        void Transferir(decimal valor, IConta contaDestino);
        void ExibirInformacoes();

    }
}
