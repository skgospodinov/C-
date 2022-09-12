using System;
using System.Collections.Generic;
using System.Threading;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicLinkedList playlist = new MusicLinkedList();
            while (true)
            {
                Console.WriteLine("Add music to playlist src: ");
                string src = Console.ReadLine();
                if (src == "end")
                {
                    break;
                }
                playlist.AddLast(new NodeMusic(src));
            }

            playlist.ForeachFromHead((node) =>
            {
                Console.WriteLine($"Now Playing:{node.Value}");
                Thread.Sleep(1500);
            });
            List









            return;
            SoftuniLinkedListFastReverse list = new SoftuniLinkedListFastReverse();

            for (int i = 0; i < 10; i++) 
            {
                list.AddLast(new Node(i + 1));
            }
            list.Reverse();
            list.Reverse();
            list.Foreach((node) => Console.WriteLine(node.Value));
            return;











            SoftuniLinkedList linkedList = new SoftuniLinkedList();
            Console.WriteLine("Remove empty head: " + linkedList.RemoveHead());
            //for (int i = 0; i < 10; i++)
            //{
            //    linkedList.AddHead(new Node(i));
            //}
            for (int i = 0; i < 10; i++)
            {
                linkedList.AddLast(new Node(i));
            }

            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);
            
            Console.WriteLine("Remove tail: " + linkedList.RemoveTail().Value);
            

            Node currentNode = linkedList.Tail;
            Console.WriteLine("Foreach from head:");
            linkedList.ForeachFromHead((node) =>
            {
                Console.WriteLine($"From action: {node.Value}");
            });
            Console.WriteLine("Foreach from tail:");
            linkedList.ForeachFromTail((node) =>
            {
                Console.WriteLine($"From action: {node.Value}");
            });

            int[] linkedListAsArray = linkedList.ToArray();
        }
    }
}
