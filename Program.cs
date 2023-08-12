using System.Configuration;
using System.Collections.Specialized;

// Test config file
string? sAttr;
sAttr = ConfigurationManager.AppSettings.Get("connectionString");
Console.WriteLine("The value of Key0 is " + sAttr);

NameValueCollection sAll;
sAll = ConfigurationManager.AppSettings;

foreach (string s in sAll.AllKeys)
    Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));

Console.ReadLine();
