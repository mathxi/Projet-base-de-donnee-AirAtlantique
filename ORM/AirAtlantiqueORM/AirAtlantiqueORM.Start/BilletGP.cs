//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirAtlantiqueORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class BilletGP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BilletGP()
        {
            this.Ticket_Boarding = new HashSet<Ticket_Boarding>();
        }
    
        public int id { get; set; }
        public int id_Salaried { get; set; }
        public long id_Passenger { get; set; }
        public int id_Flight { get; set; }
        public int Price { get; set; }
    
        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
        public virtual Salaried Salaried { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket_Boarding> Ticket_Boarding { get; set; }
    }
}
