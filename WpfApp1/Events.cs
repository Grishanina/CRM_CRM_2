//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        public int EventsID { get; set; }
        public string Event { get; set; }
        public System.DateTime DataEvent { get; set; }
        public int IdRole { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
