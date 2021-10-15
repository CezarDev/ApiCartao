using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class CartaoVirtual
    {
        public CartaoVirtual(string email, string numeroCartao, DateTime datacriacao)
        {
            Email = email;
            NumeroCartao = numeroCartao;
            DataCriacao = datacriacao;

        }

        [Key]
        public int Id { get; private set; }

        public string Email { get; private set; }

        [MaxLength(16, ErrorMessage = "Este campo pode ter até 16 números")]
        public string NumeroCartao { get; private set; }

        public DateTime DataCriacao { get; private set; }

    }
}