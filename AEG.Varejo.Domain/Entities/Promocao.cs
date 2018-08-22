using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class Promocao
    {
        public enum eCriterio:int
        {
            ProdutoUnico = 0,
            ProdutoContem = 1,
            GrupoUnico = 2,
            GrupoContem = 3,
            QuantidadeMaiorQue = 4,
            QuantidadeMenorQue = 5
        };
        public enum ePremio:int
        {
            DescontoTotalDe,
            DescontoUnitarioDe,
            DescontoPercentualDe,
            ValorUnitarioMaior,
            ValorUnitarioMenor,
            DescontoTotalMaior,
            DescontoTotalMenor
        };
        public string Descricao { get; set; }
        public int PromocaoId { get; set; }
        public ePremio Premio { get; set; }
        public decimal Valor { get; set; }
        public List<PromocaoItem> Criterios { get; set; }

        public Promocao()
        {
            Criterios = new List<PromocaoItem>();
        }

        public static void ValidaPromocao(Pedido pedido, Promocao promocao)
        {
            List<PedidoItem> itens = pedido.Itens;



            foreach (var crit in promocao.Criterios)
            {
                switch (crit.Criterio)
                {
                    case eCriterio.ProdutoUnico:
                        itens = itens.Where(c => c.ProdutoId == Convert.ToInt32(crit.Valor)).ToList();
                        break;
                    case eCriterio.ProdutoContem:
                        break;
                    case eCriterio.GrupoUnico:
                        itens = itens.Where(c => c.GrupoId == Convert.ToInt32(crit.Valor)).ToList();
                        break;
                    case eCriterio.GrupoContem:
                        break;
                    case eCriterio.QuantidadeMaiorQue:
                        if (itens.Count <= Convert.ToInt32(crit.Valor))
                            itens.Clear();
                        break;
                    case eCriterio.QuantidadeMenorQue:
                        if (itens.Count > Convert.ToInt32(crit.Valor))
                            itens.Clear();
                        break;
                    default:
                        break;
                }

                if (crit.Criterio == eCriterio.GrupoUnico)
                    itens = itens.Where(c => c.GrupoId == Convert.ToInt32(crit.Valor)).ToList();
                else if (crit.Criterio == eCriterio.ProdutoUnico)
                    itens = itens.Where(c => c.ProdutoId == Convert.ToInt32(crit.Valor)).ToList();
                else if (crit.Criterio == eCriterio.QuantidadeMaiorQue && itens.Count <= Convert.ToInt32(crit.Valor))
                    itens.Clear();
                else if (crit.Criterio == eCriterio.QuantidadeMenorQue && itens.Count > Convert.ToInt32(crit.Valor))
                    itens.Clear();

            }

            if (itens.Count == 0)
                return;

            if (promocao.Premio == ePremio.DescontoUnitarioDe)
            {
                pedido.Desconto = itens.Count * promocao.Valor;
            }
        }

        public static Promocao Criar()
        {
            var promocao = new Promocao();
            promocao.PromocaoId = 1;
            promocao.Descricao = "Promoção Acima de 4 pague 1 real a menos";
            promocao.Premio = ePremio.DescontoUnitarioDe;
            promocao.Valor = 1;
            promocao.Criterios.Add(new PromocaoItem()
            {
                PromocaoId = promocao.PromocaoId,
                Criterio = eCriterio.GrupoUnico,
                Valor = 1
            });
            promocao.Criterios.Add(new PromocaoItem()
            {
                PromocaoId = promocao.PromocaoId,
                Criterio = eCriterio.QuantidadeMaiorQue,
                Valor = 3
            });
            promocao.Criterios.Add(new PromocaoItem()
            {
                PromocaoId = promocao.PromocaoId,
                Criterio = eCriterio.QuantidadeMenorQue,
                Valor = 9
            });

            return promocao;
        }
    }
}
