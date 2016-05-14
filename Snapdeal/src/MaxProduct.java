import java.util.ArrayList;


public class MaxProduct {
	
	private int maxPositive = 1;
	private int maxNegative = -1;
	private int maxProduct = 0;
	
	private int[] array = new int[]{1, -1, 5, 10, 8, -5, -20};
	
	public MaxProduct() {

		
	}
	
	public void computeMaxProduct() {
		int tempProduct = 0;
		for (int i = 0; i < array.length; i++) {
			
			if(array[i] > 0) { 
				tempProduct = maxPositive * array[i];
				if(tempProduct > maxProduct) {
					maxProduct = tempProduct; 
				}
				if(array[i] > maxPositive) {
					maxPositive = array[i];
				}
			} else {
				tempProduct = maxNegative * array[i];
				if(tempProduct > maxProduct) {
					maxProduct = tempProduct; 
				}
				if(array[i] < maxNegative) {
					maxNegative = array[i];
				}
			}
			
		}
		
		System.out.println(maxProduct);
		
	}
	

}
