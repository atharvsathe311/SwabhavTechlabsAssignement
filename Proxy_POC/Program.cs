using Proxy_POC.Models;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Atharv", "123456", "Ceo");
        Employee employee2 = new Employee("Amit", "123456", "Developer");
        Employee employee3 = new Employee("Shubu", "123456", "Client");


        Console.WriteLine("CEO Accessing");
        SharedFolderProxy folderProxy = new SharedFolderProxy(employee1);
        folderProxy.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Developer Accessing");
        SharedFolderProxy folderProxy2 = new SharedFolderProxy(employee2);
        Console.WriteLine(employee2.Role.ToUpper());
        folderProxy2.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Client Accessing");
        SharedFolderProxy folderProxy3 = new SharedFolderProxy(employee3);
        folderProxy3.ReadWriteOperation();


    }
}