using System.ComponentModel.DataAnnotations;
using MailKit.Security;

namespace GestioneSagre.Models.InputModels.InvioEmail;

public partial class InputMailSupportoSender
{
    [Required]
    public string MittenteNominativo { get; set; }

    [Required]
    public string MittenteEmail { get; set; }

    [Required]
    public string Messaggio { get; set; }
}

public partial class InputMailOptionSender
{
    public string DestinatarioNominativo { get; set; }
    public string DestinatarioEmail { get; set; }
    public string Oggetto { get; set; }
    public string Host { get; set; }
    public int Port { get; set; }
    public SecureSocketOptions Security { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}