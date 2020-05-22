class Solution {
    public String frequencySort(String s) {      
        Map<Character, Integer> unSortedMap = new HashMap();
        LinkedHashMap<Character, Integer> reverseSortedMap = new LinkedHashMap<>();
        for(Character c : s.toCharArray())
        {
            if(!unSortedMap.containsKey(c))
            {
                unSortedMap.put(c,1);
            }
            else
            {
                unSortedMap.put(c, 1+unSortedMap.get(c));
            }
        }
        unSortedMap.entrySet()
            .stream()
            .sorted(Map.Entry.comparingByValue(Comparator.reverseOrder())) 
            .forEachOrdered(x -> reverseSortedMap.put(x.getKey(), x.getValue()));
        StringBuilder sb= new StringBuilder();

        Set<Character> keys = reverseSortedMap.keySet();
        for(Character key: keys){
            sb.append(key.toString().repeat(reverseSortedMap.get(key)));
        }
        return sb.toString();
    
    }
}
