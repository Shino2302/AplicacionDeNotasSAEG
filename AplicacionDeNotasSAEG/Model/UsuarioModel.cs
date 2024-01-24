using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeNotasSAEG.Model
{
    public class UsuarioModel
    {
        public Guid IdUsuario { get; set; }
        public string NombreDeUsuario{ get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string FotoUsuario { get; set; }
        public int PaletaDeColores { get; set; }

    }
}
