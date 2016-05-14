package waiter;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Queue;

import utilities.ItemFactory;
import utilities.OrderNumberGenerator;
import model.MenuItem;
import model.Order;

public class Waiter implements Runnable {
	
	private final Queue<Order> orderQueue;
	private OrderNumberGenerator orderNumbergenerator;
	private BufferedReader bufferedReader;

	public Waiter(Queue<Order> queue) {
		orderQueue = queue;
		orderNumbergenerator = new OrderNumberGenerator();
		bufferedReader = new BufferedReader(new InputStreamReader(System.in));
	}

	@Override
	public void run() {
		
		while(true) {
			
			System.out.print("Enter item id : ");
			
			try {
				String itemId = bufferedReader.readLine();
				MenuItem item = ItemFactory.getFactory().getMenuItem(itemId);
				
				if(item != null) {
					addOrderToQueue(item);
				}

			} catch (IOException e) {
				e.printStackTrace();
			}
		}

	}
	
	private void addOrderToQueue(MenuItem item) {
		
		Order itemOrder = new Order(item, orderNumbergenerator.getOrderNumber());
		System.out.println("OrderNumber: ORD " + itemOrder.getOrderNumber() + " for " + itemOrder.getItem().getItemName() + " has been placed at " + itemOrder.getOrderReceivedTime());
		orderQueue.add(itemOrder);
		
		synchronized (orderQueue) {
			orderQueue.notifyAll();
		}
	}

}
