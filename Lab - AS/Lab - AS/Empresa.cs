public class Empresa {

    // Lista para armazenar os funcionários da empresa
    public List<Funcionario> listaFuncionarios = new List<Funcionario>();

    // Método para adicionar um funcionário à lista
    public void AdicionarFuncionario(Funcionario funcionario) {
        listaFuncionarios.Add(funcionario); 
    }

    // Método para remover um funcionário da lista com base na matrícula
    public void RemoverFuncionario(int matricula) {
        // Itera sobre a lista de funcionários
        for (int i = 0; i < listaFuncionarios.Count; i++) {
            // Se encontrar um funcionário com a matrícula correspondente
            if (listaFuncionarios[i].matricula == matricula) {
                listaFuncionarios.Remove(listaFuncionarios[i]); // Remove o funcionário da lista
                return; // Encerra o loop após remover o funcionário
            }
        }
        // Se a matrícula não for encontrada, exibe uma mensagem de erro
        Console.WriteLine("Matrícula não encontrada!");
    }

    // Método para exibir informações de todos os funcionários na lista
    public void ExibirFuncionarios() {
        // Itera sobre a lista de funcionários
        for (int i = 0; i < listaFuncionarios.Count; i++) {
            listaFuncionarios[i].ExibirInformacoes(); 
        } 
    }
}
