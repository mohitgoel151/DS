package blockingqueue;

import java.util.ArrayList;

public class BlockingQueue<T> implements Queue<T> {

	private static final int MAX_CAPACITY = 10;
	private volatile int vacanies = MAX_CAPACITY;
	private static final Object lockObj = new Object();
	
	private ArrayList<T> list = new ArrayList<T>();
	
	
	@Override
	public void addItem(T item) {
		
		if(vacanies == 0) {
			try {
				wait();
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		
		synchronized (lockObj) {
			list.add(item);
			vacanies--;
			
			if(MAX_CAPACITY - vacanies == 1) {
				notify();
			}
		}
		

		
		
	}

	@Override
	public T getItem() throws InstantiationException, InterruptedException {
		T item = null;
		if(MAX_CAPACITY - vacanies == 0) {
			//try {
				wait();
			//} 
		}
		
		synchronized (lockObj) {
			item = list.get(0);
			vacanies++;
			
			if(vacanies == 1) {
				notify();
			}
		}
		

		
		return item;
	}

}
