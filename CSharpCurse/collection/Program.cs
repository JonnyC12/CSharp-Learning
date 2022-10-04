using System.Text;
using System.Collections.Generic;
// probaremos un poco las linked list

string[] word = { "the", "fox", "jumps", "over", "the", "dog" };
LinkedList<string> sentence = new LinkedList<string>(word);


// add word "today" to the begiinign of the linked list

sentence.AddFirst("today ");

// move first node to the final 

LinkedListNode<string> first = sentence.First;
sentence.RemoveFirst();
sentence.AddLast(first);





void Display(LinkedList<string> words, string test)
{
    Console.WriteLine(test);
    foreach (string word in words)
    {
        Console.Write(word + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void IndicateNode(LinkedListNode<string> node, string test)
{
    Console.WriteLine(test);
    if (node.List == null)
    {
        Console.WriteLine("Node '{0}' is not in the list.\n",
            node.Value);
        return;
    }

    StringBuilder result = new StringBuilder("(" + node.Value + ")");
    LinkedListNode<string> nodeP = node.Previous;

    while (nodeP != null)
    {
        result.Insert(0, nodeP.Value + " ");
        nodeP = nodeP.Previous;
    }

    node = node.Next;
    while (node != null)
    {
        result.Append(" " + node.Value);
        node = node.Next;
    }

    Console.WriteLine(result);
    Console.WriteLine();
}

//************ QUEUE ********/// 

Queue<int> numbers = new Queue<int>();

// add numbers tu quuee

foreach (var item in new int[5] { 1, 2, 3, 4, 5 })
{
    numbers.Enqueue(item);
}

//print elements in queuee
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// remove elements 
Console.WriteLine("Eliminando elementos");
numbers.Dequeue();
numbers.Dequeue();


//****************** STACK ************ /// 

Stack<int> numbers2 = new Stack<int>();

foreach (var item in new int[5] { 1, 2, 3, 4, 5 })
{
    numbers2.Push(item);
}

// recorriendo el stack 

foreach (var item in numbers2)
{
    Console.WriteLine(item);
}

// eliminando elementos; 

numbers2.Pop();// eliminamos 5 
numbers2.Pop();// eliminamos 4

///*********** DICTIONARY *********// 

Dictionary<string, int> edades = new Dictionary<string, int>();

// rellenado el diccionario 

edades.Add("juan", 18);
edades.Add("per", 12);
edades["maria"] = 39;
edades["pedro"] = 40;


foreach (KeyValuePair<string, int> persona in edades)
{
    Console.WriteLine("Nombre:" + persona.Key + "Edad: " + persona.Value);
}