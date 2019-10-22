//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.EncabezadoCotizacions = new HashSet<EncabezadoCotizacion>();
        }
    
        public int idCliente { get; set; }
        public int idTipoCliente { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string idGenero { get; set; }
        public int idOcupacion { get; set; }
        public string numeroCelular { get; set; }
        public string otroNumero { get; set; }
        public string correo { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public Nullable<decimal> ingresoSalarial { get; set; }
        public int idProvincia { get; set; }
        public int idCanton { get; set; }
        public int idDistrito { get; set; }
        public string direccionExacta { get; set; }
        public string vehiculoInteres { get; set; }
        public int idEstadoCliente { get; set; }
    
        public virtual EstadoCliente EstadoCliente { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Ocupacion Ocupacion { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncabezadoCotizacion> EncabezadoCotizacions { get; set; }
    }
}