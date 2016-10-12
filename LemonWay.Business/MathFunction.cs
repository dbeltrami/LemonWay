using System;
using log4net;

namespace LemonWay.Business
{
    public class MathFunction
    {
		private static readonly ILog Log = LogManager.GetLogger(typeof(MathFunction));

		public static int Fibonnaci(int n)
	    {
		    try
		    {
				if (n < 1 || n > 100)
				{
					return -1;
				}

				if (n == 1 || n == 2)
				{
					return 1;
				}

				return Fibonnaci(n - 1) + Fibonnaci(n - 2);
			}
		    catch (Exception e)
		    {
				Log.Error(e.Message);
		    }

			return -1;
		}
    }
}
