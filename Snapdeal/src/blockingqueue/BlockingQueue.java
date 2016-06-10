package blockingqueue;

import java.util.LinkedList;
import java.util.List;

/**
 * Java implementation using locks
 * 
 * http://docs.oracle.com/javase/6/docs/api/java/util/concurrent/locks/Condition.html
 * 
 * @author mohit
 *
 * @param <T>
 */
public class BlockingQueue<T> implements Queue<T> {

    private static final int MAX_CAPACITY = 10;
    private volatile int vacanies = MAX_CAPACITY;
    private static final Object lockObj = new Object();

    private List<T> list = new LinkedList<T>();

    @Override
    public void addItem(T item) {

        synchronized (lockObj) {

            while (vacanies == 0) {
                try {
                    lockObj.wait();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }

            list.add(item);
            vacanies--;

            if (MAX_CAPACITY - vacanies == 1) {
                lockObj.notifyAll();
            }
        }

    }

    @Override
    public synchronized T getItem() throws InstantiationException, InterruptedException {
        T item = null;

        while (MAX_CAPACITY - vacanies == 0) {
            try {
                lockObj.wait();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        item = list.get(0);
        vacanies++;

        if (vacanies == 1) {
            lockObj.notifyAll();
        }

        return item;
    }

}
