## Modificador `params`

jeito mais intuitivo:
 ```cs

 public double Somar(double[] vetor) {
    double soma = 0;

    foreach(double valor in vetor){
        soma += valor;
    }

    return soma;
 }

//  double[] numeros = {1, 2, 3};
// Somar(numeros);

Somar(new double[] {1, 2, 3});

 ```

 alternativa:

 ```cs

 public double Somar(double a, double b){
    return a + b;
 }

  public double Somar(double a, double b){
    return a + b + c;
 }
  public double Somar(double a, double b){
    return a + b + c + d;
 }

 Somar(1, 2, 3);

 ```

 ```cs

 public double Somar(params double[] vetor){
    double soma = 0;

    foreach(double valor in vetor){
        soma += valor;
    }

    return soma;
 }

 Soma(1, 2, 3);

 ```

 ## `foreach` - enhanced for

 ```cs

 string[] fruits = {'apple', 'banana', 'watermelon'}

 foreach(string fruit in fruits){
    Console.WriteLine(fruit);
 }

 ```

 possível problema (de vez em quando):

 problematicas:

 - value atua como uma cópia da informação
 - alterar value não altera o array

 ```cs

 int[] array = new int[1000];

 foreach(int value in array){
    va
    lue = -1;
 }
 ```

 # Listas

 coisas comuns:

 - Ambos são homogeneos (só guardam elementos do mesmo tipo)
 - São indexados em zero.

 ```

 [Guitarra, Guitarra, Bateria, Microfone, Guitarra]
 [Instrumento, Instrumento, Instrumento, Instrumento, Instrumento]

 ```

 vantagens: 

 - Lista não tem tamanho definido.
- Lista aloca sob demanda.
- Metodos utilitários.

```cs

List<int> meusInteiros = new List<int>();

``` 

## Principais métodos

adicionando:

```cs

meusInteiros.Add(1);
meusInteiros.Add(2);
meusInteiros.Add(3);
meusInteiros.Add(4);

meusInteiros.Insert(0, 999);

// foreach(int inteiro in meusInteiros){
//     Console.WriteLine(inteiro);
// }

```

contando elementos: 

```cs

Console.WriteLine($"tamanho da lista:" {meusInteiros.Count()});
```

find, findLast, findIndex, findLastIndex
....

## Design

- Model/Domain: Domínio do produto
- Service: regras do negócio/ "acessar" os dados
- View/ (Menu): isola as interações com o usuário