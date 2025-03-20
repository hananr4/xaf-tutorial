using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.Module.BusinessObjects
{

    [DefaultClassOptions]
    public class Persona : BaseObject
    {
        public Persona(Session session) : base(session) { }


        NivelInstruccion nivelInstruccion;
        Direccion direccionDomicilio;
        EstadoCivil estadoCivil;
        DateTime fechaNacimiento;
        string nombre;
        string cedula;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [RuleRequiredField]
        [XafDisplayName("Cédula")]
        public string Cedula
        {
            get => cedula;
            set => SetPropertyValue(nameof(Cedula), ref cedula, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [RuleRequiredField]
        public string Nombre
        {
            get => nombre;
            set => SetPropertyValue(nameof(Nombre), ref nombre, value);
        }



        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Fecha de nacimiento")]
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => SetPropertyValue(nameof(FechaNacimiento), ref fechaNacimiento, value);
        }


        public EstadoCivil EstadoCivil
        {
            get => estadoCivil;
            set => SetPropertyValue(nameof(EstadoCivil), ref estadoCivil, value);
        }

        [XafDisplayName("Nivel de Instrucción")]
        public NivelInstruccion NivelInstruccion
        {
            get => nivelInstruccion;
            set => SetPropertyValue(nameof(NivelInstruccion), ref nivelInstruccion, value);
        }

        [DevExpress.Xpo.Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never) ]
        [XafDisplayName("Dirección del domicilio")]
        public Direccion DireccionDomicilio
        {
            get => direccionDomicilio;
            set => SetPropertyValue(nameof(DireccionDomicilio), ref direccionDomicilio, value);
        }


        [Association, DevExpress.Xpo.Aggregated]
        [XafDisplayName("Teléfonos")]
        public XPCollection<Telefono> Telefonos
        {
            get
            {
                return GetCollection<Telefono>(nameof(Telefonos));
            }
        }
    }
}
