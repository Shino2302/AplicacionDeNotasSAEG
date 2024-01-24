using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AplicacionDeNotasSAEG.Datos;

namespace AplicacionDeNotasSAEG.ViewModel
{
    public class VMLogin : BaseViewModel
    {
        #region VARIABLES
        private string _nombreDeUsuario;
        private string _password;
        #endregion

        #region COSNTRUCTOR
        public VMLogin(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string NombreDeUsuario
        {
            get { return _nombreDeUsuario; }
            set { SetValue(ref _nombreDeUsuario, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetValue(ref _password, value); }
        }
        #endregion

        #region PROCESOS
        public async Task InicioDeSesion()
        {
            DUsuario login = new DUsuario();
            if(_nombreDeUsuario != string.Empty && _password != string.Empty)
            {
                bool verificado = Convert.ToBoolean(login.VerificacionUsuario(NombreDeUsuario, Password));
                if (verificado)
                {

                }
                else
                {

                }
            }

        }
        #endregion

        #region COMANDOS

        #endregion
    }
}
