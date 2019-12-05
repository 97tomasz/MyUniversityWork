/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Random;
import java.util.Set;

/**
 *
 * @author ku14009
 */
public class OldSchoolPowerCalc implements PowerCalc {

    @Override
    public List<Integer> getListOfIntegers(int start, int finish) {
        List<Integer> output = new ArrayList<>();
        for (int i = start; i <= finish; i++) {
            output.add(i);
        }
        return output;
    }

    @Override
    public void printThisList(List<Integer> thisList) {
        for (int n : thisList) {
            System.out.println(n);
        }
    }

    @Override
    public List<Integer> getEvenNumbers(List<Integer> inThisList) {
        List<Integer> output = new ArrayList<>();
        for (int i = 0; i < inThisList.size(); i++) {
            if (inThisList.get(i) % 2 == 0) {
                output.add(inThisList.get(i));
            }
        }
        return output;
    }

    @Override
    public List<Integer> getOddNumbers(List<Integer> inThisList) {
        List<Integer> output = new ArrayList<>();
        for (int i = 0; i < inThisList.size(); i++) {
            if (inThisList.get(i) % 2 == 1) {
                output.add(inThisList.get(i));
            }
        }
        return output;
    }

    @Override
    public List<Integer> getNumbersBiggerThan(int thisNumber, List<Integer> fromThisList) {
        List<Integer> output = new ArrayList<>();
        for (int i = 0; i < fromThisList.size(); i++) {
            if (fromThisList.get(i) > thisNumber) {
                output.add(fromThisList.get(i));
            }
        }
        return output;
    }

    @Override
    public boolean isPresent(int thisNumber, List<Integer> inThisList) {
        for (int i = 0; i < inThisList.size(); i++) {
            if (inThisList.get(i) == thisNumber) {
                return true;
            }
        }
        return false;
    }

    @Override
    public int getSum(List<Integer> inThisList) {
        int output = 0;
        for (int i = 0; i < inThisList.size(); i++) {
            output += inThisList.get(i);
        }
        return output;

    }

    @Override
    public int getRange(List<Integer> inThisList) {
        int max = 0;
        int min = inThisList.get(0);
        List<Integer> output = new ArrayList<>();
        for (int i = 0; i < inThisList.size(); i++) {
            if (inThisList.get(i) < min) {
                min = inThisList.get(i);
            }
            if (inThisList.get(i) > max) {
                max = inThisList.get(i);
            }
        }
        
        return max-min;
    }

    @Override
    public List<Integer> removeDuplicates(List<Integer> inThisList) {
        List<Integer> noDuplicates = new ArrayList();
        for (int n = 0; n < inThisList.size(); n++) {

            if (!noDuplicates.contains(inThisList.get(n))) {
                noDuplicates.add(inThisList.get(n));
            }
        }
        return noDuplicates;
    }

    @Override
    public List<Integer> getSortedList(List<Integer> usingThisList, boolean biggestFirst) {
        List<Integer> sortedList = new ArrayList(usingThisList);
        if (biggestFirst == false) {
            Collections.sort(sortedList);

        } else if (biggestFirst == true) {
            Collections.sort(sortedList, Collections.reverseOrder());

        }
        return sortedList;
    }

    @Override
    public int getNumOccurrences(int thisNumber, List<Integer> inThisList) {
        int count = 0;
        for (int n = 0; n < inThisList.size(); n++) {
            if (inThisList.get(n) == thisNumber) {
                count++;
            }
        }
        return count;
    }

    @Override
    public List<Integer> addTwoLists(List<Integer> listA, List<Integer> listB) {
        List<Integer> combinedList = new ArrayList();
        if (listA.isEmpty()) {
            return listB;
        } else if (listB.isEmpty()) {
            return listA;
        }
        for (int i = 0; i < listB.size(); i++) {
            int combined = listA.get(i) + listB.get(i);
            combinedList.add(combined);
        }
        return combinedList;
    }

    @Override
    public Map<Integer, Integer> mapTheseLists(List<Integer> listOfKeys, List<Integer> listOfValues) {
        Map<Integer, Integer> mappedLists = new HashMap();
        for (int i = 0; i < listOfKeys.size(); i++) {
            mappedLists.put(listOfKeys.get(i), listOfValues.get(i));
        }
        return mappedLists;
    }

    @Override
    public List<Integer> getRandomNumbers(int smallest, int biggest, int thisMany) {
        List<Integer> randomNumbers = new ArrayList();
        //int randNum = 0;
        Random ran = new Random();
        for (int i = 0; i < thisMany; i++) {
            randomNumbers.add(ran.nextInt((biggest - smallest) + 1) + smallest);
        }
        
        return randomNumbers;
    }
}
