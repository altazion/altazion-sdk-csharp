using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class Message
	{
		public Guid Guid{ get; set; }
		public Guid? Uxid{ get; set; }
		public Guid? GroupeGuid{ get; set; }
		public string Sujet{ get; set; }
		public string Details{ get; set; }
		public bool EstTraite{ get; set; }
		public bool EstImportant{ get; set; }
		public string Url{ get; set; }
		public DateTimeOffset Date{ get; set; }
	}
}
