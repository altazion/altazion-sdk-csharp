using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données OpeCatalogueData
	///</summary>
	public class OpeCatalogueData
	{
		///<summary>
		///Obtient ou définit la valeur EstValide
		///</summary>
		public bool EstValide{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeOpe
		///</summary>
		public string TypeOpe{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateDebut
		///</summary>
		public DateTime DateDebut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateFin
		///</summary>
		public DateTime DateFin{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Pages
		///</summary>
		public OpeCataloguePageCustom[] Pages{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Publicites
		///</summary>
		public PubliciteItem[] Publicites{ get; set; }

	}
}
