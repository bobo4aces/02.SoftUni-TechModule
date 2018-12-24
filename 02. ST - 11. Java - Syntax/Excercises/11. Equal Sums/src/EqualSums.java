import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] array = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        for (int i=0; i<array.length;i++) {
            int leftSum = 0;
            int rightSum = 0;
            for (int j=0; j<i;j++) {
                leftSum+=array[j];
            }
            for (int k=i+1; k<array.length;k++) {
                rightSum+=array[k];
            }
            if (leftSum==rightSum) {
                System.out.println(i);
                return;
            }
        }
        if (array.length==1) {
            System.out.println(0);
        } else {
            System.out.println("no");
        }


    }
}
