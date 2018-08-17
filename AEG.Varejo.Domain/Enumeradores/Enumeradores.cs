using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Enumeradores
{
    public enum eSituacaoDespesa
    {
        CANCELADA = 0,
        PAGO= 1,
        NAOPAGO=2,
        INCONSISTENTE=3
    };
}
