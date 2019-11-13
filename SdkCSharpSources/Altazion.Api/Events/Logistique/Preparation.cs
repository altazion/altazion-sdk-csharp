using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Logistique
{
	public partial class Preparation
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une commande change d'état de préparation
		///</summary>
		public const string PreparationCommande = "PreparationBpr";

		///<summary>
		///Objet de données PreparationCommandeEventData
		///</summary>
		public class PreparationCommandeEventData
		{
			///<summary>
			///Obtient ou définit la valeur BcdGuid
			///</summary>
			public Guid BcdGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur BprGuid
			///</summary>
			public Guid BprGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur BprType
			///</summary>
			public string BprType{ get; set; }

			public static PreparationCommandeEventData Parse(string jsonData)
			{
				PreparationCommandeEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/rp",PreparationCommande, out ret))
					return null;
				return ret;
			}
		}
	}
}
