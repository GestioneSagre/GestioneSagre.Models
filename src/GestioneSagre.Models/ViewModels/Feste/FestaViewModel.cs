using GestioneSagre.Infrastructure.Entities;
using GestioneSagre.Infrastructure.Enums;
using GestioneSagre.Models.ViewModels.Common;
using GestioneSagre.Models.ViewModels.Intestazioni;

namespace GestioneSagre.Models.ViewModels.Feste;

public class FestaViewModel : BaseViewModel
{
    public string DataInizio { get; set; }
    public string DataFine { get; set; }
    public string GuidFesta { get; set; }
    public FestaStato StatusFesta { get; set; }
    public List<IntestazioneViewModel> Intestazioni { get; set; } = new List<IntestazioneViewModel>();

    public static FestaViewModel FromEntity(FestaEntity festa)
    {
        return new FestaViewModel
        {
            Id = festa.Id,
            DataInizio = festa.DataInizio,
            DataFine = festa.DataFine,
            GuidFesta = festa.GuidFesta,
            StatusFesta = festa.StatusFesta,
            Intestazioni = festa.Intestazioni
                .OrderBy(intestazione => intestazione.Id)
                .ThenBy(intestazione => intestazione.Id)
                .Select(intestazione => IntestazioneViewModel.FromEntity(intestazione))
                .ToList()
        };
    }
}