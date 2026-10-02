public class KthLargest {
    private PriorityQueue<int, int> pq = new();
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach (int num in nums) Add(num);
    }

    public int Add(int val) {
        pq.Enqueue(val, val);

        if (pq.Count > k)
            pq.Dequeue();

        return pq.Peek();
    }
}
