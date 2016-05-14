package chef;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Queue;
import utilities.Helper;
import model.Order;

public class Chef implements Runnable {
	
	private final Queue<Order> orderQueue;

	private BufferedWriter writer = null;

	public Chef(Queue<Order> queue) {
		orderQueue = queue;

		try {
			writer = new BufferedWriter(new FileWriter("OrderProcessed.txt"));
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	@Override
	public void run() {
		while (true) {
            prepareOrder();
            try {
                synchronized (orderQueue) {
                	orderQueue.wait();
                }
            } catch (InterruptedException ex) {

            }
        }

	}
	
	private void prepareOrder() {
        while (!orderQueue.isEmpty()) {
            Order order = orderQueue.poll();
            if (order != null) {
               	order.setOrderPrepStartTime(Helper.getCurrentTime());
                
                try {
                	writer.write("Chef : Picked up ORD " + order.getOrderNumber() + " at " + order.getOrderPrepStartTime());
                	writer.newLine();
                	writer.write("Chef : Cooking " + order.getItem().getItemName() + "...");
                	writer.newLine();
                	
					Thread.sleep(order.getItem().getPreparationTime()*1000);
					
					order.setOrderPrepFinishTime(Helper.getCurrentTime());
					writer.write("Chef : Finished making " + order.getItem().getItemName() + " for ORD " + order.getOrderNumber() + " at " + order.getOrderPrepFinishTime());
					writer.newLine();
					
				} catch (Exception e) {
					e.printStackTrace();
				} finally {
			        if (writer != null) {
			            try {
			            	writer.flush();
			            } catch (IOException e) {
			                System.err.println(e);
			            }
			        }
			    }
                
                order.setOrderPrepFinishTime(Helper.getCurrentTime());
              
            }
        }
    }

}
