package utilities;

public class OrderNumberGenerator {
	
	private int orderNumber;
	
	public int getOrderNumber() {
		return ++orderNumber;
	}

}
