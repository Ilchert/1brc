// See https://aka.ms/new-console-template for more information
using OneBrc;
using System.Diagnostics;
var filePath = @"C:\projects\local\1brc-main\measurements.txt";

var start = Stopwatch.GetTimestamp();

await Utf8WithChannel.Run(filePath);
Console.WriteLine($"Ut8Channels Completed in {Stopwatch.GetElapsedTime(start)}");
start = Stopwatch.GetTimestamp();
SimpleString.Run(filePath);
Console.WriteLine($"Simple Completed in {Stopwatch.GetElapsedTime(start)}");
start = Stopwatch.GetTimestamp();
U8StringSimple.Run(filePath);
Console.WriteLine($"U8string Completed in {Stopwatch.GetElapsedTime(start)}");
