import java.util.Scanner;
import java.util.Arrays;
import java.util.stream.IntStream;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] array = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int[] bombAndPositions = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int bomb = bombAndPositions[0];
        int positions = bombAndPositions[1];
        int counter = positions+1;
        for (int i=0; i<array.length;i++) {
            if (array[i]==bomb) {
                counter = positions+1;
                for (int j=i; j>=0; j--) {
                    if (counter!=0) {
                        array[j]=0;
                        counter--;
                    }
                }
                counter = positions+1;
                for (int k=i; k<array.length; k++) {
                    if (counter!=0) {
                        array[k]=0;
                        counter--;
                    }
                }
            }

        }
        System.out.println(IntStream.of(array).sum());
    }
}
