import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] array = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int length = 1;
        int bestLength = 1;
        int position = 0;
        int bestPosition = 0;
        for (int i=1; i<array.length;i++) {
            if (array[i-1]==array[i]) {
                length++;
            } else {
                length=1;
                position=i;
            }
            if (length>bestLength) {
                bestLength = length;
                bestPosition = position;
            }
        }
        for (int i=bestPosition; i<bestPosition+bestLength;i++){
            System.out.print(array[i]+" ");
        }
    }
}
