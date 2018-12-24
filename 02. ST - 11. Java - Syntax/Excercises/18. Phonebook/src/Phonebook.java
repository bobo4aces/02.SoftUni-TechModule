import java.util.HashMap;
import java.util.Scanner;
public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        HashMap<String,String> phonebook = new HashMap<>();
        String input = scanner.nextLine();
        while (!input.equals("END")) {
            String[] info = input.split(" ");
            String name = info[1];
            if (info[0].equals("A")) {
                String number = info[2];
                phonebook.put(name,number);
            } else {
                if (phonebook.containsKey(name)) {
                    System.out.printf("%s -> %s%n",name,phonebook.get(name));
                } else {
                    System.out.printf("Contact %s does not exist.%n",name);
                }
            }
            input = scanner.nextLine();
        }
    }
}
