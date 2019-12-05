/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet3;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;
import java.util.stream.IntStream;
import java.util.stream.Stream;

/**
 *
 * @author ku14009
 */
public class Java8PowerCalc implements PowerCalc {

    @Override
    public List<Integer> getListOfIntegers(int start, int finish) {
        Stream<Integer> s = IntStream.range(start, finish + 1).boxed();

        return s.collect(Collectors.toList());
    }

    @Override
    public void printThisList(List<Integer> thisList) {
        thisList.forEach(item -> System.out.println(item));
    }

    @Override
    public List<Integer> getEvenNumbers(List<Integer> inThisList) {
        List<Integer> output = new ArrayList<>();
        inThisList.forEach(item -> {
            if (item % 2 == 0) {
                output.add(item);
            }

        });
        return output;
    }

    @Override
    public List<Integer> getOddNumbers(List<Integer> inThisList) {
        List<Integer> output = new ArrayList<>();
        inThisList.forEach(item -> {
            if (item % 2 == 1) {
                output.add(item);
            }

        });
        return output;
    }

    @Override
    public List<Integer> getNumbersBiggerThan(int thisNumber, List<Integer> fromThisList) {
        List<Integer> output = new ArrayList<>();
        fromThisList.forEach(item -> {
            if (item > thisNumber) {
                output.add(item);
            }

        });
        return output;
    }

    @Override
    public boolean isPresent(int thisNumber, List<Integer> inThisList) {
        List<Integer> output = new ArrayList<>();
        return inThisList.contains(thisNumber);
    }

    @Override
    public int getSum(List<Integer> inThisList) {
        Integer sum = inThisList.stream().collect(Collectors.summingInt(Integer :: intValue));
        return sum;
    }

    @Override
    public int getRange(List<Integer> inThisList) {
        
        inThisList.stream().range();
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public List<Integer> removeDuplicates(List<Integer> inThisList) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public List<Integer> getSortedList(List<Integer> usingThisList, boolean biggestFirst) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int getNumOccurrences(int thisNumber, List<Integer> inThisList) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public List<Integer> addTwoLists(List<Integer> listA, List<Integer> listB) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public Map<Integer, Integer> mapTheseLists(List<Integer> listOfKeys, List<Integer> listOfValues) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public List<Integer> getRandomNumbers(int smallest, int biggest, int thisMany) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
