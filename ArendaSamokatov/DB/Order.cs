//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArendaSamokatov.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Payment = new HashSet<Payment>();
            this.Review = new HashSet<Review>();
        }
    
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int VehicleTariffID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public byte DeliveryTypeID { get; set; }
        public decimal TotalAmount { get; set; }
        public Nullable<System.DateTime> RentalStartDate { get; set; }
        public Nullable<System.DateTime> RentalEndDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }
        public virtual VehicleTariff VehicleTariff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Review { get; set; }
    }
}
