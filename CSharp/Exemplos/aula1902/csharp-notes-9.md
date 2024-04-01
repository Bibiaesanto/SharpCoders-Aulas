# Melhorando herança

## Generics

Objetivo: Criar um acumulador e disparador de mensagens, valores, objetos, etc.
Exemplo: Acumular(informação) -> essa informação deve ser guardada.
Descrição: Disparar() -> exibir todas as informações de uma única vez em tela. 

```cs
public class IntermediadorDeMensagens {

    public List<string> Mensagens = new() {get; private set;}

    public void Acumular(string mensagem) {
        Mensagens.Add(mensagem);

    }
    
    public void Disparar(){
        foreach(string mensagem in Mensagens) 
        Console.WriteLine(mensagem);
        Mensagens.RemoveAt(0);
        Console.WriteLine(mensagem);
        Mensagem.RemoveAt(cirrentPositionToRemove);
    }
}
```

problemas:

- se eu quisesse lidar com numeros, teria que recriar a classe para numeros.
- se eu quisesse lidar com pessoas, teria que recriar a classe para pessoas.

> codigo ruim: ruim de entender, extender e mudar

### relembrando

upcasting:

```cs
Pessoa pedro = new Aluno(); // pedro eh um aluno e todo aluno eh tambem uma pessoa
FormaGeometrica circulo = new Circulo(); //mesma ideia
FormaGeomatrica quadrado = new Aluno();
```

downcasting:

```cs
Pessoa p = new Aluno();

//deixando downcasting seguro
if (p is Aluno) {
    //Aluno a = (Aluno) p;
}
```

consequencias:

```cs
Object a = new Pessoa();
Object b = new Aluno();
Object c = new Quadrado();
```

# Melhorando herança
## Generics
### melhorando com Object

- não possuo seguranca dos tipos dos valores dentro do intermediador
- nao consigo garantir alguma chamada 