public class Empresa {
    public List<Funcionario> listaFuncionarios = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario) {
        listaFuncionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula) {
        for (int i = 0; i < listaFuncionarios.Count; i++) {
            if (listaFuncionarios[i].matricula == matricula) {
                listaFuncionarios.Remove(listaFuncionarios[i]);
            } else {
                Console.WriteLine("Matricula não escontrada!");
            }
        } 
    }

    public void ExibirFuncionarios() {
        for (int i = 0; i < listaFuncionarios.Count; i++) {
            listaFuncionarios[i].ExibirInformacoes();
        } 
    }



}