package by.bsu;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by vinnichek on 14.09.17.
 */
public class University {
    private String name;
    private List<Faculty> faculties;
    public double averageMark;

    public University (String name, List<Faculty> faculties){
        this.name = name;
        this.faculties = new ArrayList<>(faculties);
        this.averageMark = calculateAverageMark();
    }

    public double calculateAverageMark(){
        double averageMark = 0;
        for(Faculty faculty: faculties){
            averageMark += faculty.getAverageMark();
        }
        return averageMark;
    }
}
