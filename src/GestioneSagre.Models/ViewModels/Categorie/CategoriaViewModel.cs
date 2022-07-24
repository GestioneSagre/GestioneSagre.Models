using GestioneSagre.Infrastructure.Entities;
using GestioneSagre.Models.ViewModels.Common;
using GestioneSagre.Models.ViewModels.Prodotti;

namespace GestioneSagre.Models.ViewModels.Categorie;
public class CategoriaViewModel : BaseViewModel
{
    public string CategoriaVideo { get; set; }
    public string CategoriaStampa { get; set; }
    public string GuidFesta { get; set; }
    public List<ProdottoViewModel> Prodotti { get; set; } = new List<ProdottoViewModel>();

    public static CategoriaViewModel FromEntity(CategoriaEntity categoria)
    {
        return new CategoriaViewModel
        {
            Id = categoria.Id,
            CategoriaVideo = categoria.CategoriaVideo,
            CategoriaStampa = categoria.CategoriaStampa,
            GuidFesta = categoria.GuidFesta,
            Prodotti = categoria.Prodotti
                .OrderBy(prodotto => prodotto.Id)
                .ThenBy(prodotto => prodotto.Id)
                .Select(prodotto => ProdottoViewModel.FromEntity(prodotto))
                .ToList()
        };
    }
}
