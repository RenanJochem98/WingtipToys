﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;

namespace WingtipToys.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public System.DateTime OrderDate { get; set; }

        public string Username { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Endereço é obrigatório")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Código Postal é obrigatório")]
        [DisplayName("Código POstal")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "País é obrigatório")]
        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Endereço de email é obrigatório")]
        [DisplayName("Endereço de email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string PaymentTransactionId { get; set; }

        [ScaffoldColumn(false)]
        public bool HasBeenShipped { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}