/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet3;

import java.util.List;
import java.util.Map;
import java.util.Set;

/**
 *
 * @author ku14009
 */
interface PowerCalc {
    // first half
     public List<Integer>   getListOfIntegers   (int start, int finish);     
     public void            printThisList       (List<Integer> thisList);
     public List<Integer>   getEvenNumbers      (List<Integer> inThisList);
     public List<Integer>   getOddNumbers       (List<Integer> inThisList);
     public List<Integer>   getNumbersBiggerThan(int thisNumber,List<Integer> fromThisList);
     public boolean         isPresent           (int thisNumber,List<Integer> inThisList);
     public int             getSum              (List<Integer> inThisList);
     public int             getRange            (List<Integer> inThisList);
     // second half
     public List<Integer>   removeDuplicates    (List <Integer> inThisList);     
     public List<Integer>   getSortedList       (List<Integer> usingThisList,boolean biggestFirst);
     public int             getNumOccurrences   (int thisNumber, List<Integer> inThisList);
     public List<Integer>   addTwoLists         (List<Integer> listA, List<Integer> listB);
     public Map<Integer, Integer> mapTheseLists (List <Integer> listOfKeys,List<Integer> listOfValues);   
     public List<Integer>   getRandomNumbers    (int smallest, int biggest,int thisMany);
}
