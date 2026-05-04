/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        if(intervals == null || intervals.Count == 0) return 0;
        if(intervals.Count == 1) return 1;
        intervals.Sort((a,b) => a.start.CompareTo(b.start));
        var pq = new PriorityQueue<int, int>();
        foreach(var cur in intervals)
        {
            if(pq.Count > 0 && pq.Peek() <= cur.start)
            {
                pq.Dequeue();
            }
            pq.Enqueue(cur.end,cur.end);
        }
        return pq.Count;
    }
}
