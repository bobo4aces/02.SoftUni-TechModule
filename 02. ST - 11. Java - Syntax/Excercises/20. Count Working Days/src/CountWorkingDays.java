import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;
public class CountWorkingDays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String firstDateAsString = scanner.nextLine();
        String secondDateAsString = scanner.nextLine();
        LocalDate firstDate = LocalDate.parse(firstDateAsString, DateTimeFormatter.ofPattern("dd-MM-yyyy"));
        LocalDate secondDate = LocalDate.parse(secondDateAsString, DateTimeFormatter.ofPattern("dd-MM-yyyy"));
        int[] holidayDays = {1,3,1,6,24,6,22,1,24,25,26};
        int[] holidayMonths = {1,3,5,5,5,9,9,11,12,12,12};
        int workingDays=0;
        for (LocalDate i=firstDate; i.isBefore(secondDate.plusDays(1));i=i.plusDays(1)) {
            String currentDayOfWeek = i.getDayOfWeek().toString();
            if (currentDayOfWeek.equals("SATURDAY")||currentDayOfWeek.equals("SUNDAY")) {
                continue;
            }
            int currentDay = i.getDayOfMonth();
            int currentMonth = i.getMonthValue();
            boolean isHoliday = false;
            for (int j=0; j<holidayDays.length;j++) {
                if (currentDay==holidayDays[j] && currentMonth==holidayMonths[j]) {
                    isHoliday=true;
                }
            }
            if (!isHoliday) {
                workingDays++;
            }
        }
        System.out.println(workingDays);
    }

}
