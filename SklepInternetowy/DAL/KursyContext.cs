using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SklepInternetowy.DAL
{
	public class KursyContext : DbContext
	{
		public KursyContext ( ) : base("KursyContext")
		{

		}

		static KursyContext ( )
		{
			Database.SetInitializer<KursyContext> ( new KursyInitializer ( ) );
		}

		//Tabela Kursów
		public DbSet<Kurs> Kursy { get; set; }

		//Tabela kategorii
		public DbSet<Kategoria> Kategorie { get; set; }

		//Tabela zamówień
		public DbSet<Zamowienie> Zamowienia { get; set; }

		//Tabela pozycji zamowien
		public DbSet<PozycjaZamowienia> PozycjeZamownienia { get; set; }


		protected override void OnModelCreating ( DbModelBuilder modelBuilder )
		{
			base.OnModelCreating ( modelBuilder );

			modelBuilder.Conventions.Remove<PluralizingTableNameConvention> ( );
		}

	}
}