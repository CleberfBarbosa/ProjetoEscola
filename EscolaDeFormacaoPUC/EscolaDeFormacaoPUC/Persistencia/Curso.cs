//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscolaDeFormacaoPUC.Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            this.AlunoCurso = new HashSet<AlunoCurso>();
        }
    
        public int IDCurso { get; set; }
        public string Curso1 { get; set; }
        public string Turma { get; set; }
        public string DiasSemana { get; set; }
        public System.TimeSpan Horario { get; set; }
        public System.DateTime DataInicio { get; set; }
        public System.DateTime DataFim { get; set; }
        public string Ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlunoCurso> AlunoCurso { get; set; }
    }
}
