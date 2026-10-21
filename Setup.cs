using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace start
{
	class Setup
	{
		public static bool firsttime = false;
		public static void setup()
		{
			//sets up all the important files so openrec doesnt crash like lame vaultserver xD
			Console.WriteLine("Setting up... (May take a minute to download everything.)");
			Directory.CreateDirectory("SaveData\\App\\"); Console.WriteLine("Created SaveData\\App\\");
			Directory.CreateDirectory("SaveData\\Profile\\"); Console.WriteLine("Created SaveData\\Profile\\");
			Directory.CreateDirectory("SaveData\\Images\\"); Console.WriteLine("Created SaveData\\Images\\");
			Directory.CreateDirectory("SaveData\\Rooms\\"); Console.WriteLine("Created SaveData\\Rooms\\");
			Directory.CreateDirectory("SaveData\\Images\\"); Console.WriteLine("Created SaveData\\Images\\");
			Directory.CreateDirectory("SaveData\\Rooms\\Downloaded\\"); Console.WriteLine("Created SaveData\\Rooms\\Downloaded\\");
			if (!(File.Exists("SaveData\\App\\firsttime.txt")))
			{
				File.WriteAllText("SaveData\\App\\firsttime.txt", "this text file has no use other than to tell the program whether to bring up the intro or not, so i can just write random shit here. among us balls, you suck mad dick you big fat fa----");
				Console.WriteLine("Created SaveData\\App\\firsttime.txt");
				firsttime = true;
			}
			if (!(File.Exists("SaveData\\avatar.txt")))
			{
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/avatar.txt"));
				Console.WriteLine("Created SaveData\\avatar.txt");
			}
			else if (File.ReadAllText("SaveData\\avatar.txt") == "")
            {
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/avatar.txt"));
				Console.WriteLine("Updated SaveData\\avatar.txt");
			}
			if (!(File.Exists("SaveData\\avataritems.txt")))
			{
				File.WriteAllText("SaveData\\avataritems.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/avataritems.txt"));
				Console.WriteLine("Created SaveData\\avataritems.txt");
			}
			if (!(File.Exists("SaveData\\avataritems2.txt")))
			{
				File.WriteAllText("SaveData\\avataritems2.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/avataritems2.txt"));
				Console.WriteLine("Created SaveData\\avataritems2.txt");
			}
			if (!(File.Exists("SaveData\\equipment.txt")))
			{
				File.WriteAllText("SaveData\\equipment.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/equipment.txt"));
				Console.WriteLine("Created SaveData\\equipment.txt");
			}
			if (!(File.Exists("SaveData\\consumables.txt")))
			{
				File.WriteAllText("SaveData\\consumables.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/consumables.txt"));
				Console.WriteLine("Created SaveData\\consumables.txt");
			}
			if (!(File.Exists("SaveData\\gameconfigs.txt")))
			{
				File.WriteAllText("SaveData\\gameconfigs.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/gameconfigs.txt"));
				Console.WriteLine("Created SaveData\\gameconfigs.txt");
			}
			if (!(File.Exists("SaveData\\storefronts2.txt")))
			{
				File.WriteAllText("SaveData\\storefronts2.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/storefront2.txt"));
				Console.WriteLine("Created SaveData\\storefronts2.txt");
			}
			if (!(File.Exists("SaveData\\baserooms.txt")))
			{
				File.WriteAllText("SaveData\\baserooms.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/baserooms.txt"));
				Console.WriteLine("Created SaveData\\baserooms.txt");
			}
			if (!(File.Exists("SaveData\\Profile\\username.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\username.txt", "NeoRec User#" + new Random().Next(0, 1000000));
				Console.WriteLine("Created SaveData\\Profile\\username.txt");
			}
			if (!(File.Exists("SaveData\\Profile\\level.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\level.txt", "10");
				Console.WriteLine("Created SaveData\\Profile\\level.txt");
			}
			if (!(File.Exists("SaveData\\Profile\\userid.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\userid.txt", "10000000");
				Console.WriteLine("Created SaveData\\Profile\\userid.txt");
			}
			if (!(File.Exists("SaveData\\myrooms.txt")))
			{
				File.WriteAllText("SaveData\\myrooms.txt", "[]");
				Console.WriteLine("Created SaveData\\myrooms.txt");
			}
			if (!(File.Exists("SaveData\\settings.txt")))
			{
				File.WriteAllText("SaveData\\settings.txt", Newtonsoft.Json.JsonConvert.SerializeObject(api.Settings.CreateDefaultSettings()));
				Console.WriteLine("Created SaveData\\settings.txt");
			}
			if (!(File.Exists("SaveData\\profileimage.png")))
			{
				File.WriteAllBytes("SaveData\\profileimage.png", new WebClient().DownloadData("https://github.com/OpenRecRoom/OpenRec/raw/main/profileimage.png"));
				Console.WriteLine("Created SaveData\\profileimage.png");
			}
			if (!(File.Exists("SaveData\\App\\privaterooms.txt")))
			{
				File.WriteAllText("SaveData\\App\\privaterooms.txt", "Disabled");
				Console.WriteLine("Created SaveData\\App\\privaterooms.txt");
			}
			if (!(File.Exists("SaveData\\App\\showopenrecinfo.txt")))
			{
				File.WriteAllText("SaveData\\App\\showopenrecinfo.txt", "Enabled");
				Console.WriteLine("Created SaveData\\App\\showopenrecinfo.txt");
			}
			if (!(File.Exists("SaveData\\App\\facefeaturesadd.txt")))
			{
				File.WriteAllText("SaveData\\App\\facefeaturesadd.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/Bkerboy/NeoRec/master/Download/facefeaturesadd.txt"));
				Console.WriteLine("Created SaveData\\App\\facefeaturesadd.txt");
			}
			Console.WriteLine("Done!");
			Console.Clear();
		}
	}
}
