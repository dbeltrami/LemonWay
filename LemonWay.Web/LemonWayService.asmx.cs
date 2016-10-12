using System.Web.Services;
using log4net;
using LemonWayService;

namespace LemonWay.Web
{
	/// <summary>
	/// Description résumée de LetmonWayService
	/// </summary>
	[WebService(Namespace = "LemonWay")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
	// [System.Web.Script.Services.ScriptService]
	public class LemonWayService : WebService
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof(LemonWayService));

		[WebMethod]
		public int Fibonnacci(int n)
		{
			Log.Info(string.Format("Value asked {0}", n));
			return MathFunction.Fibonnaci(n);
		}

		[WebMethod]
		public string XmlToJson(string inputString)
		{
			Log.Info(string.Format("Input string {0}", inputString));
			return XmlToJsonTool.XmlToJson(inputString);
		}
	}
}
