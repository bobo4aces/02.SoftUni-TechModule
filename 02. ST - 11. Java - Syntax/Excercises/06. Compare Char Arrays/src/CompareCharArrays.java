import java.util.Scanner;
public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] firstCharArray = scanner.nextLine().split(" ");
        String[] secondCharArray = scanner.nextLine().split(" ");
        int min=Math.min(firstCharArray.length,secondCharArray.length);
        for (int i=0; i<min;i++) {
            if (firstCharArray[i].compareTo(secondCharArray[i])>0) {
                System.out.println(String.join("", secondCharArray));
                System.out.println(String.join("", firstCharArray));
                return;
            }
        }
        if (firstCharArray.length>secondCharArray.length) {
            System.out.println(String.join("", secondCharArray));
            System.out.println(String.join("", firstCharArray));
        } else {
            System.out.println(String.join("", firstCharArray));
            System.out.println(String.join("", secondCharArray));
        }
    }
}
