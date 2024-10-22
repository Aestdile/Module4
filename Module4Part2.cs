


List<string> objects=new List<string>{"First", "Second", "Third"};


while(true)
{
    Console.Write("Do you add object: (yes/no)");
    string addObject=Console.ReadLine();
    if (addObject=="yes")
    {
        Console.Write("Please, enter newObjectName: ");
        string addNewObject=Console.ReadLine();
        objects.Add(addNewObject);
        Console.WriteLine($"{addNewObject} is added succesfully!");
    }
    else if (addObject=="no")
    {
        Console.Write("Do you want to remove an element in objects: (yes/no) ");
        string removeObject=Console.ReadLine();

        if (removeObject=="yes")
        {
            Console.Write("Please, enter removeObjectName: ");
            string removeElement=Console.ReadLine();
            if (objects.Remove(removeElement))
            {
                Console.WriteLine($"{removeElement} is removed succesfully!");
            }
            else
            {
                Console.WriteLine($"{removeElement} is not found!");
            }
        }
        else if (removeObject=="no")
        {
            break;
        }
    }
    else
    {
        Console.Write("Invalid input, please, your permission have to be 'yes' or 'no'.");
    }
}

Console.WriteLine($"Natijalar: " +string.Join(", ", objects));









