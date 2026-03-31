public class MedianFinder {

    public PriorityQueue<int, int> minHeap;
    public PriorityQueue<int, int> maxHeap;

    public MedianFinder() {
        this.minHeap = new PriorityQueue<int, int>();
        this.maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));
    }
    
    public void AddNum(int num) {
        if(minHeap.Count !=  0 && num > minHeap.Peek())
        {
            minHeap.Enqueue(num, num);
        }else{
            maxHeap.Enqueue(num, num);
        }

        //Rebalance

        if(minHeap.Count > maxHeap.Count + 1)
        {
            var val = minHeap.Dequeue();
            maxHeap.Enqueue(val, val);
        }else if(maxHeap.Count > minHeap.Count + 1)
        {
            var val = maxHeap.Dequeue();
            minHeap.Enqueue(val,val);
        }
         
    }
    
    public double FindMedian() {
        if(minHeap.Count > maxHeap.Count)
        {
            return minHeap.Peek();
        }else if(maxHeap.Count >  minHeap.Count)
        {
            return maxHeap.Peek();
        }
        return ((minHeap.Peek() + maxHeap.Peek()) / 2.0);
    }
}
