//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wardrobe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outfits2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Outfits2()
        {
            this.Wardrobeitems = new HashSet<Wardrobeitem>();
        }
    
        public int OutfitID { get; set; }
        public int TopID { get; set; }
        public int BottomID { get; set; }
        public int ShoeID { get; set; }
    
        public virtual Outfits2 Outfits21 { get; set; }
        public virtual Outfits2 Outfits22 { get; set; }
        public virtual Wardrobeitem Wardrobeitem { get; set; }
        public virtual Wardrobeitem Wardrobeitem1 { get; set; }
        public virtual Wardrobeitem Wardrobeitem2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wardrobeitem> Wardrobeitems { get; set; }
    }
}