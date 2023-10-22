class Solution(object):
    def minPartitions(self, n):
        """
        :type n: str
        :rtype: int
        
        27346209830709182346
        answer is 9.
        
        111 answer is 1
        
        Example:
        1 +1 +1 +1...1 = 32 - 1s -- one way = output = 32
        10 + 1+1+1..1 = 10 + 22 1s = 32 - second way output = 23
        10+10+ 12 1s = 32 - another way = 14
        
        10 + 11 + 11 = 32 = output = 3
        
        22+10
        
         32
        -11
        21. -- count=1
        -11 
        10. -- count = 2
        -10 
        0 -- count = 3
        
        15
        -11 - count =1
        4
        -1
        3. - count =2
        -1 
        2. - count = 3
        -1 
        1 - count =4
        -1 
        0 - count = 5
        11 +1+1+1+1 
        
        3 -> 0? 1+1+1
        """
        m='0';
        for c in n:
            m = max(m, c);
        return int(m);
