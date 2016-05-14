import java.io.IOException;
import java.io.InputStream;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;


public class ExecuteScript {

	public static void main(String[] args) throws IOException, ParseException {
		
		SimpleDateFormat dateFormatter = new SimpleDateFormat("yyyy-MM-dd");
		Date dateToProcess = dateFormatter.parse("2014-12-12");
		Calendar cal = Calendar.getInstance();
		cal.setTime(dateToProcess);

		final Date startTime = cal.getTime();
		cal.add(Calendar.DAY_OF_MONTH, 1);
		final Date endTime = cal.getTime();
		
		System.out.print("sdfsadf");
		
		final String startTimeString = dateFormatter.format(startTime);
		
		//Process p = new ProcessBuilder("myCommand", "myArg").start();
		ProcessBuilder processBuilder = new ProcessBuilder("abcScript.sh", "12", "23");
		System.getProperty("user.dir");
		
		 processBuilder.redirectErrorStream(true); 
	        Process shellProcess = processBuilder.start();
	        InputStream inputStream = shellProcess.getInputStream(); 
	        int consoleDisplay;
	        while((consoleDisplay=inputStream.read())!=-1) {
	            System.out.println(consoleDisplay);
	        }
	        try {
	            inputStream.close();
	        } catch (IOException iOException) { }

	}

}
