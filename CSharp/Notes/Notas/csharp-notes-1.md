# Introdução ao C

## Variáveis

- Inteiros: int, long (short)
- Reais (Com virgula): double, float
- Textos: string, char
- Booleanas (true ou false): bool

## Saidas

 1. Concatenação

 ```cs
 int x = 10;

 Console.WriteLine("Ola, mundo");
 Console.WriteLine("Variavel x = " + x);
 ```
 2. Interpolação

 ```cs
 int a = 10;
 string nome = "Bianca";
 string sobrenome = "Espirito Santo"
 
 Console.WriteLine($"valor da variavel a = {a}");
 Console.WriteLine($"nome: {nome}{sobrenome}");

 int statusCode = 201;
 string message = "created";

 string response = $"ResponseMessage: {message}, status: {statusCode}";

 Console.WriteLine(response);
 ```
 ```
 valor da variavel a = 10
 nome: Bianca Espirito Santo
 ```

 ## Repetição
 - Inicialização
 - Verificação (final)
 - Atualização (incremento/ decremento)

`while` : enquanto
`for` : para

> para um numero iniciando em zero e indo até cinco de um em um

```cs
int contador = 1; // Inicialização

while(contador <= 5){ //Verificação
    Console.WriteLine(contador);
    contador++; // Atualização
}
```

```cs
for(/*Inicialização*/;/*Verificação*/;/*Atualização*/){

}
```
```cs
for(int contador = 1; contador <= 5; contador++>){
    Console.WriteLine(contador);
}
```

- Iterativo
- Repetição

## Vetores/ Array

sinonimos: Array, conjunto, sequencia

- bloco contiguo memoria
- indexado(inicia) em zero


🔴 Cuidados!

- Array possui tamanho definido
- É homogeneo (tem somente um tipo)

🔵 Criando um array/vetor

```cs
int idade = 22;

//criando ja com os valores
string[] frutas = {"banana", "pera", "uva", "maca"};

// criando em branco e com um tamanho
string[] animais = new string[10];
//criei um vetor com 10 espaços string

int[] numeros = new int[10]; // 4 bytes
``` 

🟢 Manipulando

```cs
string[] animais = new string[10];

animais[0] = "Girafa";
animais[1] = "Rinoceronte";
animais[2] = "Cachorro";
animais[3] = "Gato";

double[] depositos = new double[20] {30.0, 20.0};

Console.WriteLine(animais[0]);
```