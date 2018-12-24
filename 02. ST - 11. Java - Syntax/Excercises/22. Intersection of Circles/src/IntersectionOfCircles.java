import java.util.Scanner;
public class IntersectionOfCircles {
    private static boolean isIntersect (Circle firstCircle, Circle secondCircle) {
        double firstPart = Math.pow(firstCircle.getCenter().getX()-secondCircle.getCenter().getX(),2);
        double secondPart = Math.pow(firstCircle.getCenter().getY()-secondCircle.getCenter().getY(),2);
        double distance = Math.sqrt(firstPart+secondPart);
        return distance <=firstCircle.getRadius() + secondCircle.getRadius();
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Circle firstCircle = new Circle(new Point(scanner.nextInt(),scanner.nextInt()),scanner.nextInt());
        Circle secondCircle = new Circle(new Point(scanner.nextInt(),scanner.nextInt()),scanner.nextInt());
        if (isIntersect(firstCircle,secondCircle)) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }

}
