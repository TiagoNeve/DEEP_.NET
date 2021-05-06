// Iniciando em C#, tudo vai dar certo

// Iniciando com .NET
/*
    Para verificar a versão do dotnet basta executar o código: 
    dotnet --help -> Mostra todos os comandos que o dotnet pode executar via linha de comando
    dotnet [command] --help -> Mostra o help do comando em questão 

    3 - Criando uma aplicação console. 
    Para criar uma aplicação console no dotnet, execute o comando :
    
    dotnet new console -n [nome do projeto] -> 
    Isso irá gerar uma pasta com um template inicial que todo programa c# deve ter

    $ dotnet restore -> Irá baixar as dependências do programa

    $ dotnet build -> Compila o código e gera um executável

    $ dotnet run -> Compila o programa e executa na linha de comando

    # Console.WriteLine() -> Escreve no console do programa

    Para declarar variáveis no C# deve seguir esse padrão: 
    [tipo] [nome] = [valor];

    int numeroDeVezes = 5;

    Para usar string interpolation basta colocar um $ no ínicio da string
    ai coloca as variáveis dentro de chaves.
    $"Eu sou um texto {variavelAqui}"
*/

// Conhecendo o C# 
/*
    1 - O que é e como funciona o C# 

    Foi dado uma explicação de como o C# funciona, basicamente ele compila
    para exe ou dll, depois utilizar o JIT para executar na linha de comando
    que o programa foi chamado, se não quiser utilizar a sua linha de comando
    basta clicar no exe que o mesmo executa.

    2 - Estrutura de programa

    Os principais conceitos organizacionais são :
        Programas
        Namespaces
        Tipos
        Membros
        Assemblies
    Os programas declaram tipos, em que estes podem ter membros e serem 
    organizados em namespaces. 
    Classes e interfaces são exemplos de tipos  
    Campos, métodos, atributos e eventos são exmplos de membros
    Utilizar o conceito de organização de pastas e chamado de classes 
    utilizando a palavra reservada using
    Utilizar Try ... Catch, para tratamento de erros .
    Por boas práticas recomenda utilizar o namespace de acordo com a estrutura
    de pastas que o programa está recebendo
    
*/