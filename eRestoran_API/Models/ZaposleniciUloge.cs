//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eRestoran_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZaposleniciUloge
    {
        public int ZaposlenikUlogaID { get; set; }
        public int UlogaID { get; set; }
        public int ZaposlenikID { get; set; }
        public System.DateTime DatumIzmjene { get; set; }
    
        public virtual Uloge Uloge { get; set; }
        public virtual Zaposlenici Zaposlenici { get; set; }
    }
}
