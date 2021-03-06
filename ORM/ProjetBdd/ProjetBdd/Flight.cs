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
    
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.BilletGP = new HashSet<BilletGP>();
            this.Luggage = new HashSet<Luggage>();
            this.Ticket_Boarding = new HashSet<Ticket_Boarding>();
            this.Trip = new HashSet<Trip>();
            this.Salaried = new HashSet<Salaried>();
        }
    
        public int id { get; set; }
        public int id_Plane { get; set; }
        public int id_Airport_Start { get; set; }
        public int id_Airport_End { get; set; }
        public int id_Airport_End_Real { get; set; }
        public System.DateTime Hours_Departure { get; set; }
        public System.DateTime Hours_Arrival { get; set; }
        public System.DateTime Hours_Lift_OFF { get; set; }
        public System.DateTime Hours_Landing { get; set; }
    
        public virtual Airport Airport { get; set; }
        public virtual Airport Airport1 { get; set; }
        public virtual Airport Airport2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BilletGP> BilletGP { get; set; }
        public virtual Plane Plane { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Luggage> Luggage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket_Boarding> Ticket_Boarding { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salaried> Salaried { get; set; }
    }
}
