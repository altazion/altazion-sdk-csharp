using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TagValueData
	{
		public string TextData{ get; set; }
		public Guid ValueGuid{ get; set; }
		public string HtmlData{ get; set; }
		public string ImageUrl{ get; set; }
		public string ColorData{ get; set; }
	}
}
