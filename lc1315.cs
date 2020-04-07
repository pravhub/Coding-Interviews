public class Solution {
    int sum =0;
    public int SumEvenGrandparent(TreeNode root) {
        Traverse(root,false,false); //Traverse(6,false,false);
        return sum;
    }
    public void Traverse(TreeNode root,bool parent, bool gparent)
    {
        if(root!=null)
        {
            if(gparent) //grand parent is even valued
               sum+= root.val;
            Traverse(root.left,root.val%2==0,parent); 
            //(7,true,false) , root.val = 6
                  //
                 //     
    //(2,false,true) root.val =7
               //
              // sum =2,        
//(9,true,false) root.val =2
            Traverse(root.right,root.val%2==0,parent);
        }
    }
}
