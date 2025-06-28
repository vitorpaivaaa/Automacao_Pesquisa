using SeleniumBot;
using System;

var web = new AutomationWeb();
web.TestWeb(); // <--- Change this line
Console.WriteLine("Test completed. Check console output from TestWeb() if any."); // Or some other message
Console.ReadLine();
