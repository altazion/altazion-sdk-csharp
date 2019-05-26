using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données Publicite
	///</summary>
	public class Publicite
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateDebut
		///</summary>
		public DateTime DateDebut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateFin
		///</summary>
		public DateTime DateFin{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeOpe
		///</summary>
		public string TypeOpe{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Items
		///</summary>
		public PubliciteItem[] Items{ get; set; }

	}
}
