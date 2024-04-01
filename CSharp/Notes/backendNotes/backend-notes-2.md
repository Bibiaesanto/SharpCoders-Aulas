# Persistencia de dados em APIs
## ORM (Object Relacional Mapper)

O C# é regido pela Orientação a Objetos, enquanto que o banco é regido pela paradigma Relacional, a ORM az a ponte entre essas duas ferramentas. 

ORMs populares em C#:

- dapper
- entity framework (EF)

### Migration 

> Faz versionamento do seu banco de dados

Um código SQL ou similar que irá registrar as mudanças que devem ocorrer no banco e quais seriam as mudanças necessárias para reverter os impactos no banco. 

## Entity Framework

pacotes a serem instalados:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools

- **driver:** Microsoft.EntityFrameworkCore.Sqlite

### DbContext


- Facilita configuração do banco na aplicação 
- Permite indicar tabelas e especificações a serem impactadas somente no banco

### DbSet

- Simboliza as tabelas no banco de dados

```cs
public class AppDbContext : DbContext {

    public DbSet<User> Users {get; set;}

    public AppDbContext(DbContextOptions<AppDbContext> options) 
    : base(options){
    }
}
```