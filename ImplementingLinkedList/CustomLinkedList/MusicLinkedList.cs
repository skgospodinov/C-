using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class MusicLinkedList
    {
        
        public NodeMusic Head { get; set; }
        public NodeMusic Tail { get; set; }
        

        public void ForeachFromHead(Action<NodeMusic> action) 
        {
            NodeMusic currentNodeMusic = Tail;
            while (currentNodeMusic != null)
            {
                action(currentNodeMusic);
                currentNodeMusic = currentNodeMusic.Next;
            }
        }
       
        public void ForeachFromTail(Action<NodeMusic> action)
        {
            NodeMusic currentNodeMusic = Tail;
            while (currentNodeMusic != null)
            {
                action(currentNodeMusic);
                currentNodeMusic = currentNodeMusic.Previous;
            }
        }

        public void AddHead(NodeMusic NodeMusic)
        {
            count++;
            if (Head == null)
            {
                Head = NodeMusic;
                Tail = NodeMusic;
                return;
            }
            NodeMusic.Next = Head;
            Head.Previous = NodeMusic;
            Head = NodeMusic;
        }
        public void AddLast(NodeMusic NodeMusic)
        {
            count++;
            if (Tail == null)
            {
                Head = NodeMusic;
                Tail = NodeMusic;
                return;
            }
            NodeMusic.Previous = Tail;
            Tail.Next = NodeMusic;
            Tail = NodeMusic;
        }
        public NodeMusic RemoveHead()
        {
            count--;
            if (Head == null)
            {
                return null;
            }
            var NodeMusicToReturn = Head;

            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            return NodeMusicToReturn;
        }
        public NodeMusic RemoveTail()
        {
            count--;
            if (Tail == null)
            {
                return null;
            }
            var NodeMusicToReturn = Tail;

            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            return NodeMusicToReturn;
        }
    }
}
