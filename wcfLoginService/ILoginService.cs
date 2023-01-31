﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfLoginService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ILoginService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        bool Login(string username, string password);

    }
}
