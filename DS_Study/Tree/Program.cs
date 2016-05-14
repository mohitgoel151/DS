using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTree tree = new CreateTree();

            //1***************** Delete Node *****************
            // DeleteNode delNode = new DeleteNode(tree.Root);
            // ***************** end Delete Node *****************

            //2***************** Tree Height *****************
            //int Height = Helper.CalcHeight(tree.Root);
            // ***************** end Tree Height *****************

            //3***************** Tree Mirror *****************
            //CompareTree cmptree = new CompareTree();
            //bool isSame = cmptree.IsSame(tree.Root, new CreateTree().Root);
            // ***************** end Tree Mirror *****************

            //4***************** Tree Mirror *****************
            //CreateTreeMirror treeMirror = new CreateTreeMirror();
            //Node mirrorRoot = treeMirror.CreateMirror(tree.Root);
            //Helper.PrintInOrder(mirrorRoot);
            //Helper.PrintInOrder(tree.Root);
            // ***************** end Tree Mirror *****************

            //5***************** Closest ansestor *****************
            //Closestansestor aa = new Closestansestor();
            //aa.GetClosestAnsestor(tree.Root);
            //***************** end Closest ansestor *****************

            //6***************** Diameter of Tree *****************
            //Diameter aDia = new Diameter();
            //int IDiameter = aDia.CalcDiameter(tree.Root);
            //Console.WriteLine("Dia = " + IDiameter);
            //***************** end diameter *****************

            //7***************** K distance Nodes *****************
            //KDistanceNodes kNodes = new KDistanceNodes();
            //kNodes.PrintNodes(tree.Root, 10, 4);
            //***************** end K distance Nodes *****************

            //8***************** print zig zag *****************
            //PrintZigZag zigzag = new PrintZigZag(tree.Root);
            //***************** end zig zag *****************

        }


    }
}
