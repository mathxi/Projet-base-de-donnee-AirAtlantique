//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetBdd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Price()
        {
            this.Billet = new HashSet<Billet>();
        }
    
        public int id { get; set; }
        public int id_Trip { get; set; }
        public int id_Classes { get; set; }
        public int id_TypePrice { get; set; }
        public short Prix { get; set; }
        public System.DateTime Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billet> Billet { get; set; }
        public virtual Classes Classes { get; set; }
        public virtual Trip Trip { get; set; }
        public virtual TypePrice TypePrice { get; set; }
    }
}
