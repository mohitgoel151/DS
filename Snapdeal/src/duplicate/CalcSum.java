package duplicate;

import java.util.ArrayList;

public class CalcSum {

	public void printSum(int number) {
		
		System.out.println(getNumArray(number));
		
	}
	
	private double getNumArray(int number) {
		ArrayList<Integer> array = new ArrayList<Integer>();
		double sum = 0;
		
		while(number > 0) {
			array.add(number % 10);
			number /= 10;
		}
		
		int size = array.size();

		boolean isOddCount = size%2 == 1 ? true : false;
		int maxPower = size%2 == 1 ? (size/2 ) : (size/2 - 1);
		
		for (int i = 0; i <= maxPower; i++) {
			sum = sum + Math.pow(array.get(i), maxPower - i);
		}
		
		int endValue = maxPower;
		if(isOddCount == true) {
			endValue = maxPower - 1;
		}

		for (int i = 0; i <= endValue; i++) {
			sum = sum + Math.pow(array.get(array.size() - i - 1), maxPower - i);
		}

		return sum;
	}
	
	
	

}
