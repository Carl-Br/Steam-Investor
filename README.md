# [Dowload here](http://download1652.mediafire.com/3wpvi50lxnkg/si5ku94ddr7848g/Setup.msi) Steam Investor v1.1.4  (Beta)
 
This application shows you a few statistics on  how much profit you have made, with your steam investments. It's quiet usefull to get a quick overview about you current investments.


Join the [Discord](https://discord.gg/x4kuTWW) if you have any questions or problems.

# How to Update you application
* Go to local files\Programms(86)\Shynex Company\Steam Investor
* copy the files `MySteamItems.json` and `CharData.json`to your desktop
* dowload and install the new version
* copy the files back to the `Steam Investor`folder
  * Go to local files\Programms(86)\Shynex Company\Steam Investor
  * drag the files you have just put on your desktop back to the `Steam Investor`folder


# For The programmers
I know it's messy.
Feel free to improve it!

### Installing the application with visual studio:
* Go to `MyPathes.cs` and change these variables to:
  * `public static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);`
  * `public static string MySteamItems = path + "\\MySteamItems.json;`
* After that go to "App.manifest" and change `<requestedExecutionLevel level="asInvoker" uiAccess="false" />` to `<requestedExecutionLevel level="requireAdministrator" uiAccess="false" />` so the application can save the users data.
