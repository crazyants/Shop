﻿using System;
using Gadz.Shop.Billing.DomainModel.Clientes;
using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing.DomainModel.Compras {
    public interface ICompra : IEntity {
        DateTime DataPagamento { get; set; }
        DateTime DataVencimento { get; set; }
        string Descricao { get; set; }
        Identity FornecedorId { get; set; }
        Identity FuncionarioId { get; set; }
        decimal Valor { get; set; }
        ICliente Cliente { get; set; }
        string DataRecebimento { get; set; }
    }
}