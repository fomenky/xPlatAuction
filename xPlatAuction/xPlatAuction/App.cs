using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace xPlatAuction
{

	public class App : Xamarin.Forms.Application
	{

		private static AuctionService azService;

		public App()
		{
			MainPage = new NavigationPage(
				new Auctions());
		}
		public static AuctionService GetAuctionService()
		{
			if (azService == null)
			{
				azService = new AuctionService("http://mosesogutu-hp/xPlatAuction/");
			}
			return azService;
		}
	}
}
