package desafioPOO;

import java.time.LocalDate;

public class Mentoria extends Conteudo {
	
	private String titulo;
	private String descricao;
	private LocalDate data;

	public LocalDate getData() {
		return data;
	}
	public void setData(LocalDate data) {
		this.data = data;
	}
	@Override
	public String toString() {
		return "Mentoria [titulo=" + titulo + ", descricao=" + descricao + ", data=" + data + "]";
	}
	@Override
	public double calcularXp() {

		return xpPadrao + 20;
	}
	
	
}
