using GestioneSagre.Infrastructure.Entities;
using GestioneSagre.Infrastructure.ValueObjects;
using GestioneSagre.Models.ViewModels.Common;

namespace GestioneSagre.Models.ViewModels.Prodotti;
public class ProdottoViewModel : BaseViewModel
{
    public int CategoriaId { get; set; }
    public string Prodotto { get; set; }
    public bool ProdottoAttivo { get; set; }
    public Money Prezzo { get; set; }
    public int Quantita { get; set; }
    public bool QuantitaAttiva { get; set; }
    public int QuantitaScorta { get; set; }
    public bool AvvisoScorta { get; set; }
    public bool Prenotazione { get; set; }
    public string GuidFesta { get; set; }

    public static ProdottoViewModel FromEntity(ProdottoEntity prodotto)
    {
        return new ProdottoViewModel
        {
            Id = prodotto.Id,
            CategoriaId = prodotto.CategoriaId,
            Prodotto = prodotto.Prodotto,
            ProdottoAttivo = prodotto.ProdottoAttivo,
            Prezzo = prodotto.Prezzo,
            Quantita = prodotto.Quantita,
            QuantitaAttiva = prodotto.QuantitaAttiva,
            QuantitaScorta = prodotto.QuantitaScorta,
            AvvisoScorta = prodotto.AvvisoScorta,
            Prenotazione = prodotto.Prenotazione,
            GuidFesta = prodotto.GuidFesta
        };
    }
}
