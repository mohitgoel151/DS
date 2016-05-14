package main;
import java.util.Date;


public class Ticket {
	
	private long time;
	private int slotId;
	
	public int getSlotId() {
		return slotId;
	}

	public Ticket(int id) {
		slotId = id;
		time = System.currentTimeMillis();
	}

}
