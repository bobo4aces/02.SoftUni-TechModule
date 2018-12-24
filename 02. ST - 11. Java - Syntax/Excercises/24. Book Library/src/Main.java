import java.util.ArrayList;
import java.util.Scanner;
import java.util.List;
public class Main {
    public static void main (String[] args) {
        Scanner scanner = new Scanner(System.in);
        int booksCount = scanner.nextInt();
        Library library = new Library();
        ArrayList<Book> books = new ArrayList<>();
        for (int i=0; i<booksCount; i++) {
            String[] input=scanner.nextLine().split(" ");
            Book book = new Book(input[0],input[1],input[2],input[3],input[4], Double.parseDouble(input[5]));
            books.add(book);
        }
        System.out.println(library);
    }
}
