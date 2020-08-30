using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données EvenementCrossCanal
	///</summary>
	public class EvenementCrossCanal
	{
		///<summary>
		///Obtient ou définit la valeur Categorie
		///</summary>
		public string Categorie{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Descriptif
		///</summary>
		public string Descriptif{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ObligatoirePourIntegres
		///</summary>
		public bool ObligatoirePourIntegres{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ObligatoirePourAffilies
		///</summary>
		public bool ObligatoirePourAffilies{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Url
		///</summary>
		public string Url{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTime Date{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Message
		///</summary>
		public string Message{ get; set; }

	}
}
