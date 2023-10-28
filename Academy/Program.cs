using Academy;
using System;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

var meny = new Meny();

var date = DateTime.UtcNow;

var spel = new List<string>(); // lista obv

string name = medHjälpare.GetName();

meny.visaMeny(name, date);
