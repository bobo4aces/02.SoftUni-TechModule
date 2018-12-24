import java.util.List;

public class Student {
    private String name;
    private List<Double> grades;

    public Student (String name, List<Double> grades) {
        this.name = name;
        this.grades = grades;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public List<Double> getGrades() {
        return grades;
    }

    public void setGrades(List<Double> grades) {
        this.grades = grades;
    }

    public double getAverageGrade() {
        double sum=0;
        int counter = 0;
        for (Double grade: grades) {
            sum+=grade;
            counter++;
        }
        return sum/counter;
    }
}