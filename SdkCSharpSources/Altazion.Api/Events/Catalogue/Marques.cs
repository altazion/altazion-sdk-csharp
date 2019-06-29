using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Catalogue
{
	public partial class Marques
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une marque est créée
		///</summary>
		public const string CreationMarque = "CreationMarque";

		///<summary>
		///Objet de données CreationMarqueEventData
		///</summary>
		public class CreationMarqueEventData
		{
			///<summary>
			///Obtient ou définit la valeur MarPk
			///</summary>
			public int MarPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Libelle
			///</summary>
			public string Libelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Code
			///</summary>
			public string Code{ get; set; }

			///<summary>
			///Obtient ou définit la valeur EstInterne
			///</summary>
			public bool EstInterne{ get; set; }

		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une marque est modifiée
		///</summary>
		public const string ModificationMarque = "ModificationMarque";

		///<summary>
		///Objet de données ModificationMarqueEventData
		///</summary>
		public class ModificationMarqueEventData
		{
			///<summary>
			///Obtient ou définit la valeur MarPk
			///</summary>
			public int MarPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Libelle
			///</summary>
			public string Libelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Code
			///</summary>
			public string Code{ get; set; }

			///<summary>
			///Obtient ou définit la valeur EstInterne
			///</summary>
			public bool EstInterne{ get; set; }

		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une marque est supprimée
		///</summary>
		public const string SuppressionMarque = "SuppressionMarque";

		///<summary>
		///Objet de données SuppressionMarqueEventData
		///</summary>
		public class SuppressionMarqueEventData
		{
			///<summary>
			///Obtient ou définit la valeur MarPk
			///</summary>
			public int MarPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Libelle
			///</summary>
			public string Libelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Code
			///</summary>
			public string Code{ get; set; }

			///<summary>
			///Obtient ou définit la valeur EstInterne
			///</summary>
			public bool EstInterne{ get; set; }

		}
	}
}
