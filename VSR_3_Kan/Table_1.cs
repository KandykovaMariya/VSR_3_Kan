//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSR_3_Kan
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_1
    {
        public Table_1()
        {
            this.Table_2 = new HashSet<Table_2>();
        }
    
        public int id_tabl1 { get; set; }
        public string C_1 { get; set; }
        public string C_2 { get; set; }
    
        public virtual ICollection<Table_2> Table_2 { get; set; }
    }
}
