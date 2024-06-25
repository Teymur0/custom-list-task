using custom_list_task;

MyList myList = new MyList();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Remove(3);
myList.Reverse();

foreach (var item in myList)
{
    Console.WriteLine( item);
}