/*
 * Name: Binary Search Tree
 * Author: 
 * Compiled with the C#.Net 2.0 compiler
 */

using System;

namespace BST
{
    public class Tree
    {
         public static void Main()
        {
            Root objRoot = new Root();
            x:Console.Clear();
            ConsoleKeyInfo select;
            Console.WriteLine("Binary Search Tree\n--------------------\n[I] Insert\n[D] Delete\n[U] Update\n[S] Search\n[E] Exit\n\nCHOOSE:> ");
            select = Console.ReadKey();
            switch (select.KeyChar)
            {
                case 'I':
                case 'i':
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Insert To The Tree\n--------------------\nEnter Value: ");
                        int key = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter Data: ");
                        string data = Console.ReadLine();
                        objRoot.Insert(key, data);
                        Console.WriteLine("\n>>>Insert value to the tree successfully.\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("\nERROR: " + e.Message + "\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    break;
                case 'D':
                case 'd':
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Delete From The Tree\n--------------------\nEnter Value: ");
                        int key = Convert.ToInt16(Console.ReadLine());
                        objRoot.Delete(key);
                        Console.WriteLine("\n>>>Delete value from the tree successfully.\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("\nERROR: " + e.Message + "\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    break;
                case 'S':
                case 's':
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Search The Tree Node\n--------------------\nEnter Value: ");
                        int key = Convert.ToInt16(Console.ReadLine());
                        Node search = objRoot.Search(key);
                        if(search == null)
                            Console.WriteLine("\n>>>Value not found.\nPress any key...");
                        else
                            Console.WriteLine("\n>>>Value found.\nKey is: " + search.key + "\nData is: " + search.data + "\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("\nERROR: " + e.Message + "\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    break;
                case 'U':
                case 'u':
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Update The Tree Node\n--------------------\nEnter Value: ");
                        int key = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter New Data: ");
                        string data = Console.ReadLine();
                        objRoot.Update(key, data);
                        Console.WriteLine("\n>>>Update value of the tree successfully.\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("\nERROR: " + e.Message + "\nPress any key...");
                        Console.ReadKey(true);
                        goto x;
                    }
                    break;
                case 'E':
                case 'e':
                    break;
                default:
                    Console.WriteLine("\nINCORRECT");
                    goto x;
                    break;
            }
        }
    }
}
