using GestioneSagre.Infrastructure.Entities;
using GestioneSagre.Models.ViewModels.Common;

namespace GestioneSagre.Models.ViewModels.Categorie;
public class CategoriaDetailViewModel : BaseViewModel
{
    public string CategoriaVideo { get; set; }
    public string CategoriaStampa { get; set; }
    public string GuidFesta { get; set; }

    public static CategoriaViewModel FromEntity(CategoriaEntity categoria)
    {
        return new CategoriaViewModel
        {
            Id = categoria.Id,
            CategoriaVideo = categoria.CategoriaVideo,
            CategoriaStampa = categoria.CategoriaStampa,
            GuidFesta = categoria.GuidFesta,
        };
    }
}
