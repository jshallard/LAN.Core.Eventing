using System.Collections.Generic;

namespace LAN.Core.Eventing
{
	public abstract class RequestBase
	{
		public string CorrelationId { get; set; }
		public Dictionary<string, string> QueryStrings { get; set; }
	}
}