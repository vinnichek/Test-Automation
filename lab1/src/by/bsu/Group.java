package by.bsu;

import java.util.*;

/**
 * Created by vinnichek on 14.09.17.
 */
public class Group {
    private int number;
    private List<Student> students = Collections.emptyList();
    public double averageMark;
    public Map<Subject, Double> averageMarkBySubject = Collections.emptyMap();

    public Group (int number, List<Student> students){
        this.number = number;
        this.students = new ArrayList<>(students);
        this.averageMark = calculateAverageMark();
        this.averageMarkBySubject = calculateAverageMarkBySubject();
    }

    public double calculateAverageMark() {
        double averageMark = 0;
        if (!students.isEmpty()){
            for(Student student: students){
                averageMark += student.getAverageMark();
            }
            return averageMark / students.size();
        }
        return 0;
    }

    public Map<Subject, Double> calculateAverageMarkBySubject() {
        Map<Subject, Double> averageMarksBySubject = new HashMap<>();
        if (!students.isEmpty()){
            for(Student student: students){
                for(Subject subject: student.getSubjects()){
                    double markBySubject = student.getMarkBySubject(subject);
                    if (averageMarksBySubject.containsKey(subject)){
                        double mark = averageMarksBySubject.get(subject) + markBySubject;
                        averageMarksBySubject.put(subject, mark);
                    } else {
                        averageMarksBySubject.put(subject, markBySubject);
                    }
                }
            }

            for (Subject subject: averageMarksBySubject.keySet()){
                averageMarksBySubject.put(subject, averageMarksBySubject.get(subject) / students.size());
            }
        }
        return  averageMarksBySubject;
    }

    public double getAverageMark() {
        return averageMark;
    }

    public double getAverageMarkBySubject(Subject subject) {
        return averageMarkBySubject.get(subject);
    }
}
