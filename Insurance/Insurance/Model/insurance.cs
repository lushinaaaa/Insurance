//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insurance.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class insurance
    {
        public int id { get; set; }
        public string insurence { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public int id_client { get; set; }
        public string car_owner { get; set; }
        public string car_model { get; set; }
        public string identification_number { get; set; }
        public string registration_number { get; set; }
        public int id_calculation { get; set; }
        public int id_employee { get; set; }
    
        public virtual clients clients { get; set; }
        public virtual employees employees { get; set; }
        public virtual insurance_calc insurance_calc { get; set; }
    }
}
