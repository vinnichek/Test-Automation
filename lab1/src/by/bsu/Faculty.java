package by.bsu;

import java.util.*;

/**
 * Created by vinnichek on 14.09.17.
 */
public class Faculty {
    private String name;
    private List<Group> groups;
    public double averageMark;

    public Faculty (String name, List<Group> groups){
        this.name = name;
        this.groups = new ArrayList<>(groups);
        this.averageMark = calculateAverageMark();
    }

    public double calculateAverageMark(){
        double averageMark = 0;
        for(Group group: groups){
            averageMark += group.getAverageMark();
        }
        return averageMark;
    }

    public double getAverageMark() {
        return averageMark;
    }
}
