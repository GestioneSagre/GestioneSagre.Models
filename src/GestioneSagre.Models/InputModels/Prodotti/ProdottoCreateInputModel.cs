﻿using GestioneSagre.Infrastructure.ValueObjects;

namespace GestioneSagre.Models.InputModels.Prodotti;

public class ProdottoCreateInputModel
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
}
