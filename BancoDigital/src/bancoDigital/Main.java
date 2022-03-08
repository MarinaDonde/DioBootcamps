package bancoDigital;

public class Main {

	public static void main(String[] args) {
		
		
		
	
		
		Cliente cliente = new Cliente();
		cliente.setNome("Luna" );
		
		IConta cc = new ContaCorrente(cliente);
		IConta poupanca = new ContaPoupanca(cliente);
		
		
        cc.depositar(1000);
        poupanca.depositar(2000);
        cc.transferir(5000,poupanca);
        poupanca.transferir(1500,cc);
		cc.depositar(100);
		cc.transferir(1000, poupanca);
		
        System.out.println("*** Extrato Conta Corrente ***");
		cc.imprimirExtrato();
        System.out.println("\n*** Extrato Conta Poupanca ***");
		poupanca.imprimirExtrato();
		
	}
		

}

