using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace tutorial.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class NivelInstruccion : BaseObject
    {
        public NivelInstruccion(Session session) : base(session) { }


        string nombre;
        string codigo;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Codigo
        {
            get => codigo;
            set => SetPropertyValue(nameof(Codigo), ref codigo, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nombre
        {
            get => nombre;
            set => SetPropertyValue(nameof(Nombre), ref nombre, value);
        }


    }
}
