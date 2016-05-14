package blockingqueue;

public interface Queue<T> {
	
	void addItem(T item);
	T getItem() throws InstantiationException, InterruptedException;

}
