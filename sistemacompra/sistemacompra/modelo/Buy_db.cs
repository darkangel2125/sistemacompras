//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemacompra.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy_db
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buy_db()
        {
            this.BuyDetail = new HashSet<BuyDetail>();
        }
    
        public Nullable<System.DateTime> date_buy { get; set; }
        public string total_buy { get; set; }
        public string obseration_buy { get; set; }
        public string state_buy { get; set; }
        public decimal Buy_db_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyDetail> BuyDetail { get; set; }
        public virtual PayDetail PayDetail { get; set; }
    }
}