using System.Configuration;
using System.Collections.Specialized;

// Test config file
ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

if (settings != null)
{
    foreach (ConnectionStringSettings cs in settings)
    {
        Console.WriteLine(cs.Name);
        Console.WriteLine(cs.ProviderName);
        Console.WriteLine(cs.ConnectionString);
    }
}

NameValueCollection sAll;
sAll = ConfigurationManager.AppSettings;

foreach (string s in sAll.AllKeys)
    Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));

Console.ReadLine();
