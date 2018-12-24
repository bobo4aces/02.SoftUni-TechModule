import java.util.Arrays;
import java.util.Scanner;
public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] array = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int number = 0;
        int frequency = 0;
        int bestFrequency = 0;
        int mostFrequentNumber = 0;
        for (int i=0; i < array.length; i++) {
            for (int j=i+1; j < array.length; j++) {
                if (array[i]==array[j]) {
                    number = array[i];
                    frequency++;
                }
            }
            if (frequency>bestFrequency) {
                bestFrequency=frequency;
                mostFrequentNumber=number;
            }
            frequency=0;
        }
        if (array.length<=3) {
            System.out.println(array[0]);
        } else {
            System.out.println(mostFrequentNumber);
        }
    }
}
