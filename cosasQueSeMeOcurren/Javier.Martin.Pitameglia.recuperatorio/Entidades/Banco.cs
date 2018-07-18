using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Banco
    {
        public string _nombre;



        public Banco(string nombre) { this._nombre = nombre; }

        public abstract string Mostrar();

        public abstract string Mostrar(Banco banco);

    }

    public class BancoNacional : Banco
    {
        public string _pais;

        public BancoNacional(string nombre, string pais) : base(nombre) { this._pais = pais; }

        public override string Mostrar()
        {
            throw new NotImplementedException();
        }

        public override string Mostrar(Banco banco)
        {
            throw new NotImplementedException();
        }
    }

    public class BancoProvincial : BancoNacional
    {
        public string _provincia;

        public BancoProvincial(BancoNacional bn, string provincia) : base(bn._nombre, bn._pais) { this._provincia = provincia; }

    }


    public class BancoMunicipal : BancoProvincial
    {
        public string _municipio;

        public BancoMunicipal(BancoProvincial bp, string municipio) : base(new BancoNacional(bp._nombre, bp._pais), bp._provincia) { this._municipio = municipio; }


    }
}
