public abstract class Funcionario {

    // Atributos
    public string nome; // Nome do funcionário
    public int matricula; // Matrícula do funcionário
    List<string> Projetos = new List<string>(); // Lista de projetos associados ao funcionário

    // Construtor
    public Funcionario(string nome, int matricula) {
        this.nome = nome; 
        this.matricula = matricula; 
    }
    
    // Método abstrato para calcular o salário
    public abstract double CalcularSalario();

    // Método abstrato para exibir informações do funcionário
    public abstract void ExibirInformacoes();

    // Método para adicionar um projeto a lista de projetos do funcionário
    public void AdicionarProjeto(string projeto) {
        Projetos.Add(projeto); 
    } 

    // Sobrecarga do método AdicionarProjeto para adicionar uma lista de projetos
    public void AdicionarProjeto(List<string> projetos) {
        // Itera sobre a lista de projetos e adiciona cada um à lista de projetos do funcionário
        for (int i = 0; i < projetos.Count; i++) {
            Projetos.Add(projetos[i]);
        }
    }
}
