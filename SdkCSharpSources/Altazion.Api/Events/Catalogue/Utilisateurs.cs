using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Catalogue
{
	public partial class Utilisateurs
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'un utilisateur est archivé
		///</summary>
		public const string ArchivageUtilisateur = "CreationUser";

		///<summary>
		///Objet de données ArchivageUserEventData
		///</summary>
		public class ArchivageUserEventData
		{
			///<summary>
			///Obtient ou définit la valeur UserPk
			///</summary>
			public decimal UserPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserLogin
			///</summary>
			public string UserLogin{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserUxid
			///</summary>
			public Guid? UserUxid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserType
			///</summary>
			public string UserType{ get; set; }

			public static ArchivageUserEventData TryParse(string jsonData)
			{
				ArchivageUserEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/rp",ArchivageUtilisateur, out ret))
					return null;
				return ret;
			}
		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'un utilisateur est créé
		///</summary>
		public const string CreationUtilisateur = "CreationUser";

		///<summary>
		///Objet de données CreationUserEventData
		///</summary>
		public class CreationUserEventData
		{
			///<summary>
			///Obtient ou définit la valeur UserPk
			///</summary>
			public decimal UserPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserLogin
			///</summary>
			public string UserLogin{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserUxid
			///</summary>
			public Guid? UserUxid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserType
			///</summary>
			public string UserType{ get; set; }

			public static CreationUserEventData TryParse(string jsonData)
			{
				CreationUserEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/rp",CreationUtilisateur, out ret))
					return null;
				return ret;
			}
		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'un utilisateur est modifié
		///</summary>
		public const string ModificationUtilisateur = "ModificationUser";

		///<summary>
		///Objet de données ModificationUserEventData
		///</summary>
		public class ModificationUserEventData
		{
			///<summary>
			///Obtient ou définit la valeur UserPk
			///</summary>
			public decimal UserPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserLogin
			///</summary>
			public string UserLogin{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserUxid
			///</summary>
			public Guid? UserUxid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur UserType
			///</summary>
			public string UserType{ get; set; }

			public static ModificationUserEventData TryParse(string jsonData)
			{
				ModificationUserEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/rp",ModificationUtilisateur, out ret))
					return null;
				return ret;
			}
		}
	}
}
