using AplicacionDeNotasSAEG.Conexion;
using AplicacionDeNotasSAEG.Model;
using Firebase.Database.Query;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDeNotasSAEG.Datos
{
    public class DUsuario
    {
        public async Task RegistrarUsuario(UsuarioModel nuevoUsuario)
        {
            await CConexion.firebase.Child("Usuario")
            .PostAsync(new UsuarioModel()
            {
                IdUsuario = Guid.NewGuid(),
                NombreDeUsuario = nuevoUsuario.NombreDeUsuario,
                Correo = nuevoUsuario.Correo,
                Password = nuevoUsuario.Password,
                FotoUsuario = nuevoUsuario.FotoUsuario
            });
        }
        public async Task<bool> VerificacionUsuario(string nombreDeUsuario, string password)
        {
            Query consultaUsuario;
            return true;
        }
        public async Task IngresoDeSesion(string nombreDeUsuario, string password)
        {

        }
    }
}
