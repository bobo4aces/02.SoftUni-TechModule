import java.util.Scanner;
public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char[] array = scanner.nextLine().toCharArray();
        String result = "";
        for (int i=0; i<20;i++) {
            if (i>=array.length) {
                result+="*";
            } else {
                result+=array[i];
            }
        }
        System.out.println(result);
    }
}
