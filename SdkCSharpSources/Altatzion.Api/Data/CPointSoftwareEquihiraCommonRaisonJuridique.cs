using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class RaisonJuridique
	{
		public string FormeJuridique{ get; set; }
		public string Adresse{ get; set; }
		public string Siret{ get; set; }
		public string Ape{ get; set; }
		public string NumeroTVA{ get; set; }
		public string RCSNumero{ get; set; }
		public string RCSVille{ get; set; }
		public bool EstMicroEntreprise{ get; set; }
		public bool EstParticulier{ get; set; }
		public decimal? Capital{ get; set; }
		public string RaisonSociale{ get; set; }
		public int Id{ get; set; }
		public string Code{ get; set; }
	}
}
