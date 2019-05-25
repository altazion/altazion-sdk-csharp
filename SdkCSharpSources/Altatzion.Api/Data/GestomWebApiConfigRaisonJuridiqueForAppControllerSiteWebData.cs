using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class SiteWebData
	{
		public System.String[] Urls{ get; set; }
		public string Code{ get; set; }
		public int Id{ get; set; }
		public string Libelle{ get; set; }
		public string Theme{ get; set; }
		public string CssTheme{ get; set; }
		public string MasterPage{ get; set; }
		public int RjsId{ get; set; }
		public int SegmentRacineId{ get; set; }
		public System.Int32? DefaultNewsletterId{ get; set; }
		public string UrlPrincipale{ get; set; }
		public string TelephoneServiceClient{ get; set; }
		public string EmailServiceClient{ get; set; }
		public string HorairesServiceClient{ get; set; }
		public System.Int32? SiteParentId{ get; set; }
		public Guid? VitrineTopVentesGuid{ get; set; }
		public Guid? VitrineHomeGuid{ get; set; }
		public Guid? VitrineNouveautesGuid{ get; set; }
		public bool EstEcommerce{ get; set; }
		public bool EstEnProduction{ get; set; }
		public Guid ZonePreparationParDefautGuid{ get; set; }
		public string Description{ get; set; }
		public string Titre{ get; set; }
		public bool EstBlog{ get; set; }
		public bool EstPrive{ get; set; }
		public string RootSearchPath{ get; set; }
		public string RootProductPath{ get; set; }
		public string RootPath{ get; set; }
		public Guid? ThemeGuid{ get; set; }
		public bool UtiliseMobilePages{ get; set; }
		public string MobileTheme{ get; set; }
	}
}
