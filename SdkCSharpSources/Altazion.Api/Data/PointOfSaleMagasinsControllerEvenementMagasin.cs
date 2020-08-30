using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données EvenementMagasin
	///</summary>
	public class EvenementMagasin
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Description
		///</summary>
		public string Description{ get; set; }

		///<summary>
		///Obtient ou définit la valeur InfoEventCrossCanal
		///</summary>
		public EvenementCrossCanalBase InfoEventCrossCanal{ get; set; }

	}
}
