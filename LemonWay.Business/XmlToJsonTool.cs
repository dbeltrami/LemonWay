using System;
using System.Xml;
using log4net;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace LemonWayService
{
	public class XmlToJsonTool
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof(XmlToJsonTool));

		public static string XmlToJson(string inputString)
		{
			try
			{
				var doc = new XmlDocument();
				doc.LoadXml(inputString);
				inputString = JsonConvert.SerializeXmlNode(doc,Formatting.Indented);

				return inputString;
			}
			catch (Exception e)
			{
				Log.Error(string.Format("Bad Format : {0}",e.Message));
				return "Bad Xml format";
			}
		}
	}
}
