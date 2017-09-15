package by.bsu;

/**
 * Created by vinnichek on 14.09.17.
 */
public enum Subject {

    ENGLISH("English"),
    MATH("Math"),
    PHISICS("Phisics");

    private String name;

    Subject(String name){
        this.name = name;
    }

    public String getName(){
        return name;
    }

}
