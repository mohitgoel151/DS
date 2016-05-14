package main;
import exceptions.InvalidTimingException;
import exceptions.ParkingNotAvailableException;


public class LauncParking {

	public static void main(String[] args) {
		Parking park = new Parking();
		try {
			park.parkTwoWheeler();
			park.parkTwoWheeler();
		} catch (ParkingNotAvailableException e) {
			System.out.println("my message");
		} catch (InvalidTimingException e) {
			
		} catch (Exception e) {
			// TODO: handle exception
		}

		
		park.twoWheelerExit(new Ticket(11));

	}

}
