//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.UI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }
    
        public int idProveedor { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string numeroTelefono { get; set; }
        public string correo { get; set; }
        public int idEstadoProveedor { get; set; }
    
        public virtual EstadoProveedor EstadoProveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
