//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KovdryaVA_3ISP11_12.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicalCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalCard()
        {
            this.Patient = new HashSet<Patient>();
        }
    
        public int Id { get; set; }
        public Nullable<int> DiseaseHistoryId { get; set; }
        public Nullable<int> RecipeListId { get; set; }
    
        public virtual DiseaseHistory DiseaseHistory { get; set; }
        public virtual RecipeList RecipeList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
