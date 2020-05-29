public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int n = numCourses;
        int m = prerequisites.Length;
        HashSet<int> courses = new HashSet<int>(); ///courses with out pre-reqs
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        Dictionary<int,List<int>> incoming = new Dictionary<int,List<int>>();
        for(int i=0;i<n;i++)
        {
            courses.Add(i);
            graph.Add(i,new List<int>());
            incoming.Add(i, new List<int>());
        } 
        
        for(int i=0;i<m;i++)
        {
            int course = prerequisites[i][0];
            int prereq = prerequisites[i][1];
            //step-1
            courses.Remove(prereq);
            graph[course].Add(prereq);
            incoming[prereq].Add(course);
        }  
        //now courses hashset will have only the courses which dont have pre-req courses.
        if(courses.Count==0)
            return false;
        List<int> orderOfCourses = new List<int>();
        //step2
        while(courses.Count >0)
        {    
            //Console.WriteLine("course={0}",string.Join(" ",courses));
            int cur = courses.First();
            courses.Remove(cur);
            orderOfCourses.Add(cur);
            List<int> edges = graph[cur].ToList();
            foreach(int e in edges)
            {        
                //remove those edges from graph.
                graph[cur].Remove(e);
                incoming[e].Remove(cur);
                if(incoming[e].Count==0)
                {
                    courses.Add(e);
                }
            }
        }
        return orderOfCourses.Count == n;
    }
}
