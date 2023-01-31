using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfLoginService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "LoginService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione LoginService.svc o LoginService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class LoginService : ILoginService
    {
        public bool Login(string username, string password)
        {
            bool success = false;
            if (username == "CarlosRuiz93" && password == "12345678") {
                success = true;
            }
            return success;
        }
    }
}
