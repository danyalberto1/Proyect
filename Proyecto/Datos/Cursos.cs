//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cursos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cursos()
        {
            this.Segmentos = new HashSet<Segmentos>();
        }
    
        public int IdT_Curso { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Id_CursoRequisito { get; set; }
        public bool Autorizado { get; set; }
        public int IdF_Pais { get; set; }
        public Nullable<int> NotaMinima { get; set; }
        public bool Visible { get; set; }
        public string IdF_UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string IdF_UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public bool Estado { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual AspNetUsers AspNetUsers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Segmentos> Segmentos { get; set; }
    }
}
