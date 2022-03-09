package desafioPOO;

public class Curso extends Conteudo{
	
	private String titulo;
	private String descricao;
	private int cargaHoraria;

	
	public int getCargaHoraria() {
		return cargaHoraria;
	}
	
	public void setCargaHoraria(int cargaHoraria) {
		this.cargaHoraria = cargaHoraria;
	}
	
	@Override
	public String toString() {
		return "Curso [titulo=" + titulo + ", descricao=" + descricao + ", cargaHoraria=" + cargaHoraria + "]";
	}
	
	@Override
	public double calcularXp() {

		return xpPadrao * cargaHoraria;
	}
	
	
	
}
