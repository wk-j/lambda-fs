#r "../../Ramda.Net/obj/Debug/Ramda.NET.dll"

using Ramda.NET;

var cr = R.Add(R.__, 100);

Console.WriteLine(cr(200));
Console.WriteLine(cr(300));
