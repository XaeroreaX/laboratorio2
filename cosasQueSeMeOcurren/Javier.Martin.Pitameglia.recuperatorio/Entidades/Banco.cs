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

            return string.Format("Banco:{0}---País:{1}", this._nombre, this._pais);


        }

        public override string Mostrar(Banco banco)
        {
            return banco.Mostrar();
        }
    }

    public class BancoProvincial : BancoNacional
    {
        public string _provincia;

        public BancoProvincial(BancoNacional bn, string provincia) : base(bn._nombre, bn._pais) { this._provincia = provincia; }

        public override string Mostrar()
        {
            return string.Format("{0}---Provincia:{1}", base.Mostrar(), this._provincia);
        }

    }


    public class BancoMunicipal : BancoProvincial
    {
        public string _municipio;

        public BancoMunicipal(BancoProvincial bp, string municipio) : base(new BancoNacional(bp._nombre, bp._pais), bp._provincia) { this._municipio = municipio; }

        public override string Mostrar()
        {
            return string.Format("{0}---Municipio:{1}",base.Mostrar(), this._municipio);
        }

    }
}
