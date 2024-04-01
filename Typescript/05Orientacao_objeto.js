// Classe
var Produto = /** @class */ (function () {
    // Construtor
    function Produto(nome, valor) {
        this.nome = nome;
        this.valor = valor;
        this.mensagem();
    }
    // Método para exibir uma mensagem
    Produto.prototype.mensagem = function () {
        console.log("O produto ".concat(this.nome, " custa R$ ").concat(this.valor));
    };
    return Produto;
}());
// Instanciar objeto da classe Produto
var p = new Produto('Iphone 15', 7000);
