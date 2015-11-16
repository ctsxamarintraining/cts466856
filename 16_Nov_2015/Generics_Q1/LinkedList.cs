using System;
using System.Collections;


namespace Generics_Q1
{

	public class MyEnumerable<T> : IEnumerable
	{
		public IEnumerator GetEnumerator ()
		{
			return new LinkedList<T> ();
		}
	}

	public class LinkedList<T> :IEnumerator //IEnumerable
	{
		// First item index
		// Current Item
		
		//public IEnumerator GetEnumerator ()
		//{
		//	new PersonEnumerator(this);
		//}
		public bool MoveNext ()
		{
			throw new NotImplementedException ();
		}

		public void Reset ()
		{
			throw new NotImplementedException ();
		}

		public object Current {
			get {
				throw new NotImplementedException ();
			}
		}

		private class Node
		{
			// Each node has a reference to the next node in the list.
			public Node next;
			// Each node holds data of type T.
			public T data;
		}

		// The list is initially empty.
		private Node head;

		public void printAllNodes ()
		{
			Node current = head;
			while (current != null) {
				Console.WriteLine ("\t{0}",current.data);
				current = current.next;
			}
		}

		// Add a node at the beginning of the list with t as its data value.
		public void AddFirst (T data)
		{ 
			Node toAdd = new Node ();

			toAdd.data = data;
			toAdd.next = head;

			head = toAdd;
		}

		// Add a node at the beginning of the list with t as its data value.
		public void AddLast (T data)
		{
			// this is the first node
			if (head == null) {
				head = new Node ();

				head.data = data;
				head.next = null;
			} else {
				Node toAdd = new Node ();
				toAdd.data = data;

				Node current = head;
				while (current.next != null) {
					current = current.next;
				}

				current.next = toAdd;
			}
		}

		// remove node at last of the list
		public void RemoveLast (){
			if (head != null) {
				Node current = head;
				Node nextNode = current.next;
				while (nextNode != null) {
					
					if (nextNode.next == null) {
						current.next = null;
						return;
					}
					current = nextNode;
					nextNode = nextNode.next;

				}
			}
			else
			throw new System.ArgumentException("List is empty cannot remove any object");
		}

		// remove node at begining of the list
		public void RemoveFirst (){
			if (head != null) {
				head = head.next;
			}
			else
			throw new System.ArgumentException("List is empty cannot remove any object");

		}


	}
}

