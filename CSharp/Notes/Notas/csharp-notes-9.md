# Melhorando herança

## Generics 

- Objetivo: Criar um acumulador e disparador de mensagens, valores, objetos, etc.
- descrição: Acumular (Informação) -> essa informação deve ser guardada.
- Descrição: Disparar() -> exibir todas as informações de uma única vez em tela.

```cs
public class IntermediadorDeMensagens {
    public List<string> Mensagens = new() {get; private set;}

    public void Acumular(string mensagem){
        Mensagens.Add(mensagem);
    }

    public void Disparar(){
        foreach(string mensagem in Mensagens){
            int currentPositionToRemove = 0;
            Console.WriteLine(mensagem);
            Mensagens.RemoveAt(currentPositionToRemove);
        }
    }
}
```

problemas:

- se eu quisesse lidar com numeros, teria que recriar a classe para numeros. 
- se eu quisesse lidar com pessoas, teria que recriar a classe para pessoas.

> codigo ruim de entender, extender e mudar

### relembrando

upcasting:

```cs
Pessoa pedro = new Aluno(); // pedro eh um aluno e todo aluno eh tambem uma pessoa
FormaGeometrica circulo = new Circulo(); // mesma ideia
```

downcasting:

```cs
Pessoa pessoa = new Aluno();

// deixando downcasting seguro
if(pessoa is Aluno aluno){
    // Aluno a = (Aluno) p;
    aluno.Nota = 10.0
}
```

consequencia:

```cs
public class IntermediadorDeMensagens {

    public List<object> Mensagens = new() {get; private set;}

    public void Acumular(Object mensagem){
        Mensagens.Add(mensagem);
    }

    public void Disparar(){
        foreach(Object mensagem in Mensagens){
            int currentPositionToRemove = 0;
            Console.WriteLine(mensagem);
            Mensagens.RemoveAt(currentPositionToRemove);
        }
    }
}
```

problemas: 

- não possuo segurança dos tipos dos valores dentro do intermediador
- não consigo garantir alguma chamada de metodo ou execução específica utilizando object

## Classes e ... abstratas

Classes abstratas são classes feitas para serem extendidas e continuadas. Elas não são capazes de produzir um objeto. 