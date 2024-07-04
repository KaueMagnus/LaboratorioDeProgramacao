public abstract class Funcionario {
    public string nome;
    public int matricula;
    List<string> Projetos = new List<string>();

    public Funcionario(string nome, int matricula) {
        this.nome = nome;
        this.matricula = matricula;
    }
    
    public abstract double CalcularSalario();

    public abstract void ExibirInformacoes();

    public void AdicionarProjeto(string projeto) {
        Projetos.Add(projeto);
    } 

    public void AdicionarProjeto(List<string> projetos) {
        for (int i = 0; i < projetos.Count; i++) {
            Projetos.Add(projetos[i]);
        }
    }
        
    


}