import java.util.LinkedList;

public class LabStack<T> {
    private LinkedList<T> list;

    public LabStack() {
        list = new LinkedList<T>();
    }

    public boolean empty() {
        return list.isEmpty();
    }

    public T peek() throws EmptyStackException {
        if (list.isEmpty()) {
            throw new EmptyStackException();
        }
        return list.peek();
    }

    public T pop() throws EmptyStackException {
        if (list.isEmpty()) {
            throw new EmptyStackException();
        }
        return list.pop();
    }

    public void push(T element) {
        list.push(element);
    }

    public int size() {
        return list.size();
    }

    public void makeEmpty() {
        list.clear();
    }

    public String toString() {
        return list.toString();
    }
}