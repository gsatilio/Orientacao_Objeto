string dados;
//Classe | Objeto
Pessoa objPessoa1 = new Pessoa();
Pessoa objPessoa2 = new Pessoa();
Pessoa objPessoa3 = new Pessoa();

#region criarpessoa por funcao

Pessoa criarPessoa()
{
    Pessoa objTemp = new Pessoa();
    objTemp.Nome = objTemp.DefinirNome();
    objTemp.Sobrenome = objTemp.DefinirSobrenome();
    objTemp.Idade = objTemp.DefinirIdade();
    Console.WriteLine("Informe o seu Telefone:");
    dados = Console.ReadLine();
    objTemp.DefinirTelefone(dados);
    Console.WriteLine("Informe o seu Celular:");
    dados = Console.ReadLine();
    objTemp.DefinirCelular(dados);
    Console.WriteLine("Informe o seu Email:");
    dados = Console.ReadLine();
    objTemp.DefinirEmail(dados);

    return objTemp;
}
#endregion

objPessoa1 = criarPessoa();
objPessoa1.MostrarDados();
objPessoa2 = criarPessoa();
objPessoa2.MostrarDados();
objPessoa3 = criarPessoa();
objPessoa3.MostrarDados();
