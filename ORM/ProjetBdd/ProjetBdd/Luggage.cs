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
    
    public partial class Luggage
    {
        public int id { get; set; }
        public int id_Flight { get; set; }
        public int id_Billet { get; set; }
        public Nullable<short> Weight { get; set; }
    
        public virtual Billet Billet { get; set; }
        public virtual Flight Flight { get; set; }
    }
}