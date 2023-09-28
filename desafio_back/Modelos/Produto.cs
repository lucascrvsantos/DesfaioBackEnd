using System.ComponentModel.DataAnnotations;

namespace desafio_back.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Valor { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public int SaldoEmEstoque { get; set; }
        public string Fornecedor { get; set; }
        public bool PossuiGarantia { get; set; }
    }
}
