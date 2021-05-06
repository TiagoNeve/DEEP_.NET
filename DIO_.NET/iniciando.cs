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

// Conhecendo variáveis e instruções
/*
    C# possui muitos tipos para se trabalhar, pois cada tipo tem uma forma
    específica de se guardar na memória e como a memória irá limitar de 
    acordo com o tipo.
*/

// Classes e objetos essenciais em C#
/*
    Classes e objetos -> São os tipos mais essenciais em c#, nelas são agrupados os estados ou campos e também os métodos
    Permite a criar os objetos e basicamente todo programa em c# tem que ter classes.

    Os objetos são as instâncias das classes. Como o C# utiliza a programação orientada a objetos, junto com ela vem todos
    os conceitos de POO, como herança, polimorfismo. 
    Para criar um novo objeto basta usar a palavra reservada [new], ela cria uma instância de uma classe, gerando um objeto
    O bom de utilizar o C# é que ele possui a função carbage collector, em que toda memória que não está sendo usada ela
    perde o seu local e é substituida por uma que está sendo utilizada, gerando uma performace maior ao programa.

    Como aplicar classes e objetos em projetos -> Para herdar de um classe basta criar um classe e colocar : e depois a 
    classe que a primeira irá herdar. Os métodos estáticos são utilizados apenas pela classe, não podem ser utilizados pela
    suas instâncias, os métodos protegidos podem ser utilizados por outras classes que recebem a classe do método como 
    herança, os métodos virtuais podem ter seu conteúdo sobrescrito pela palavra chave override, os métodos privates só 
    podem ser utilizados pelas suas classes. 
    A nomeclatura [ref] informa que a variável em questão vai ser utilizada como referência e caso seja substituida um novo
    valor não será criado, mas sim a referência irá receber um novo valor, dessa forma o conteúdo será substituído.
    A notação [out] permite criar um método que joga para fora variáveis que podem ser utilizadas fora do contexto do método
    dessa forma diminui muito métodos que precisam retornar um valor, pois basta colocar as variáveis no parâmetro utilizando
    a anotação out e depois quando o método for utilizado já sabe que pode utilizar essa variável em outro contexto. 
*/

// Trabalhando com structs, interfaces e enums
/*
    O que são Structs -> Armazena dados na sua estrutura, pode ter atributos e métodos. Mas seus dados contém apenas valores
    não contém referências. Não aceitam herança e são 
    utilizadas para coisas simples, pois seu conteúdo fica armazenado na stack. Utilizar Structs é bom para o gerenciamento
    de memório e performace, pois assim o carbage collector não terá muito trabalho para ficar limpando memória do heap de
    classes pequenas que poderiam ser Structs.

    Entendendo a função de interfaces e enums -> Interfaces são como contratos, que podem ter atributos e métodos, elas 
    são utilizadas quando é necessário que uma classe tenha diversas heranças, dessa forma ela terá diversas interfaces
    entrando mais afundo no conceito de polimorfismo. Quem tiver a interface implementada, obrigatoriamente ela precisa ser
    utilizada. Interface podem herdar outras interfaces, geralmente utilizadas para fazer agrupamentos de interfaces

    Enum -> É um tipo de valor que contém valores do tipo constantes. Os valores das enums nunca são modificadas, elas servem
    apenas para distribuir valores. ELas servem para pegar os valores discretos (valores mágicos) e dar um conceito 
    para deixar o seu código mais semântico. Dessa forma é possível utilizar esse conceito para referenciar o valor.
*/