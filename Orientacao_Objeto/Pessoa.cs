//namespace Pessoa
//{
public class Pessoa
{
    public string nome;
    public string endereco;
    public string sexo;
    public string telefone;
    public float salario;
    public DateOnly nascimento;

    public Pessoa()
    {

    }
    public void DefinirNome(string nome)
    {
        this.nome = nome;
    }
    public void DefinirEndereco(string e)
    {
        this.endereco = e;
    }
    public void DefinirSexo(string s)
    {
        this.sexo = s;
    }
    public void DefinirTelefone(string t)
    {
        this.telefone = t;
    }
    public void DefinirSalario(float s)
    {
        this.salario = s;
    }
    public void DefinirNascimento(DateOnly n)
    {
        this.nascimento = n;
    }
    public void ImprimirPessoa()
    {
        Console.WriteLine($"Nome da pessoa : {this.nome}");
        Console.WriteLine($"Endereço da pessoa : {this.endereco}");
        Console.WriteLine($"Sexo da pessoa : {this.sexo}");
        Console.WriteLine($"Telefone da pessoa : {this.telefone}");
        Console.WriteLine($"Salário da pessoa : {this.salario}");
        Console.WriteLine($"Dt.Nascimento da pessoa : {this.nascimento}");
    }
}

