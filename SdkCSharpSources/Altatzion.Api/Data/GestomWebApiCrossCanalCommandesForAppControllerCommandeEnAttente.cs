using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class CommandeEnAttente
	{
		public Guid Guid{ get; set; }
		public DateTime Date{ get; set; }
		public string Numero{ get; set; }
		public string NomLivraison{ get; set; }
		public string Tags{ get; set; }
		public CommandeEtat Etat{ get; set; }
		public string DestinationLivraison{ get; set; }
		public string IdentifiantPreparation{ get; set; }
		public bool EstProcessComplet{ get; set; }
		public EtatPreparation ResultatPreparation{ get; set; }
	}
}
