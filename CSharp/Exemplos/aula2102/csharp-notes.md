# Temas "extras"

## Manipulando arquivos 

lendo linhas de um arquivo:

caminho relativo: `./teste`
caminho absoluto: `c:/dev/test`

```cs
string basepath = @"/arquivos"
string filepath = @$"{basepath}/teste.txt";

if (Files.Exists(filepath)){ // checa se o arquivo existe

    File.ReadAllLines(filepath);
    foreach(string Line in Lines){
        Console.WriteLine(Line);
    }
}
```