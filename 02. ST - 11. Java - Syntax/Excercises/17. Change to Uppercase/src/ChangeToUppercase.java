import java.util.Arrays;
import java.util.Scanner;
public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        while (text.contains("<upcase>")) {
            int firstOpenUpcase = text.indexOf("<upcase>");
            int firstCloseUpcase = text.indexOf("</upcase>");
            String textToReplace = text.substring(firstOpenUpcase,firstCloseUpcase+9);
            String replacement = textToReplace.replaceFirst("<upcase>","").replaceFirst("</upcase>","").toUpperCase();
            text=text.replaceFirst(textToReplace,replacement);
        }
        System.out.println(text);
    }

}
