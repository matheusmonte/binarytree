using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    public class BinaryTree
    {
        public Node firstNode { get; set; }

        public int nodeQuantity { get; set; }

        public string treeVisualization { get; set; }

        public int max { get; set; }

        public int min { get; set; }

        #region private Methods

        private bool isExternNode(Node node)
        {
            return (node.rightNode != null) && (node.leftNode != null);
        }

        private Node createExternNode(Node fatherNode)
        {
            Node _node = new Node();
            _node.fatherNode = fatherNode;
            return _node;
        }

        private  void readNode(Node _node)
        {
            if (isExternNode(_node))
                return;

            treeVisualization = treeVisualization + _node.value.ToString() + "@";
            readNode(_node.rightNode);
            readNode(_node.leftNode);
        }
        #endregion
        public int treeSize()
        {
            return this.nodeQuantity;
        }

        public void insertValue(int value)
        {
            Node aux_node;
            Node fatherNodeaux = new Node();
            if (this.nodeQuantity == 0)
            {
                aux_node = new Node();
                treeVisualization = "center";
                firstNode = aux_node;
                max = value;
                min = value;
            }
            else
            {
                aux_node = firstNode;
              
                while (isExternNode(aux_node)) 
                {
                    treeVisualization = value > aux_node.value ? "right" : "left";
                    aux_node = value > aux_node.value ? aux_node.rightNode : aux_node.leftNode;
                   
                } 
            }
          
            aux_node.value = value;
            aux_node.rightNode = createExternNode(aux_node);
            aux_node.leftNode = createExternNode(aux_node);
            nodeQuantity++;

            max = value > max ? value : max;
            min = value < min ? value : min;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"../tree.txt", true))
            {

                    file.WriteLine(aux_node.value.ToString());
                
            }
        }

        public static int Diameter(Node root)
        {
            if (root == null)
                return 0;

            int rootDiameter = getHeight(root.leftNode) + getHeight(root.rightNode) + 1;
            int leftDiameter = Diameter(root.leftNode);
            int rightDiameter = Diameter(root.rightNode);

            return Math.Max(rootDiameter, Math.Max(leftDiameter, rightDiameter));
        }

        private static int getHeight(Node root)
        {
            if (root == null)
                return 0;

            return Math.Max(getHeight(root.rightNode), getHeight(root.leftNode)) + 1;
        }


    }
}
