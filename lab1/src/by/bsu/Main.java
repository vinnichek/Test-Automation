package by.bsu;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Main {

    public static void main(String[] args) {

        Map<Subject, Integer> subjectsPetya = new HashMap<>();
        subjectsPetya.put(Subject.ENGLISH, 2);
        subjectsPetya.put(Subject.MATH, 9);
        subjectsPetya.put(Subject.PHISICS, 3);
        Student student1 = new Student(1, "Petya", subjectsPetya);

        Map<Subject, Integer> subjectsVasya = new HashMap<>();
        subjectsVasya.put(Subject.ENGLISH, 5);
        subjectsVasya.put(Subject.MATH, 7);
        subjectsVasya.put(Subject.PHISICS, 4);
        Student student2 = new Student(2, "Vasya", subjectsVasya);

        Map<Subject, Integer> subjectsIra = new HashMap<>();
        subjectsIra.put(Subject.ENGLISH, 9);
        subjectsIra.put(Subject.MATH, 10);
        subjectsIra.put(Subject.PHISICS, 8);
        Student student3 = new Student(3, "Ira", subjectsIra);

        Map<Subject, Integer> subjectsKatya = new HashMap<>();
        subjectsKatya.put(Subject.ENGLISH, 8);
        subjectsKatya.put(Subject.MATH, 9);
        subjectsKatya.put(Subject.PHISICS, 4);
        Student student4 = new Student(4, "Katya", subjectsKatya);

        Map<Subject, Integer> subjectsMasha = new HashMap<>();
        subjectsMasha.put(Subject.ENGLISH, 5);
        subjectsMasha.put(Subject.MATH, 7);
        subjectsMasha.put(Subject.PHISICS, 4);
        Student student5 = new Student(2, "Masha", subjectsMasha);

        List<Student> studentsOf1Group = new ArrayList<>();
        studentsOf1Group.add(student1);
        studentsOf1Group.add(student2);
        Group group1 = new Group(1,studentsOf1Group);

        List<Student> studentsOf2Group = new ArrayList<>();
        studentsOf1Group.add(student3);
        studentsOf1Group.add(student4);
        studentsOf1Group.add(student5);
        Group group2 = new Group(2,studentsOf2Group);

        List<Group> groupsOfMMF = new ArrayList<>();
        groupsOfMMF.add(group1);
        groupsOfMMF.add(group2);
        Faculty MMF = new Faculty("MMF", groupsOfMMF);

        List<Faculty> facultiesOfBSU = new ArrayList<>();
        facultiesOfBSU.add(MMF);
        University BSU = new University("BSU", facultiesOfBSU);

        System.out.println("Student average mark: ");
        System.out.println(student1.getAverageMark());
        System.out.println("Group average mark for MATH: ");
        System.out.println(group1.getAverageMarkBySubject(Subject.MATH));
        System.out.println("Group average mark: ");
        System.out.println(group1.getAverageMark());
        System.out.println("Faculty average mark: ");
        System.out.println(MMF.getAverageMark());
        System.out.println("University average mark: ");
        System.out.println(BSU.calculateAverageMark());
    }
}
