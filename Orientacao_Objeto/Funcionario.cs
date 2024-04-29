// cliente herdada de Pessoa
internal class Funcionario : Pessoa
{
    public string cargo;
    public int codigo;
    public Funcionario()
    {

    }
    public void DefinirCargo(string cargo)
    {
        this.cargo = cargo;
    }
    public void DefinirCodigo(int codigo)
    {
        this.codigo = codigo;
    }
    public void ImprimirFuncionario()
    {
        ImprimirPessoa();
        Console.WriteLine($"Cargo do Funcionário: {this.cargo}");
        Console.WriteLine($"Código do Funcionário: {this.codigo}");
    }
}

