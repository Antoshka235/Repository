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
    
    public partial class Фото_отелей
    {
        public int ID { get; set; }
        public Nullable<int> ОтельID { get; set; }
        public string Название_отеля { get; set; }
        public string Image { get; set; }
    
        public virtual Отель Отель { get; set; }
    }
}
