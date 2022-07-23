﻿using GestioneSagre.Infrastructure.Entities;
using GestioneSagre.Infrastructure.Enums;
using GestioneSagre.Models.ViewModels.Common;

namespace GestioneSagre.Models.ViewModels.Versioni;

public class VersioneDetailViewModel : BaseViewModel
{
    public string CodiceVersione { get; set; } = string.Empty;
    public string TestoVersione { get; set; } = string.Empty;
    public VersioneStato VersioneStato { get; set; }

    public static VersioneDetailViewModel FromEntity(VersioneEntity versione)
    {
        return new VersioneDetailViewModel
        {
            Id = versione.Id,
            CodiceVersione = versione.CodiceVersione,
            TestoVersione = versione.TestoVersione,
            VersioneStato = versione.VersioneStato
        };
    }
}
