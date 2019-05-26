using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données OperationData
	///</summary>
	public class OperationData
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
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeOperation
		///</summary>
		public string TypeOperation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DestinationGuid
		///</summary>
		public Guid DestinationGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Destination
		///</summary>
		public string Destination{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateDebut
		///</summary>
		public DateTime DateDebut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateFin
		///</summary>
		public DateTime DateFin{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CampagneGuid
		///</summary>
		public Guid CampagneGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CampagneLibelle
		///</summary>
		public string CampagneLibelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Valide
		///</summary>
		public bool Valide{ get; set; }

	}
}
