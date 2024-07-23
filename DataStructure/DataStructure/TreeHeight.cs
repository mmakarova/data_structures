using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    //    Первая строка содержит натуральное число n.Вторая
    //строка содержит n целых чисел parent0
    //, . . . , parentn−1
    //. Для каждого 0 ≤ i ≤ n−1, parenti — родитель вершины i; если parenti = −1,
    //то i является корнем.Гарантируется, что корень ровно один. Гарантируется, что данная последовательность задаёт дерево.
    //input
    //5
    //4 -1 4 1 1
    //output

    //3

    //1
    //3 4
    //  0 2
    public class TreeHeight {
        List<Leaf> leaves = new List<Leaf>();
        Leaf? rootLeaf;
        public TreeHeight(int number, string list) {
            string[] parents = list.Split(' ');
            for (int i = 0; i < number; i++) {
                Leaf l = new Leaf();
                l.Value = i;
                l.ParentValue = Convert.ToInt32(parents[i]);
                l.ChildLeaves = null;
                leaves.Add(l);
            }
            for (int i = 0; i < number; i++) {
                int parentValue = leaves[i].ParentValue;
                if (parentValue != -1) {
                    if (leaves[parentValue].ChildLeaves == null) {
                        leaves[parentValue].ChildLeaves = new List<Leaf>();
                        leaves[parentValue].ChildLeaves.Add(leaves[i]);
                    } else {
                        leaves[parentValue].ChildLeaves.Add(leaves[i]);
                    }
                } else {
                    rootLeaf = leaves[i];
                }
            }
        }

        public int GetHeight() {
            CalculateHeight(rootLeaf);
            return Height;
        }
        private int Height { get; set; }
        private int PrevHeight { get; set; }
        private void CalculateHeight(Leaf leaf, int localHeight =1) {
            if (leaf.ChildLeaves == null) {
                Height = localHeight;
                localHeight = 1;
               // PrevHeight = Height;
            } else {
                for (int i = 0; i < leaf.ChildLeaves.Count; i++) {                    
                    Leaf el = leaf.ChildLeaves[i];
                    CalculateHeight(el,localHeight++);                    
                }
                if (localHeight > Height) Height = localHeight;
            }
        }
    }
    public class Leaf {
        public int Value { get; set; }
        public int ParentValue { get; set; }
        public List<Leaf>? ChildLeaves { get; set; }
    }

}