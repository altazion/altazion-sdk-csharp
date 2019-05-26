using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données CommandeEnAttente
	///</summary>
	public class CommandeEnAttente
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTime Date{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Numero
		///</summary>
		public string Numero{ get; set; }

		///<summary>
		///Obtient ou définit la valeur NomLivraison
		///</summary>
		public string NomLivraison{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Tags
		///</summary>
		public string Tags{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Etat
		///</summary>
		public CommandeEtat Etat{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DestinationLivraison
		///</summary>
		public string DestinationLivraison{ get; set; }

		///<summary>
		///Obtient ou définit la valeur IdentifiantPreparation
		///</summary>
		public string IdentifiantPreparation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstProcessComplet
		///</summary>
		public bool EstProcessComplet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ResultatPreparation
		///</summary>
		public EtatPreparation ResultatPreparation{ get; set; }

	}
}
