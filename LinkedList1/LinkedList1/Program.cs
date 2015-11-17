using System;
using System.Collections;


namespace LinkedList1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			LinkedList<int> list1 = new LinkedList<int> ();
			list1.AddFirst (5);
			list1.AddFirst (4);
			list1.AddFirst (3);
			list1.AddFirst (2);
			list1.AddFirst (1);

			foreach(Node<int> intefer in list1)
				Console.WriteLine (intefer.data);

			LinkedList<Person> Personlist = new LinkedList<Person> ();
			Personlist.AddLast (new Person(1,"person1","location1"));
			Personlist.AddLast (new Person(2,"person2","location2"));
			Personlist.AddLast (new Person(3,"person3","location3"));
			Personlist.AddLast (new Person(4,"person4","location4"));
			Personlist.AddLast (new Person(5,"person5","location5"));

			Console.WriteLine ("\nPersonlist : \n");


			foreach(Node<Person> intefer in Personlist)
				Console.WriteLine ("\nPerson Id : "+intefer.data.Id+"\nPerson Name : "+intefer.data.Name+"\nPerson Location : "+intefer.data.Location+"\n");

			Console.ReadLine ();
		}
	}

	public class Person
	{
		public int Id { get; set;}
		public string Name { get; set;}
		public string Location { get; set;}

		public Person (int theId,string theName, string theLocation)
		{
			Id = theId;
			Location = theLocation;
			Name = theName;
		}
	}

	public class Node<T>
	{
		public Node<T> next;
		public T data;
	}

	public class MyEnumerator<T> : IEnumerator{
		
		Node<T> first_Node;
		Node<T> current_Node;
		bool first_flag = true;

		public MyEnumerator(Node<T> head){
			first_Node = head;
			current_Node = head;
		}

		#region IEnumerator implementation
		public bool MoveNext ()
		{
			if (first_flag) {
				first_flag = false;
				return true;
			}else

			if(current_Node.next != null)
			{
				current_Node = current_Node.next;
				return true;
			}
			else
			{


				return false;
			}
		}
		public void Reset ()
		{
			current_Node = first_Node;
		}
		public object Current {
			get{
				return current_Node;
			}


		}
		#endregion

	}

	public class LinkedList<T> : IEnumerable
	{
		public Node<T> head;
		public Node<T> current_Node;

		#region IEnumerable implementation

		public IEnumerator GetEnumerator ()
		{
			return new MyEnumerator<T> (head);
		}

		#endregion

		// Add a node at the beginning of the list with t as its data value.
		public void AddFirst (T data)
		{ 
			Node<T> toAdd = new Node<T> ();

			toAdd.data = data;
			toAdd.next = head;

			head = toAdd;
			current_Node = head;
		}

		// Add a node at the beginning of the list with t as its data value.
		public void AddLast (T data)
		{
			// this is the first node
			if (head == null) {
				head = new Node<T> ();

				head.data = data;
				head.next = null;
			} else {
				Node<T> toAdd = new Node<T>();
				toAdd.data = data;

				Node<T> now = head;
				while (now.next != null) {
					now = now.next;
				}

				now.next = toAdd;
			}

		}

//		public void Add (T data)
//		{
//			Node<T> toAdd = new Node<T> ();
//			toAdd.data = data;
//
//			if (head == null) {
//				head = toAdd;
//				head.next = null;
//				current_Node = head;
//				return;
//			}
//
//
//			current_Node.next = toAdd;
//			current_Node = current_Node.next;
//		}

		// remove node at last of the list
		public void RemoveLast (){
			if (head != null) {
				Node<T> current = head;
				Node<T> nextNode = current.next;
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