//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Storage
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPurchase
    {
        public int IDProductPurchase { get; set; }
        public Nullable<int> IDPurchase { get; set; }
        public Nullable<int> IDProduct { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}