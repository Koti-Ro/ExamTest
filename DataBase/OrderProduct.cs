//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamTest.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderProduct
    {
        public int OrderIds { get; set; }
        public int ProductIds { get; set; }
        public Nullable<int> CountOrderProduct { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
