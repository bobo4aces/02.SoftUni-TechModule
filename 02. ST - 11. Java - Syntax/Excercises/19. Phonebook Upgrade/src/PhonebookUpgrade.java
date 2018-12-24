import java.util.Scanner;
import java.util.TreeMap;
public class PhonebookUpgrade {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String,String> phonebook = new TreeMap<>();
        String input = scanner.nextLine();
        while (!input.equals("END")) {
            String[] info = input.split(" ");

            if (info[0].equals("A")) {
                String name = info[1];
                String number = info[2];
                if (phonebook.containsKey(name)) {
                    phonebook.remove(name);

                }
                phonebook.put(name,number);
            } else if (info[0].equals("S")) {
                String name = info[1];
                if (phonebook.containsKey(name)) {
                    System.out.printf("%s -> %s%n",name,phonebook.get(name));
                } else {
                    System.out.printf("Contact %s does not exist.%n",name);
                }
            } else if (info[0].equals("ListAll")) {
                for (String key : phonebook.keySet()) {
                    System.out.printf("%s -> %s%n",key,phonebook.get(key));
                }
            }
            input = scanner.nextLine();
        }
    }
}
