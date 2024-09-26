using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<UsuarioModel> _userManager;

        public async Task CadastraUsuario(UsuarioDto usuarioDto)
        {
            UsuarioModel usuario = _mapper.Map<UsuarioModel>
            (usuarioDto);

            IdentityResult resultado = await _userManager.CreateAsync(usuario, usuarioDto.Password);

            if (!resultado.Succeeded)
                throw new ApplicationException("Falha ao cadastrar usuário!");
        }
    }
}
