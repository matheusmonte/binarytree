using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    public class Node
    {
        public Node fatherNode
        {
            get;
            set;
        }
        public Node rightNode
        {
            get;
            set;
        }
        public Node leftNode
        {
            get;
            set;
        }
        public int value
        {
            get;
            set;
        }

        public Node()
        {
            this.leftNode = null;
            this.rightNode = null;
            this.fatherNode = null;
            this.value = 0;
        }

    }
}
