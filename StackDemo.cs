using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_5
{
  public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T Data)
        {
            this.Data = Data;
            this.Next = null;
        
        }


    }

    class StackDemo<T>
    { 
    
        private Node<T> top;

        public StackDemo()
        {

            top = null;
        }

        public void Push(T Value)
        {
            Node<T> newNode = new Node<T>(Value);
            newNode.Next = top;
            top = newNode;
            Console.WriteLine($"Pushed : {Value} into stack");
        }


        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack UnderFlow! No elements to pop");
                return default;
            }
            T poppedValue = top.Data;
            top = top.Next;
            Console.WriteLine($"Popped :  {poppedValue} from stack");
            return poppedValue;

        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty! No elements to peek.");
                return default;
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }


        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;

            }

            Console.Write("Stack Elements : ");
            Node<T> temp = top;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();

        }


    }



}
