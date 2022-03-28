using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Filesystem.Ntfs;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.InteropServices;

var drive = DriveInfo.GetDrives()
    .Where(d => d.Name == "C:\\").First();

//var ntfsReader = new NtfsReader("C:", RetrieveMode.All);
var ntfsReader =
    new NtfsReader(drive, RetrieveMode.All);
var nodes =
    ntfsReader.GetNodes(drive.Name);
foreach (var node in nodes)
{
    Console.WriteLine(node.FullName);
}    