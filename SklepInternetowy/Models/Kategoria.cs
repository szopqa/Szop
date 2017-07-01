using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy.Models
{
	public class Kategoria
	{
		
		public int KategoriaID { get; set; }

		[Required ( ErrorMessage = "Wprowadź nazwę kategorii" )]
		[StringLength ( 100 )]
		public string NazwaKategorii { get; set; }

		[Required ( ErrorMessage = "Wprowadź opis kategorii" )]
		public string OpisKategorii { get; set; }

		public string NazwaPlikuIkony { get; set; }

		//Kursy należące do jednej kategorii
		public virtual ICollection<Kurs> Kursy { get; set; }

	}
}