using System;

namespace src
{
    public class linkList
    {
        public Node Head;
        
        public void Add(int data)
        {
            var toAdd = new Node();
            toAdd.Data = data;
            toAdd.Next = Head; 
            Head = toAdd;

        }
    }
}
