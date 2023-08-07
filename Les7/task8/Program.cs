/*
Работа с файлами. Рекурсия. Обход директории
*/

// string path = @"Les7\example";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);

// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

void CatalogInfo(string path, string indent = "") 
{   
    DirectoryInfo catalog = new DirectoryInfo(path);
       
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent} {catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    // foreach (var currentCatalog in catalogs.GetDirectories())   
    // {       
    //     Console.WriteLine($"{indent}{currentCatalog.Name}");       
    //     CatalogInfo(currentCatalog.FullName, indent + "  ");   
    // }   
    
    // foreach (var item in catalogs.GetFiles())
    // {       
    //     Console.WriteLine($"{indent}{item.Name}");   
    // } 

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
} 



string path = @"C:\Users\maxko\SC\Les7\example"; 

CatalogInfo(path);