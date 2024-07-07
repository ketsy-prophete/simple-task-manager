List<string> tasklist = new List<string>();


bool continueProgram = true;
while (continueProgram)
{
    Console.WriteLine("\n");

    displayOptions();

    Console.Write("_________________\nEnter your choice: ");
    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.Write("\"Create a Task\" has been selected.\n");
            Console.WriteLine(createTask());
            break;
        case "2":
            Console.Write("\"View All Tasks\" has been selected. Here is your list of tasks: \n");
            Console.WriteLine("\n");
            Console.WriteLine(displayTask());
            break;
        case "3":
            Console.Write("\"Delete a Task\" has been selected. \n");
            Console.WriteLine(deleteTask());
            break;
        case "4":
            Console.Write("Goodbye!");
            continueProgram = false;
            break;
    }
}


void displayOptions()
{
    string list = "1. Create a Task\n2. View All Tasks\n3. Delete a Task\n4. Quit";
    Console.WriteLine(list);
}

string createTask()
{
    Console.Write("What is the name of the task to create? ");
    string newTask = Console.ReadLine() ?? "";
    tasklist.Add(newTask);

    Console.WriteLine("\n");
    string message = $"\"{newTask}\" - has been added!";
    return message;
}

string displayTask()
{
    string result = "";

    for (int i = 0; i < tasklist.Count; i++)
    {
        result += $"{i + 1}. {tasklist[i]}\n";
    }

    return result;
}

string deleteTask()
{
    Console.Write("Enter the number of the task you would like to delete: ");
    string input = Console.ReadLine() ?? "";
    if (!int.TryParse(input, out int taskNumber))
    {
        return "Invalid Choice";
    }
    else if (taskNumber < 1 || taskNumber > tasklist.Count)
    {
        return "Invalid Choice";
    }
    else
    {
        string deletedTask = tasklist[taskNumber - 1];
        tasklist.RemoveAt(taskNumber - 1);
        Console.WriteLine("\n");
        return $"\"{deletedTask}\" - has been successfully removed!";
    }
}