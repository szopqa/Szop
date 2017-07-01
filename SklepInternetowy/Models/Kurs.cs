using System;
using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy.Models
{
	public class Kurs
	{
		public int KursId { get; set; }
		public int KategoriaID { get; set; }

		[Required(ErrorMessage = "Wprowadź nazwę kursu")]
		[StringLength(100)]
		public string TytulKursu { get; set; }
		[Required ( ErrorMessage = "Wprowadź autora kursu" )]
		[StringLength ( 100 )]
		public string AutorKursu { get; set; }
		public DateTime DataDodania { get; set; }

		[StringLength ( 100 )]
		public string NazwaPlikuObrazka { get; set; }
		public string OpisKursu { get; set; }
		public decimal CenaKursu { get; set; }
		public bool Bestseller { get; set; }
		public bool Ukryte { get; set; }
		public string OpisSkrocony { get; set; }
		public string Test { get; set; }


		public virtual Kategoria Kategoria { get; set; }
	}
}