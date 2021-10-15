using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Commands.Inputs
{
    public class GeradorCartaoVirtualCommand : Notifiable
    {
        public string Email { get; set; }

        public void Validar()
        {
            AddNotifications(new Contract().IsEmail(Email, "Email", "Email Inválido."));
        }
    }

}
