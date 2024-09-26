using Microsoft.AspNetCore.Identity;

namespace UsuariosAPI.Models
{
    public class UsuarioModel : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public UsuarioModel() : base() { }
    }
}
