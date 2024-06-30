class Solution:
    def countDays(self, days: int, meetings: List[List[int]]) -> int:
        meetings.sort()
        n = len(meetings)
        count = meetings[0][0] - 1
        start = meetings[0][0]
        end = meetings[0][1]
        for i in range(1,n):
            if(end >= meetings[i][0]):
                end = max(end, meetings[i][1])
            else:                
                noMeetings = meetings[i][0] - end - 1;
                count += noMeetings;
                start = meetings[i][0];
                end = meetings[i][1];
    
        count += (days - end);
