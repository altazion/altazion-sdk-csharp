using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class UploadUrl
	{
		public string Upload{ get; set; }
		public string Result{ get; set; }
		public string Method{ get; set; }
		public Dictionary<System.String,System.String> HeadersToAdd{ get; set; }
	}
}
