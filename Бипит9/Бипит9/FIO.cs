//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Бипит9
{
    using System;
    using System.Collections.Generic;
    
    public partial class FIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIO()
        {
            this.Arenda = new HashSet<Arenda>();
        }
    
        public int Id { get; set; }
        public string FIO1 { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Tel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arenda> Arenda { get; set; }
    }
}
