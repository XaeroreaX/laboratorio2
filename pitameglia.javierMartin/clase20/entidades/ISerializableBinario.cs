﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace entidades
{
    public interface ISerializableBinario
    {

        void Serializar(string path);

        Jugador Deserializar(string path);


    }
}
