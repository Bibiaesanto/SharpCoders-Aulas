# Introdução ao C#

## Variáveis

- Inteiros: `int`, `long`, (`short`)

- Reais(com virgula): `double`, `float`

- Textos: `String`, `char`

- Booleanas(true ou false): `bool`

## Saídas

1. Concatenação
```CS
int x = 10;

Console.WriteLine("Ola, Mundo");
Console.WriteLine("Variavel x =" + x);
```

2. Interpolaçao
```CS


```

## Repetição

- Inicialização
- Verificação (Final)
- Atualização

`While` : enquanto
`For` : para 
> para um numero iniciando em zero e indo ate cinco de um em um

```Cs
int contador = 1; //Inicialização

while(contador <= 5>{ // verificação
    Console.writeLine(contador);
    contador++; // Atualização
})
```

```CS
for(/*Inicialização*/;/*Verificação*/;/*Atualização*/){

}
```

```Cs
for(int contador = 1; contador <= 5; contador++){
    Console.WriteLine(contador);
}
```

- Interativo
- Repetição

## Vetores

sinonimos: Array, conjunto, sequencia

- Cuidados!
- Array possui tamanho definido
- É homogeneo(tem somente um tipo)

- Criando um array/vetor

```cs
int a = 22;
string[] frutas = {"banana", "pera", "uva", "maca"};
//id nota peso
```



