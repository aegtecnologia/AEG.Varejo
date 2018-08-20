using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEG.Varejo.Domain.Entities;
using FluentValidation;

namespace AEG.Varejo.Domain.Validations
{
    public class DespesaValidator:AbstractValidator<Despesa>
    {
        public DespesaValidator()
        {
            RuleFor(c => c.ValorLiquido)
                .NotEmpty()
                .WithMessage("Valor precisa ser maior que zero");

            //RuleFor(c => c)
            //    .Must(ValidaCC)
            //    .WithMessage("Informe o centro de custo");

            RuleFor(c => c.CentroCustoLista)
                .NotEmpty()
                .WithMessage("Informe o centro de custo");

            RuleFor(c => c.Descricao)
                .NotEmpty()
                .WithMessage("Informe a descrição da conta");

        }

        public bool ValidaCC(Despesa despesa)
        {
            if (despesa.CentroCustoLista==null || !despesa.CentroCustoLista.Any())
                return false;

            decimal totalCC=0;

            foreach (var cc in despesa.CentroCustoLista)
            {
                totalCC += cc.Valor;
            }

            return totalCC == despesa.ValorLiquido;
        }

    }
}
