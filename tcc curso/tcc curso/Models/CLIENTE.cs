//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tcc_curso.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.PEDIDOS = new HashSet<PEDIDOS>();
        }
    
        public int COD_CLIENTE { get; set; }
        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string CEP { get; set; }
        public string RUA { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public string NR_CASA { get; set; }
        public string COMPLEMTENTO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public string PERFIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDOS> PEDIDOS { get; set; }
    }
}
