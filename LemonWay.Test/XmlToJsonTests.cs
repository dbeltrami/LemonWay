using LemonWayService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWay.Test
{
	[TestClass]
	public class XmlToJsonTests
	{
		[TestMethod]
		public void Bad_Format_Test()
		{
			Assert.AreEqual(XmlToJsonTool.XmlToJson("<foo>hello</bar>"), "Bad Xml format");
		}

		[TestMethod]
		public void Foo_Test()
		{
			Assert.AreEqual(XmlToJsonTool.XmlToJson("<foo>hello</foo>"), "{\r\n  \"foo\": \"hello\"\r\n}");
		}
	}
}
