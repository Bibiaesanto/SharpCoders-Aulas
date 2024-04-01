# Tipando Funções (delegates)

um delegate permite que a gente armazene funções em variáveis convencionais.

## Predicate

- mais usado quando temos situações booleanas, como validar, verificar ou encontrar algo.

- pode ser lido como "tal que..."

- (T) -> bool

```cs
public class Program{

    static bool EhPar(int number){
        return number%2 == 0;
    }

    static void Main(){
        
        lista.Find(numero => == 5);

        var result = list.Where(numero => numero%2 == 0).ToList();

        bool result2 = usuarios.Any(usuario => usuario.Username == "pedrinho123");

        numeros.Where(Program.EhPar);

        usuarios.Where((usuario) => {
            // codigo aqui ...
            return true;
        });
    }
}
```

## Action

- (T) -> void

```cs
numeros.ForEach((numero) => COnsole.WriteLine(numero));

numeros.ForEach(Console.WriteLine);

numeros.ForEach((numero) => numero*2);
//(T) -> void
```

## Func

- Select "mapeia" os dados de um tipo para outro

- (T) -> (R)

```cs
numeros.Select((numero) => numero*2).ToList();

palavras.Select(palavra => palavra.Length).ToList();

usuarios.Select(usuario => new Profile(){
    Name = usuario.Name,
    Bio = usuario.Bio
}).ToList();
```
