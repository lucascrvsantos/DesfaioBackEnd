using System.ComponentModel.DataAnnotations;

namespace desafio_back.Data.Dtos
{
    public class AtualizarProdutoDto
    {
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Range(0, 100000)]
        public int EstoqueMinimo { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Range(0, 100000)]
        public int EstoqueMaximo { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Range(0, int.MaxValue)]
        public int SaldoEmEstoque { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(150)]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public bool PossuiGarantia { get; set; }
    }

}
