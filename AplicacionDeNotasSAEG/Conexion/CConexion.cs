using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeNotasSAEG.Conexion
{
    public class CConexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://aplicaciondenotassaeg-default-rtdb.firebaseio.com/");
    }
}
