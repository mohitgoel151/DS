
public class Fab {
	
	private int number = 0; 
	
	public Fab() {
	
	}
	
	public void printFab(int x) {
		
		if(x == 0) {
			//System.out.println(0);
			return;
		} else if (x == 1) {
			System.out.println(0);
			return;
		} else if (x == 2) {
			System.out.println(0);
			System.out.println(1);
			return;
		} 

			System.out.println(printFabSeries(x));

		
	}
	
	private int printFabSeries(int n) {
		int num = 0;
		if (n==1) {

			return 0;
		} else if (n == 2) {
			return 1;
		} else {
			num = printFabSeries(n - 1) + printFabSeries(n - 2);
		}
		return num;
		
	}
	
	

}
