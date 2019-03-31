﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eRestoran150002Entities : DbContext
    {
        public eRestoran150002Entities()
            : base("name=eRestoran150002Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dostave> Dostave { get; set; }
        public virtual DbSet<Klijenti> Klijenti { get; set; }
        public virtual DbSet<KreditneKartice> KreditneKartice { get; set; }
        public virtual DbSet<Narudzbe> Narudzbe { get; set; }
        public virtual DbSet<NarudzbeStavke> NarudzbeStavke { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Popusti> Popusti { get; set; }
        public virtual DbSet<StavkeMenija> StavkeMenija { get; set; }
        public virtual DbSet<TipoviStavke> TipoviStavke { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }
        public virtual DbSet<ZaposleniciUloge> ZaposleniciUloge { get; set; }
    
        public virtual ObjectResult<esp_ArtikliProdatiKategorije_Result> esp_ArtikliProdatiKategorije(Nullable<int> tipID)
        {
            var tipIDParameter = tipID.HasValue ?
                new ObjectParameter("tipID", tipID) :
                new ObjectParameter("tipID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_ArtikliProdatiKategorije_Result>("esp_ArtikliProdatiKategorije", tipIDParameter);
        }
    
        public virtual ObjectResult<esp_BrojProdatihKlijent_Result> esp_BrojProdatihKlijent(Nullable<int> klijentID)
        {
            var klijentIDParameter = klijentID.HasValue ?
                new ObjectParameter("klijentID", klijentID) :
                new ObjectParameter("klijentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_BrojProdatihKlijent_Result>("esp_BrojProdatihKlijent", klijentIDParameter);
        }
    
        public virtual ObjectResult<esp_BrojProdatihZaposlenik_Result> esp_BrojProdatihZaposlenik(Nullable<int> zaposlenikID)
        {
            var zaposlenikIDParameter = zaposlenikID.HasValue ?
                new ObjectParameter("zaposlenikID", zaposlenikID) :
                new ObjectParameter("zaposlenikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_BrojProdatihZaposlenik_Result>("esp_BrojProdatihZaposlenik", zaposlenikIDParameter);
        }
    
        public virtual ObjectResult<esp_NajKupljeneStavke_Result> esp_NajKupljeneStavke(Nullable<int> klijentId)
        {
            var klijentIdParameter = klijentId.HasValue ?
                new ObjectParameter("KlijentId", klijentId) :
                new ObjectParameter("KlijentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_NajKupljeneStavke_Result>("esp_NajKupljeneStavke", klijentIdParameter);
        }
    
        public virtual ObjectResult<esp_NarudzbePregled_Result> esp_NarudzbePregled()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_NarudzbePregled_Result>("esp_NarudzbePregled");
        }
    
        public virtual ObjectResult<esp_OcjeneByStavka_Result> esp_OcjeneByStavka(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_OcjeneByStavka_Result>("esp_OcjeneByStavka", idParameter);
        }
    
        public virtual ObjectResult<esp_OcjenePrikaz_Result> esp_OcjenePrikaz()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_OcjenePrikaz_Result>("esp_OcjenePrikaz");
        }
    
        public virtual ObjectResult<esp_OcjeneStavkaPrikaz_Result> esp_OcjeneStavkaPrikaz(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_OcjeneStavkaPrikaz_Result>("esp_OcjeneStavkaPrikaz", idParameter);
        }
    }
}