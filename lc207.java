class Solution {
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        int n = numCourses;
        int m = prerequisites.length;
        HashSet<Integer> courses = new HashSet<Integer>(); ///courses with out pre-reqs
        Map<Integer,ArrayList<Integer>> graph = new HashMap<Integer,ArrayList<Integer>>();
        Map<Integer,ArrayList<Integer>> incoming = new HashMap<Integer,ArrayList<Integer>>();
        for(int i=0;i<n;i++)
        {
            courses.add(i);
            graph.put(i,new ArrayList<Integer>());
            incoming.put(i, new ArrayList<Integer>());
        } 
        
        for(int i=0;i<m;i++)
        {
            int course = prerequisites[i][0];
            int prereq = prerequisites[i][1];
            //step-1
            courses.remove(prereq);
            graph.get(course).add(prereq);
            incoming.get(prereq).add(course);
        }  
        //now courses hashset will have only the courses which dont have pre-req courses.
        if(courses.size()==0)
            return false;
        List<Integer> orderOfCourses = new ArrayList<Integer>();
        //step2
        while(courses.size() >0)
        {    
            //Console.WriteLine("course={0}",string.Join(" ",courses));
            int cur = courses.iterator().next();
            courses.remove(cur);
            orderOfCourses.add(cur);
            Integer[] edges = graph.get(cur).toArray(new Integer[0]);
            for(int e : edges)
            {        
                //remove those edges from graph.
                graph.get(cur).remove(new Integer(e));
                incoming.get(e).remove(new Integer(cur));
                if(incoming.get(e).size()==0)
                {
                    courses.add(e);
                }
            }
        }
        return orderOfCourses.size() == n;
    }
}
