public class Node {
    public int val;
    public Node next;

    public Node(int val, Node next = null) {
        this.val = val;
        this.next = next;
    }
}

public class LinkedList {
    private Node head = null;
    private Node tail = null;
    private int size = 0;

    public LinkedList() {}

    public int Get(int index) {
        if (index >= size)
            return -1;

        var cur = head;
        while (index-- > 0) cur = cur.next;

        return cur.val;
    }

    public void InsertHead(int val) {
        var node = new Node(val, head);
        head = node;
        tail ??= node;
        size++;
    }

    public void InsertTail(int val) {
        var node = new Node(val);

        if (tail is not null)
            tail.next = node;

        tail = node;
        head ??= node;
        size++;
    }

    public bool Remove(int index) {
        if (index >= size)
            return false;

        if (index == 0) {
            head = head.next;
            size--;
            if(size == 0) tail = null;
            return true;
        }

        var cur = head;
        while (--index > 0) cur = cur.next;

        if (cur.next == tail)
            tail = cur;

        cur.next = cur.next.next;
        size--;
        return true;
    }

    public List<int> GetValues() {
        List<int> l = new(capacity: size);

        for (var cur = head; cur is not null; cur = cur.next){
            l.Add(cur.val);
        }

        return l;
    }
}