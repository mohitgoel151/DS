package duplicate;

import java.util.HashSet;

public class FindDuplicate {

	public void printDuplicate(int[] array) {
		
		if((array == null) || (array.length == 0)) {
			System.out.println("Array is null or empty, So no duplicate number exist");
			return;
		}
		
		System.out.println(getDuplicateNumber(array));
		System.out.println(testGetDulplicateNumber(array));
	}
	
	//Time O(n)
	//Space O(n)
	private int getDuplicateNumber(int[] array) {
		int duplicateNumber = Integer.MIN_VALUE;
		
		int[] tempArray = new int[array.length];
		
		for (int i = 0; i < array.length; i++) {
			int value = array[i];
			
			if(tempArray[value] == 1) {
				duplicateNumber = value;
				break;
			} else {
				tempArray[value] = 1;
			}
		}
		return duplicateNumber;
	}
	
	//Time O(n)
	//Space O(1)
	private int testGetDulplicateNumber(int[] array) {
		
		for (int i = 0; i < array.length; i++) {
			
			int index = array[i];
			
			if(array[index] == 0) {
				return index;
			} else {
				int temp = array[index];
				array[index] = 0;
				array[i] = temp;
				i--;
			}
		}
		
		
		return 0;
	}
	


	//Time O(n)
	//Space O(1)
	private int testGetDulplicateNumber111(int[] array) {
		
		int sum = 0;
		
		for (int i = 0; i < array.length; i++) 
		{
			sum +=array[i];
		}
		
		int total = (99*100)/2;
		
		System.err.println(total - sum);
		
		
		return 0;
	}
	
	

}
