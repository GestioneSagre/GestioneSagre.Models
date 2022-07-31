using GestioneSagre.Infrastructure.Entities;
using GestioneSagre.Models.ViewModels.Common;

namespace GestioneSagre.Models.ViewModels.Impostazioni;
public class ImpostazioniDetailViewModel : BaseViewModel
{
    public string GuidFesta { get; set; }
    public bool GestioneCoperti { get; set; }
    public bool GestioneMenu { get; set; }
    public bool StampaCarta { get; set; }
    public bool StampaLogo { get; set; }
    public bool StampaRicevuta { get; set; }

    public static ImpostazioniDetailViewModel FromEntity(ImpostazioniEntity impostazioni)
    {
        return new ImpostazioniDetailViewModel
        {
            Id = impostazioni.Id,
            GestioneCoperti = impostazioni.GestioneCoperti,
            GestioneMenu = impostazioni.GestioneMenu,
            StampaCarta = impostazioni.StampaCarta,
            StampaLogo = impostazioni.StampaLogo,
            StampaRicevuta = impostazioni.StampaRicevuta,
            GuidFesta = impostazioni.GuidFesta
        };
    }
}
