package main;

import java.util.Queue;
import java.util.concurrent.ConcurrentLinkedQueue;

import chef.Chef;
import waiter.Waiter;
import model.Order;

public class LaunchBar {
	
	static
	{
		try
		{
			Class.forName("model.Cereal");
			Class.forName("model.Coffee");
			Class.forName("model.Pizza");
			Class.forName("model.Sandwich");
		}
		catch (ClassNotFoundException any)
		{
			any.printStackTrace();
		}
	}

	public static void main(String[] args) {
		
		Queue<Order> queue = new ConcurrentLinkedQueue<Order>();
		
		Waiter waiter = new Waiter(queue);
		Thread waiterThread = new Thread(waiter);
		waiterThread.start();
		
		Chef chef = new Chef(queue);
		Thread chefThread = new Thread(chef);
		chefThread.start();

	}


}
