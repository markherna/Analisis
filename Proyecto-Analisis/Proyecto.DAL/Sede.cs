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
    
    public partial class Sede
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sede()
        {
            this.Campanas = new HashSet<Campana>();
        }
    
        public int idSede { get; set; }
        public string descripcion { get; set; }
        public int idProvincia { get; set; }
        public int idCanton { get; set; }
        public int idDistrito { get; set; }
        public int idEstado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Campana> Campanas { get; set; }
        public virtual Estado Estado { get; set; }
    }
}