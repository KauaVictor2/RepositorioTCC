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
    
    public partial class PEDIDOS
    {
        public int COD_PED { get; set; }
        public Nullable<int> COD_CLIENTE { get; set; }
        public Nullable<int> COD_MARM { get; set; }
        public Nullable<int> COD_FUNC { get; set; }
        public string HORARIO_PEDIDO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
        public virtual MARMITAS MARMITAS { get; set; }
    }
}
