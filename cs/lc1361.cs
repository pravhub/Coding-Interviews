public class Solution {
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild) {
        Queue<int> q = new Queue<int>(); //O(n)
        HashSet<int> hs = new HashSet<int>(); //O(n) visited nodes 
        q.Enqueue(0);
        while(q.Count > 0)
        {
            int i = q.Dequeue();
            if(hs.Contains(i))
            {
                return false;
            }
            hs.Add(i);
            if(leftChild[i] != -1)
            {
                q.Enqueue(leftChild[i]);
            }
            if(rightChild[i] != -1)
            {
                q.Enqueue(rightChild[i]);
            }
        }
        return hs.Count == n;
    }
}
