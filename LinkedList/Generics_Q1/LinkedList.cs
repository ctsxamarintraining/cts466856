using System;
using System.Collections;
using System.Threading;


namespace Generics_Q1
{	
	public class LinkedList<T> : IEnumerable,IEnumerator
	{
		public IEnumerator GetEnumerator ()
		{
			
				return new LinkedList<T> ();
			
		}



		public bool MoveNext ()
		{
			if (current.next == null)
				return false;
			else
				return true;

		}

		public void Reset ()
		{
			current = head;
		}

		public object Current {
			get {
				return current;
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
		private Node current;

		public void printAllNodes ()
		{
			Node now = head;
			while (now != null) {
				Console.WriteLine ("\t{0}",now.data);
				now = now.next;
			}
		}

		// Add a node at the beginning of the list with t as its data value.
		public void AddFirst (T data)
		{ 
			Node toAdd = new Node ();

			toAdd.data = data;
			toAdd.next = head;

			head = toAdd;
			current = head;
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

				Node now = head;
				while (now.next != null) {
					now = now.next;
				}

				now.next = toAdd;
			}

		}

		public void Add (T data)
		{
			Node toAdd = new Node ();
			toAdd.data = data;

			if (head == null) {
				head = toAdd;
				head.next = null;
				current = head;
				return;
			}


			current.next = toAdd;
			current = current.next;
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

