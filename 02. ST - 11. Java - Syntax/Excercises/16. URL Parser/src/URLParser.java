import java.util.ArrayList;
import java.util.Scanner;
public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        if (input.contains("://")) {
            String[] protocol = input.split("://");
            System.out.printf("[protocol] = \"%s\"%n",protocol[0]);
            String[] serverAndResource = protocol[1].split("/");
            String server = serverAndResource[0];
            System.out.printf("[server] = \"%s\"%n",server);
            if (serverAndResource.length>=2) {
                ArrayList<String> resources = new ArrayList<String>();
                for (int i=1;i<serverAndResource.length;i++) {
                    resources.add(serverAndResource[i]);
                }
                System.out.printf("[resource] = \"%s\"%n",String.join("/",resources));
            } else {
                System.out.println("[resource] = \"\"");
            }

        } else {
            System.out.println("[protocol] = \"\"");
            String[] serverAndResource = input.split("/");
            String server = serverAndResource[0];
            System.out.printf("[server] = \"%s\"%n",server);
            if (serverAndResource.length>=2) {
                ArrayList<String> resources = new ArrayList<String>();
                for (int i=1;i<serverAndResource.length;i++) {
                    resources.add(serverAndResource[i]);
                }
                System.out.printf("[resource] = \"%s\"%n",String.join("/",resources));
            } else {
                System.out.println("[resource] = \"\"");
            }
        }
    }
}
