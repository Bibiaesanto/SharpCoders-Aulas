## struct

```cs

public struct Pessoa{
   public string Nome;
    public int Idade;
   public double Altura;
   public string NumeroDeTelefone;
}

public class Program{
    public static void Main(){
        Pessoa p;

        p.Nome = "Bianca";
        p.Idade = 27;
    }
}
```

## Composição

- usernamesOfUsers
- emailsOfUsers
- passwordsOfUsers

```Js
const user = {
    email: "email@gmail.com",
    password: "senha123",
    address: {
        street: "Rua x",
        city: "Cidade y",
        number: "123",
        country: "Brasil"
    },
    posts: [
        {
            content: "Treta renato cariani",
            likes: 400
        },
        {
            content: "BBB 2024",
            likes: 200
        }
    ]
    }

    user.posts.push({

    })
```

```ts
export interface Address{
    street: string
    city: string
    number: string
    country: string
}

{
    export interface Post{
        content: string;
        likes: number
    }
}

export interface User{
    email: string
    password: string
    level: 'basic' | 'blue' | 'gold' | 'emerald'
    address: Address
    posts[]
}

const myUser= {
    level: 
}
```
## Relacionamentos

### 1. Relacionamento tem-um

```cs

public class Arco{
    public double Forca {get; set;}
    public int NumeroDeFlechas {get; set;}
    public double Forca {get; set;}
    
}
public class Arqueiro{
    public double Forca{get; set;}
    public Arco ArcoPrincipal {get; set;}
    public Arco ArcoSecundario {get; set;}
}
```
### 2. tem varios

```cs
public class Flecha(){
    public string Dano {get; set;}
    public string Efeito {get; set;}
}
public class Arco{
    public string Nome {get; set;}
    public double Forca {get; set;}
    public List<Flecha> Flechas {get; set;}
    
}
public class Arqueiro{
    public double Forca{get; set;}
    public Arco ArcoPrincipal {get; set;}
    public Arco ArcoSecundario {get; set;}
}
```

### 2. Consequencias

- um para um = tem-um + tem-um
- um para muitos ou muitos para um = tem-um + tem-varios
- muitos para muitos = tem-varios + tem-varios
```

## Diagramas

### 1. Diagrama UML

Diagrama UML é usado normalmente para descrever relacionamentos (composições e heranças) em Orientação a Objetos

Normalmente:

- A classe vai no topo de cada caixa
- Os atributos vão no meio 
- Os metodos vão no fim
- Não colocamos construtores, ToString e metodos pre-prontos
- Se tiver em itálico, é classe abstrata
- 0..1 = indica que pode ter nenhum ou um 
- 0..* = indica que pode ter nenhum ou muitos
- 1..+ = indica que pode ter 1 ou muitos


### 2. Diagrama ER - Entidade Relacional

Este diagrama é focado em descrever as tabelas do banci de dados e os relacionamentos entre elas (chaves estrangeiras e tabelas de normalização)

### 3. Diagrama de Use-Case

Este diagrama foca na parte operacional da solução, isto é, descrever o inicio de um uso até o seu fim, incluindo todas as possibilidades do usuário durante este caminho 

Caso de uso:

> O usuário faz login e o sistema valida. depois o usuário acessa

Variante: 

> Um usuário não cadastrado vai ao login, cria uma conta, o sistema registra, envia email, ele valida o email, a conta é ativada