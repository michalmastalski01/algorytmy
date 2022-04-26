using System;
using System.Collections;
using System.Collections.Generic;

namespace lab7
{
    class TreeNode<T> 
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
    }

    record Student(string name, int ects);
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 9, 1, 7, 5, 2, 8, 3 };
            Array.Sort(arr);
            int index = Array.BinarySearch(arr, 7);
            Console.WriteLine(index);
            Student[] students =
            {
                new Student("Jakub", 56),
                new Student("Ewa", 23),
                new Student("Michał", 43),
                new Student("Kacper", 87),
                new Student("Anna", 53)
            };
            Array.Sort(students, (a, b) =>
            {
                return a.ects.CompareTo(b.ects);
            });
            int result = Array.BinarySearch(students, new Student("Anna", 53), new StudentComparer());
            Console.WriteLine(result);


            TreeNode<int> root = new TreeNode<int>() { Value = 16 };
            root.Left = new TreeNode<int>() { Value = 8 };
            root.Right = new TreeNode<int>() { Value = 20 };
            root.Left.Left = new TreeNode<int>() { Value = 5 };
            root.Left.Right = new TreeNode<int>() { Value = 11 };
            root.Right.Left = new TreeNode<int>() { Value = 18 };
            root.Right.Right = new TreeNode<int>() { Value = 23 };

            BST<int> tree = new BST<int>() { Root = root };
            Console.WriteLine(tree.Contains(5));
            Console.WriteLine(tree.Insert(9));
            Console.WriteLine(tree.Contains(9));
        }
    }
    class BST<T> where T: IComparable<T>
    {
        public TreeNode<T> Root { get; init; }
        
        public bool Contains(T value)
        {
            return Search(Root, value);
        }
        
        private bool Search(TreeNode<T> node, T value)
        {
            if(node == null)
            {
                return false;
            }
            int compare = value.CompareTo(node.Value);
            
            if(compare == 0)
            {
                return true;
            }
            if(compare < 0)
            {
                return Search(node.Left, value);
            } 
            else
            {
                return Search(node.Right, value);
            }
        }
        public bool Insert(T value)
        {
            return InsertNode(Root, value);
        }
        private bool InsertNode(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                node = new TreeNode<T>();
                node.Value = value;
                return true;
            }

            int compare = value.CompareTo(node.Value);

            if (compare == 0)
            {
                return false;
            }
            if (compare < 0)
            {
                return InsertNode(node.Left, value);
            }
            else
            {
                return InsertNode(node.Right, value);
            }
        }
    }

    class StudentComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Student a = (Student)x;
            Student b = (Student)y;
            return a.ects.CompareTo(b.ects);
        }
    }
}
