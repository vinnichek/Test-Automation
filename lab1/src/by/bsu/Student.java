package by.bsu;

import java.util.Collections;
import java.util.HashMap;
import java.util.Map;
import java.util.Set;

/**
 * Created by vinnichek on 14.09.17.
 */
public class Student {
    private int id;
    private String name;
    private Map<Subject, Integer> subjects = Collections.emptyMap();
    public double averageMark;

    public Student(int id, String name, Map<Subject, Integer> subjects){
        this.id = id;
        this.name = name;
        this.subjects = new HashMap<>(subjects);
        this.averageMark = calculateAverageMark();
    }

    public double calculateAverageMark() {
        if (!subjects.isEmpty()) {
            double totalMark = 0;
            for (Integer mark : subjects.values()) {
                totalMark += mark;
            }
            return totalMark / subjects.size();
        }
        return 0;
    }

    public int getMarkBySubject(Subject subject){
        if (subjects.containsKey(subject)) {
            return subjects.get(subject);
        }
        return 0;
    }

    public Set<Subject> getSubjects() {
        return subjects.keySet();
    }

    public double getAverageMark(){
        return averageMark;
    }

}
