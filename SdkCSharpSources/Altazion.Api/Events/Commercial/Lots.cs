using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Commercial
{
	public partial class Lots
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'un lot est créé
		///</summary>
		public const string CreationLot = "CreationLot";

		///<summary>
		///Objet de données CreationLotEventData
		///</summary>
		public class CreationLotEventData
		{
			///<summary>
			///Obtient ou définit la valeur PmlGuid
			///</summary>
			public Guid PmlGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlRef
			///</summary>
			public string PmlRef{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlLibelle
			///</summary>
			public string PmlLibelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlGplGuid
			///</summary>
			public Guid PmlGplGuid{ get; set; }

			public static CreationLotEventData TryParse(string jsonData)
			{
				CreationLotEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/commercial",CreationLot, out ret))
					return null;
				return ret;
			}
		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'un lot est modifié
		///</summary>
		public const string ModificationLot = "ModificationLot";

		///<summary>
		///Objet de données ModificationLotEventData
		///</summary>
		public class ModificationLotEventData
		{
			///<summary>
			///Obtient ou définit la valeur PmlGuid
			///</summary>
			public Guid PmlGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlRef
			///</summary>
			public string PmlRef{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlLibelle
			///</summary>
			public string PmlLibelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlGplGuid
			///</summary>
			public Guid PmlGplGuid{ get; set; }

			public static ModificationLotEventData TryParse(string jsonData)
			{
				ModificationLotEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/commercial",ModificationLot, out ret))
					return null;
				return ret;
			}
		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'un lot est archivé
		///</summary>
		public const string ArchivageLot = "ArchivageLot";

		///<summary>
		///Objet de données ArchivageLotEventData
		///</summary>
		public class ArchivageLotEventData
		{
			///<summary>
			///Obtient ou définit la valeur PmlGuid
			///</summary>
			public Guid PmlGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlRef
			///</summary>
			public string PmlRef{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlLibelle
			///</summary>
			public string PmlLibelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PmlGplGuid
			///</summary>
			public Guid PmlGplGuid{ get; set; }

			public static ArchivageLotEventData TryParse(string jsonData)
			{
				ArchivageLotEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/commercial",ArchivageLot, out ret))
					return null;
				return ret;
			}
		}
	}
}
