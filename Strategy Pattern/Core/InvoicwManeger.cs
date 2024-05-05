using Strategy_Pattern.Core.DiscountStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core
{
    internal class InvoicwManeger
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;

        public void SetDiscountStrategy (ICustomerDiscountStrategy strategy)
        {
            _customerDiscountStrategy = strategy;
        }

        public invoice CreateInvoice (Customer customer, double quantity , double unitPrice)
        {
            var Invoice = new invoice
            {
                Customer = customer,
                Lines = new[]
               {
                    new invoiceline { Quantity = quantity, UnitPrice = unitPrice }
                }
            };
            Invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDiscount(Invoice.Totalprice);
            return Invoice;
        }
    }
    }
    

