using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class AdresseClientProcess
	{
		public Guid Guid{ get; set; }
		public string Civilite{ get; set; }
		public string Nom{ get; set; }
		public string Prenom{ get; set; }
		public string Adresse{ get; set; }
		public string Ville{ get; set; }
		public string Telephone{ get; set; }
		public string Mobile{ get; set; }
		public string CP{ get; set; }
		public string PayPk{ get; set; }
		public string Email{ get; set; }
	}
}
