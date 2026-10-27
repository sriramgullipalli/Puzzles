using System;
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("Hello, Sriram!");

//Array
int[] arr = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Array: " + arr[1]);

//List
List<int> lst = new List<int>{1,2,3};
Console.WriteLine("List: " + lst[1]);

//LinkedList
LinkedList<int> ll = new LinkedList<int>();
ll.AddLast(1);
ll.AddLast(2);  
Console.WriteLine("LinkedList: " + ll.First.Value);

//Stack
Stack<int> stack = new Stack<int>();        
stack.Push(1);
stack.Push(2);  
Console.WriteLine("Stack: " + stack.Peek());

//Queue
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
Console.WriteLine("Queue: " + queue.Dequeue());

//PriorityQueue
PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        pq.Enqueue("Low priority task", 3);
        pq.Enqueue("Medium priority task", 5);
        pq.Enqueue("High priority task", 7);
        pq.Enqueue("Highest priority task", 10);
        while (pq.Count > 0)
        {
            string item = pq.Dequeue();
            Console.WriteLine("Processing: " + item);
        }

//Dictionary
Dictionary<string, int> dict = new Dictionary<string, int>();   
dict.Add("One", 1);
dict.Add("Two", 2);
Console.WriteLine(dict["One"]);

//HashSet
HashSet<int> hs = new HashSet<int>();   
hs.Add(1);
hs.Add(2);
Console.WriteLine(hs.Contains(1));

//SortedSet
SortedSet<int> ss = new SortedSet<int>();   
ss.Add(3);
ss.Add(1);
ss.Add(2);
foreach (var item in ss)
        {
           Console.WriteLine($"Item: {item}");
        }

//SortedDictionary
SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
sd.Add("Three", 3);
sd.Add("One", 1);
sd.Add("Two", 2);
foreach (var item in sd)
        {
            Console.WriteLine($"SortedKey: {item.Key}, SortedValue: {item.Value}");
        }

//HashTable
Hashtable ht = new Hashtable();
ht.Add("One", 1);
ht.Add("Two", 2);
foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"HashKey: {entry.Key}, HashValue: {entry.Value}");
        }

//Tuple
var tuple = Tuple.Create(1, "Hello", true);
Console.WriteLine($"Tuple: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}");

//ValueTuple
var valueTuple = (1, "Hello", true);        
Console.WriteLine($"ValueTuple: {valueTuple.Item1}, {valueTuple.Item2}, {valueTuple.Item3}");

//Tree
// C# does not have a built-in tree data structure, but you can implement one using classes and nodes. Here's a simple example of a binary tree:
public class TreeNode       
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

// Example usage of the binary tree
public class BinaryTree
{
    public TreeNode Root;

    public BinaryTree(int rootValue)
    {
        Root = new TreeNode(rootValue);
    }
}

//Graph
// C# does not have a built-in graph data structure, but you can implement one using        classes and collections. Here's a simple example of an undirected graph using an adjacency list:    
public class Graph
{
    private Dictionary<int, List<int>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }

    public void AddVertex(int vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<int>();
        }
    }

    public void AddEdge(int vertex1, int vertex2)
    {
        if (adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2))
        {
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1); // For undirected graph
        }
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjacencyList)
        {
            Console.Write($"Vertex {vertex.Key}: ");
            foreach (var neighbor in vertex.Value)
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}