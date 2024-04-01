using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Extrato.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Transacao> Get()
        {
            // Aqui você pode implementar a lógica para obter as transações do banco de dados
            // ou de onde quer que você esteja armazenando os dados.
            var transacoes = new List<Transacao>
            {
                new Transacao { DataRealizacao = DateTime.Now, Descricao = "Depósito em dinheiro", ValorTransacao = 500.00, TipoTransacao = TipoTransacao.Deposito },
                new Transacao { DataRealizacao = DateTime.Now, Descricao = "Compra no mercado", ValorTransacao = -50.00, TipoTransacao = TipoTransacao.Saque },
                // Adicione mais transações conforme necessário
            };

            return transacoes;
        }
    }

    public class Transacao
    {
        public DateTime DataRealizacao { get; set; }
        public string Descricao { get; set; }
        public TipoTransacao TipoTransacao { get; set; }
        public double ValorTransacao { get; set; }
        // Adicione mais propriedades conforme necessário
    }

    public enum TipoTransacao
    {
        Deposito,
        Saque,
        Transferencia
    }
}
