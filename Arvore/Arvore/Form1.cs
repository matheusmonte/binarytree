using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arvore
{
    public partial class Form1 : Form
    {
        BinaryTree tree;

        public Form1()
        {
            InitializeComponent();
            tree = new BinaryTree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tree.insertValue(Convert.ToInt32(textBox1.Text));
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tree.nodeQuantity.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tree.min.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BinaryTree.Diameter(tree.firstNode).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tree = new BinaryTree();
            string[] lines = System.IO.File.ReadAllLines(@"../tree.txt");
            foreach(string line in lines)
            {
                tree.insertValue(Convert.ToInt32(line));
                richTextBox1.AppendText(line);
            }
        }
    }
}
