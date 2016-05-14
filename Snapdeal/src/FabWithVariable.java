
public class FabWithVariable {
	
	private int p1 = 0;
	private int p2 = 1;
	
	private boolean updateP1 = true;
	
	public FabWithVariable() {
		
	}
	
	public void printNNumbers(int x) {
		
		if(x == 1) { //print first number only
			System.out.println(0);
			return;
		} else if (x == 2) {
			System.out.println(0);
			System.out.println(1);
			return;
		} else {
			System.out.println(0);
			System.out.println(1);
		}
		
		for(int i = 3; i <= x ; i++) {
			int newNum = p1+p2;
			System.out.println(newNum);
			updatePrevious(newNum);
		}
			
		
		
	}
	
	private void updatePrevious(int num) {
		if(updateP1 == true) {
			p1 = num;
			updateP1 = false;
		} else {
			p2 = num;
			updateP1 = true;
		}
	}
	
	
	

}
