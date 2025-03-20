using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace tutorial.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(Numero))]
    public class Telefono : BaseObject
    {
        public Telefono(Session session) : base(session) { }


        string codigoArea;
        string numero;
        Persona persona;

        [Association]
        public Persona Persona
        {
            get => persona;
            set => SetPropertyValue(nameof(Persona), ref persona, value);
        }


        [Size(3)]
        [RuleRequiredField]
        [XafDisplayName("Código de área")]
        public string CodigoArea
        {
            get => codigoArea;
            set => SetPropertyValue(nameof(CodigoArea), ref codigoArea, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [RuleRequiredField]
        [XafDisplayName("Número")]
        public string Numero
        {
            get => numero;
            set => SetPropertyValue(nameof(Numero), ref numero, value);
        }

    }
}
