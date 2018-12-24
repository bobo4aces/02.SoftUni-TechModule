import java.util.Scanner;
public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String email = scanner.nextLine();
        String text = scanner.nextLine();
        String username = email.substring(0,email.indexOf("@"));
        String censoredEmail = email.replace(username,fillAsterisks(username.length()));
        String result = text.replaceAll("(?i)"+email,censoredEmail);
        System.out.println(result);
    }
    public static String fillAsterisks (int length) {
        String result = "";
        for (int i=0; i<length; i++) {
            result+="*";
        }
        return result;
    }
}
