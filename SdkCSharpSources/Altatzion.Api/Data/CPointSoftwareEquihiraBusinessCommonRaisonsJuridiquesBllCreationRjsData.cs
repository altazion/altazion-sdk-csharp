using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class CreationRjsData
	{
		public string NomUtilisateur{ get; set; }
		public System.Int32? RjsIdDemandee{ get; set; }
		public Guid? UxidUtilisateur{ get; set; }
		public string EmailUtilisateur{ get; set; }
		public string MotDePasseUtilisateur{ get; set; }
		public string RaisonJuridique{ get; set; }
		public string PayPk{ get; set; }
		public string ProductKey{ get; set; }
		public bool UseQuickSetup{ get; set; }
		public Guid? PartenaireGuid{ get; set; }
	}
}
