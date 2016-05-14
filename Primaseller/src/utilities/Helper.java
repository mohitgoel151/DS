package utilities;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Helper {
	
	private static 	DateFormat df = new SimpleDateFormat("h:mm:ss a");
	
	public static String getCurrentTime() {
	    return df.format(new Date());
	}

}
