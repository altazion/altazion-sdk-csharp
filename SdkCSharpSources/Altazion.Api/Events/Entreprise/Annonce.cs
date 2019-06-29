using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Entreprise
{
	public partial class Annonce
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une publication va être rendue publique
		///</summary>
		public const string Publicationduneannonce = "PublicationAnnonce";

		///<summary>
		///Objet de données PublicationAnnonceEventData
		///</summary>
		public class PublicationAnnonceEventData
		{
			///<summary>
			///Obtient ou définit la valeur AnnonceGuid
			///</summary>
			public Guid AnnonceGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur DateDebut
			///</summary>
			public DateTimeOffset DateDebut{ get; set; }

		}
	}
}
