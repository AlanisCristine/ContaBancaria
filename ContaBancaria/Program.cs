using ContaBancaria;

ContaCorrente conta1 = new ContaCorrente("Alanis", 10, 100);
//conta1.ExibirInformacoes();
//conta1.Depositar(20);
//conta1.Sacar(5);

ContaPoupança conta2 = new ContaPoupança("Pérola", 20, 0.5);
conta2.ExibirInformacoes();
conta2.Depositar(5);
conta2.Sacar(1);
conta2.Transferir(10, conta1);
