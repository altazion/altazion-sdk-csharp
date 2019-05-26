using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données TypeOpeComm
	///</summary>
	public class TypeOpeComm
	{
		///<summary>
		///Obtient ou définit la valeur MetaType
		///</summary>
		public MetaTypeOperation MetaType{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Namespace
		///</summary>
		public string Namespace{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DestinationGuid
		///</summary>
		public Guid DestinationGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DestinationLibelle
		///</summary>
		public string DestinationLibelle{ get; set; }

	}
}
