import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String letter = scanner.nextLine();
        if (letter.equals("A")||letter.equals("a")||letter.equals("E")||letter.equals("e")
            ||letter.equals("I")||letter.equals("i")||letter.equals("O")||letter.equals("o")
            ||letter.equals("U")||letter.equals("u")) {
            System.out.print("vowel");
        } else if (letter.equals("1")||letter.equals("2")||letter.equals("3")||letter.equals("4")
            ||letter.equals("5")||letter.equals("6")||letter.equals("7")||letter.equals("8")
            ||letter.equals("9")||letter.equals("0")) {
            System.out.print("digit");
        } else {
            System.out.print("other");
        }
    }
}
