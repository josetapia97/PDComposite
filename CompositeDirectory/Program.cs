
using CompositeDirectory.Elements;

var file1 = new AppFile("File1");
var file2 = new AppFile("File2");
var file3 = new AppFile("File3");

var folder1 = new Folder("Folder1");
folder1.AddItem(file1);


var folder2 = new Folder("Folder2");
folder2.AddItem(file2);
folder2.AddItem(file3);

var root = new Folder("root");
root.AddItem(folder1);

folder1.AddItem(folder2);
root.Display();