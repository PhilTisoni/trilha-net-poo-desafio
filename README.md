# DIO - Desafio Orientação a Objetos

<img style = "width: 200px" src = "https://hermes.dio.me/tracks/169e3d0f-263a-4efb-86c5-244bdf1ce8d6.png" alt = "Formação .Net Developer"> <img style = "width: 200px" src = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdjqTkPkxvNF5yqLhPRNhYXnwXuW422OWMGMyn2KkNTjRyuqZriAq26YEAK35FIOgKAwY&usqp=CAU" alt = "DIO"> 


# Sobre o Projeto

Desenolvido em Agosto de 2023 durante a **Formação .Net Developer** oeferecido pela **Digital Innovation One (DIO)**, o projeto apresenta uma aplicação console demonstrando conceitos de orientação a objetos através de exemplos de celulares.

<details><summary>Desafio</summary>

# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

</details>

<details><summary>Solução</summary>

# Classe Smartphone

Foram adicionadas as propriedas privadas, seguindo o modelo proposto pelo desafio, e adicionados os parâmetros do 
construtor.


## Classe Nokia:

Após realizada a herança da classe Smartphone, sobrescreveu-se o método **InstalarAplicativo():**

```c#
       public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo: {nomeApp} no Nokia");
        }   
```

## Classe Iphone:

O mesmo procedimento foi aplicado para a classe Iphone. Para a utilização das propriedades da classe-mãe,
foi utilizado o **base** no construtor:

```c#
         public Iphone(string numero, string modelo, string imei, int memoria) 
         : base(numero, modelo, imei, memoria)
        {
            
        }
```
 
## Classe Program:

Para a realização dos testes do códigos, foram instanciadas as classes, deixando explícita as 
propriedades utilizadas para facilitar a leitura do código. Foram utilizados os métodos da 
classe-mãe e os métodos sobrescritos:

```c#
  Nokia nokia = new (numero: "99999-9999", modelo: "1234", imei: "11111111", memoria: 32);
  Console.WriteLine("Teste Nókia: ");
  nokia.Ligar();
  nokia.InstalarAplicativo("WhatsApp");
```

</details>

# Tecnologias Utilizadas

- [.Net 7.0.302](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) 
- [Visual Studio Code](https://code.visualstudio.com/download)

# Como Clonar o Projeto

- Instale o [Git](https://git-scm.com/downloads) no seu computador. Durante a instalação, certifique-se se a opção **Git Bash** está adicionada.
- Após a instalação, crie uma pasta em sua área de trabalho
- Dentro da pasta, clique com o botão direito e selecione **Git Bash Here**
- Após abrir o terminal, copie o seguinte comando:
   
```bash
git clone https://github.com/PhilTisoni/trilha-net-poo-desafio.git
```
O projeto deverá ser clonado para a sua pasta. Abra a solução em seu compilador de preferência.


# Autor

- [Phelipe Augusto Tisoni](https://www.linkedin.com/in/phelipetisoni "Phelipe Linkedin")




