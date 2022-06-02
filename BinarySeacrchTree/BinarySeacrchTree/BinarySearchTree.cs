using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BinarySearchTree<T> where T : IComparable
    {

        public T KeyValue { get; set; }
        public BinarySearchTree<T> Left { get; set; }
        public BinarySearchTree<T> Right { get; set; }

        public BinarySearchTree(T keyValue)
        {
            this.KeyValue = keyValue;
            this.Left = null;
            this.Right = null;
        }
        int leftCount = 0, rightCount = 0;
        // To insert values in a binary tree
        public void Insert(T data)
        {
            T currentKeyvalue = this.KeyValue;
            if (currentKeyvalue.CompareTo(data) > 0)
            {
                if(this.Left == null)
                {
                    this.Left = new BinarySearchTree<T>(data);

                }
                else
                {
                    this.Left.Insert(data);
                }
                leftCount += 1;
            }
            else
            {
                if (this.Right == null)
                {
                    this.Right = new BinarySearchTree<T>(data);

                }
                else
                {
                    this.Right.Insert(data);
                }
                rightCount += 1;
            }
        }

        public void Display()
        {
            if (this.Left != null)
            {
                
                this.Left.Display();
                
            }
            Console.WriteLine(this.KeyValue.ToString());
            if (this.Right != null)
            {
                
                this.Right.Display();
            }
        }

        public void size()
        {
            Console.WriteLine("Total Left elements are {0} and right elements are {1}",this.leftCount,this.rightCount);
            Console.WriteLine("Total nodes of tree are "+(this.leftCount+this.rightCount+1));
        }
        }
    }

