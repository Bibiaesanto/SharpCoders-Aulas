# Introdução Backend

## Protocolo Http

## Principais verbos

- `GET`: pegar alguns recursos

exemplo: `Get www.api.imatech.com/alunos`

- `POST`: cadastrar/ enviar algum recurso

exemplo: ` POST www.api.imatech/alunos/cadastrar`

body:
```json
{
    "nome": "Joao da Silva",
    "turma": "SharpCoders 2"
}
``` 
- `PUT`: atualização total

`PUT www.api.imatech.com/alunos/atualizar/2`

```json 
{
    "nome": "Pedro da Silva",
    "turma": "SharpCoders 2"
}
```
- `DELETE`: delecao do recurso

`DELETE www.api.imatech.com/alunos/deletar/1`

### Http status code

## Arquitetura de Software

### MVC

Model: modelagem do dominio/ assunto.
View: constroi um código HTML/CSS/JS para ser enviado.
Controller: gerenciador de requisições

## Nomes

Rest API: abstracao de um servico, recebo pedidos, envio respostas e não crio vinculo com a maneira que estes dados serao utilizados.

Restful API: mesma coisa do Rest API seguindo boas praticas

Http Protocol: protocolo principal que usaremos nas mensagens enviadas

Endpoint: endpoint é o nome de cada recurso oferecido pelo nosso backend