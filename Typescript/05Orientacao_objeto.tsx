// Classe
class Produto{
    // Atributo
    private nome:string;
    private valor:number;

    // Construtor
    public constructor(nome:string, valor:number){
        this.nome = nome;
        this.valor = valor;

        this.mensagem();
    }

    // Método para exibir uma mensagem
    private mensagem(){
        console.log(`O produto ${this.nome} custa R$ ${this.valor}`);
    }
}



// Instanciar objeto da classe Produto
const p = new Produto('Iphone 15', 7000);