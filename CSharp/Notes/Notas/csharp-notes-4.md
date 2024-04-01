# POO 

## Motivação 

quero criar 1 pessoa: 

```cs
string nome;
int idade;
double altura;
```

quero criar 3 pessoas:

```cs
string nome1, nome2, nome3;
int idade1, idade2, idade3;
double altura1, altura2, altura3;
```

quero criar 1000 pessoas:

```cs
int quantidade = 1000;
string[] nomes = new string[1000];
int[] idades = new int[1000];
double[] alturas = new double[1000];
```

relembrando... como trocar duas variáveis? 

solução: criar variável auxiliar

```cs
int a = 2, b = 3;
int antigo_a = a;
a = b;
b = antigo_a;
```

solução exótica:

```cs 
int a = 2, b = 3;
(a, b) = (b, a);
```

relembrando... ordenação

- estrategia de troca
- estrategia de comparação

tentando trocar a primeira e a quinta pessoa:

```cs
int quantidade = 1000;
string[] nomes = new string[1000];
int[] idades = new int[1000];
double[] alturas = new double[1000];

string aux1 = nomes[0];
nomes[0] = nomes[4];
nomes[4] = aux1;

int aux2 = idades[0];
// ...
```

🔴 problemas

- baixa legibilidade
- dificil manutenção

## Classe

- O que faz uma classe?
malde, tipo de variável personalizado, classificação

- O que eh um objeto?
fruto do molde

molde(classe): Carro, exemplo(objeto): Ferrari
molde(classe): Ferrari, exemplo(objeto): Ferrari do Bruno
molde(classe): Pessoa, exemplo(objeto): joao

- o que compoe uma classe?
    - o que ela tem: atributos
    - o que ela faz: metodo

declarando...

```cs
public class Pessoa {
    //tem - atributos
    public string nome;
    public int idade;
    public double altura;

    // faz - metodos
    public void FazerAniversario(){
        idade++;
    }

    public double Somar(double a, double b){
        return a + b;
    }
}
```

Instancia sinonimo de exemplo.

usando ...

```cs
public class Program{

    public static void Main(){

        // short sintax
        // Pessoa joao = new();

        Pessoa joao = new Pessoa();
    }
}
```