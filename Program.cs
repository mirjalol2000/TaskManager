// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome our app");
Console.WriteLine("add user");
Console.Write("Enter your name : ");
string name = Console.ReadLine();
List<string> task = new List<string>();

bool num = true;
while (num == true) { 
Console.WriteLine("1. Add task \n2. Delete task \n3. Done \n4. Show your tasks");
Console.WriteLine("Choose this one ?");

int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
        Console.Write("Enter task name :");
        string s = Console.ReadLine();
        task.Add(s);
        Console.WriteLine("Added is successfully !");
        break;
    case 2:
        Console.WriteLine("Enter task name that you want to deleted ?");
        string del = Console.ReadLine();
        task.Remove(del);
        Console.WriteLine("Deleted is successfully !");
        break;
    case 3:
        Console.WriteLine("Done");
        break;
    case 4:
            for (int i = 0; i < task.Count; i++)
            {
                Console.WriteLine(task[i]);
            }
            break;
}
}

//Console.WriteLine("Hello, World!");
Console.ReadKey();