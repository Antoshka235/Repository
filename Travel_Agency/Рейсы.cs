//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel_Agency
{
    using System;
    using System.Collections.Generic;
    
    public partial class Рейсы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Рейсы()
        {
            this.Тур = new HashSet<Тур>();
        }
    
        public int ID { get; set; }
        public string Тип_транспорта { get; set; }
        public string Пункт_отправления { get; set; }
        public string Пункт_назначения { get; set; }
        public Nullable<System.DateTime> Дата_отправления { get; set; }
        public Nullable<int> Время_в_пути_в_часах { get; set; }
        public Nullable<int> Количетво_мест { get; set; }
        public Nullable<decimal> Цена { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Тур> Тур { get; set; }
    }
}
