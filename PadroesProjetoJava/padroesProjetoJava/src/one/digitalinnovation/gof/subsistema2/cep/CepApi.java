package one.digitalinnovation.gof.subsistema2.cep;

public class CepApi {
    private static CepApi instacia = new CepApi();

    private CepApi() {
        super();
    }

    public static CepApi getInstacia() {
        return instacia;
    }

    public String recuperarCidade(String cep) {
        return "Belo Horizonte";
    }
    public String recuperarEstado(String cep) {
        return "MG";
    }
}
