// Orientação a objetos usando C# em .NET

// Introdução a orientação a objetos - Os paradigmas da programação.
/*
    Paradigmas da programação são modos de estruturar um código que resolve um problema, esse problema pode ser resolvido
    de diversas formas e os paradigmas entram nesse contexto para tentar aplicar um padrão de boas práticas
    visando performance, manutenção e escalabilidade.
    Cada paradigma tem os seus fortes e suas fraquezas, portanto é necessário planejar bem para decidir qual o melhor
    paradigma para determinada situação, em alguns casos o POO não será tão perfomático do que colocar a programação
    estruturada.

    Na programação estruturada basicamente o código vai seguindo de linha a linha e sempre seguindo o fluxo das condições
    e dos loopings. 

    Na programação a objetos basicamente o código é estruturado em classes, essas classes podem ter atributos e métodos,
    em que uma classe pode criar vários objetos com atributos diferentes. Isso é uma forma de organizar melhor o seu código
    ao ponto de que se precisar adicionar uma nova função a todos os seus objetos da mesma classe, basta modificar a classe.
    Para que uma linguagem seja considerada de orientação a objetos ela precisa ter 4 funções internas bem definidas:
    
    1 - Abstração: Ato de criar uma generalização de objetos, onde todo carro tem uma cor, mas cada carro tem uma cor 
    diferente.
    2 - Encapsulamento: Ato de criar segurança de atributos ou métodos de uma classe, gerando permissões de acordo com o
    desejo do desenvolvedor
    3 - Herança: Ato de fazer uma classe herdar outros atributos de outra classe, assim uma classe herda alguns atributos
    e métodos de outra classe pai.
    4 - Polimorfismo: Ato de fazer uma classe herdar várias classes ou várias interfaces, assim é possível organizar bem
    o código para desenvolver um interface nova e apenas atribuir essa interface ao objeto que é necessário, sem precisar
    excluir algo do código, apenas adicionar alguma coisa nova.
*/

// O que são classes, objetos e visibilidades
/*
    Classes -> É como se fosse um molde para um objeto, basicamente você define o que um objeto pode ter no geral na classe
    instância essa classe e cria-se um objeto com esses dados que foi definido, claro que cada objeto pode ter um dado 
    diferente, mas sua estrutura é semelhante.

    Objetos -> O que é gerado quando se instância a classe, fazendo isso com a palavra reservada [new]. Assim cira-se um
    objeto com os atributos e métodos definidos numa classe, dessa forma é possível criar novos objetos com aspectos 
    diferentes sem precisar ter que ficar digitando o mesmo código toda hora.

    Visibilidade -> Importante para a proteção do código, as privadas só podem ser acessadas e modificadas
    internamente na classe, as públicas podem ser acessadas por objetos e classes que herdam, protegidas podem ser acessadas
    somente pela herança e a classe interna.
*/

// Entenda os diferentes tipos por valor, referência e ponteiros:
/*
    Valor -> Todos os tipos de dados são númericos, não é necessário iniciar com [new], a variável armazena o valor 
    diretamente. Se for atribuido uma variável por outra variável cria-se uma cópia da variável e cria-se uma nova variável.
    Portanto, deve-se atentar ao manipular as variáveis de valores pois podem gerar um erro de Stack Over Flow. Não podem
    ter o valor null. Integers, double, floats e chars. São valores numéricos pois necessitam tem um valor bem definido.

    Referência -> Se referencia a variável, portanto se a variável for modificada o valor que estava nessa variável é
    perdida e substituida pelo novo valor. Matrizes, Strings, Classes, Arrays.

    Ponteiro -> Aponta no local da memória outro um valor que está ocupando este local e atribui o mesmo local a uma nova
    variável criando a partir de então uma variável por refereência.
*/

// O que são métodos
/*
    Determinam o comportamente do objeto, são ações que determinado objeto irá ter ao se instanciar uma classe.
    Os métodos são definidos nas classes. São basicamente funções dentro de classes.
    Métodos acessores -> São os getters e os setters, basicamente os get eles retornam o valor de algum atributo 
    Métodos modificadores -> É os set substitui o valor do atribuito.
    Métodos construtures -> São os constructs que basicamente toda vez que for instanciada uma classe é necessário passar
    alguns argumentos, pois os construtores só conseguem criar um objeto se forem passados os atributos diretamente.
*/

// O que são propriedades e eventos
/*
    Propriedades -> Valores dentro de classes que recebem valores e podem ser chamadas ou modificadas.

    Eventos -> É quando algo dispara quando uma situação ocorre, isso é chamado de evento, por exemplo quando um botão
    é clicado ocorre o evento de emitir uma mensagem, soar um bipe, escrever algo na tela ou desligar o computador. Tudo
    isso são eventos.
*/