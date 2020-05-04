public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck);
        List<int> l = new List<int>();
        int n = deck.Length;
        if(n<=2)
            return deck;
        //decrement n so that it will point to last index in the array;
        n--;
        l.Add(deck[n]);
        n--;
        l.Insert(0,deck[n]);
        n--;
        while(n>=0)
        {
            int bottom = l[l.Count-1];
            l.RemoveAt(l.Count-1);
            l.Insert(0,bottom); // insert at top.
            l.Insert(0,deck[n]); //insert new card at the top from the deck.
            n--;
        }
        return l.ToArray();
    }
}
