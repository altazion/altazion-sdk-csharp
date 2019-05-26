using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données NouvellePublicite
	///</summary>
	public class NouvellePublicite
	{
		///<summary>
		///Obtient ou définit la valeur DestinationGuid
		///</summary>
		public Guid DestinationGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CampagneGuid
		///</summary>
		public Guid CampagneGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeOpe
		///</summary>
		public string TypeOpe{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateDebut
		///</summary>
		public DateTime DateDebut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateFin
		///</summary>
		public DateTime DateFin{ get; set; }

	}
}
