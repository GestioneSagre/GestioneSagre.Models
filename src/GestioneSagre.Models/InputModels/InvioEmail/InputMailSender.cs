using System.ComponentModel.DataAnnotations;

namespace GestioneSagre.Models.InputModels.InvioEmail;

public class InputMailSender
{
    [Required]
    public string MittenteNominativo { get; set; }

    [Required]
    public string MittenteEmail { get; set; }

    [Required]
    public string DestinatarioNominativo { get; set; }

    [Required]
    public string DestinatarioEmail { get; set; }

    [Required]
    public string Oggetto { get; set; }

    [Required]
    public string Messaggio { get; set; }
}