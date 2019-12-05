/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet3;


import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Stream;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.MethodSource;

/**
 *
 * @author James
 */
//@Disabled
public class TesterForQuestions3and4 {
//
    public static Stream<PowerCalc> instancesToTest() {

        Collection<PowerCalc> listOfInstances = new ArrayList<>();
        // for Question 1:
        listOfInstances.add(new OldSchoolPowerCalc());
        // for Question 2: 
        listOfInstances.add(new Java8PowerCalc());
        // return listOfInstances;
        return listOfInstances.stream();

    }

    @BeforeAll
    public static void setUpClass() {
    }

    @AfterAll
    public static void tearDownClass() {
    }

    @BeforeEach
    public void setUp() {
    }

    @AfterEach
    public void tearDown() {
    }

    /**
     * Test of getListOfIntegers method, of classes implementing the PowerCalc
     * interface
     *
     * @param argInstance
     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetListOfIntegers(PowerCalc instance) {
        System.out.println("getListOfIntegers");
        int start = 5;
        int finish = 9;
        List<Integer> expResult = Arrays.asList(5,6,7,8,9);
        List<Integer> result = instance.getListOfIntegers(start, finish);
        assertEquals(expResult, result);
    }

//    /**
//     * Test of printThisList method, of class PowerCalc.
//     */
//    @Test
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testPrintThisList(PowerCalc instance) {
        System.out.println("printThisList");
        List<Integer> thisList = Arrays.asList(5,6,7,8,9);

        instance.printThisList(thisList);
        
        // to test this we can use the System.setOut() method
        // contributions welcome! 
        
    }
//
//
//    /**
//     * Test of getRandomNumbers method, of class PowerCalc.
//     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetRandomNumbers(PowerCalc instance) {
        System.out.println("getRandomNumbers");
        int smallest = -10;
        int biggest = -5;
        int thisMany = 100000;

        float expMean = (smallest+biggest)/2.0f;
        List<Integer> rndNum = instance.getRandomNumbers(smallest, biggest, thisMany);
        float mean = rndNum.stream().mapToInt(i -> i.intValue()).sum()/(float)thisMany;

        assertTrue(Math.abs((expMean-mean)/mean)<0.1f);
        assertEquals(rndNum.size(), thisMany);
        
    }

//    /**
//     * Test of removeDuplicates method, of class PowerCalc.
//     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testRemoveDuplicates(PowerCalc instance) {
        System.out.println("removeDuplicates");
        List<Integer> inThisList = Arrays.asList(5,5,7,6,5,7);

        List<Integer> expResult = Arrays.asList(5,7,6);
        List<Integer> result = instance.removeDuplicates(inThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(5,5,7,6,5,7);
        assertEquals(checkOriginalNotChanged, inThisList);

    }

//    /**
//     * Test of getSortedList method, of class PowerCalc.
//     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetSortedList(PowerCalc instance) {
        System.out.println("getSortedList");
        List<Integer> usingThisList = Arrays.asList(5,6,7,4,3);
        List<Integer> checkOriginalNotChanged = Arrays.asList(5,6,7,4,3);

        boolean biggestFirst = false;
        List<Integer> expResult = Arrays.asList(3,4,5,6,7);
        List<Integer> result = instance.getSortedList(usingThisList, biggestFirst);
        assertEquals(expResult, result);
        assertEquals(checkOriginalNotChanged, usingThisList);

        biggestFirst = true;
        expResult = Arrays.asList(7,6,5,4,3);
        result = instance.getSortedList(usingThisList, biggestFirst);
        assertEquals(expResult, result);
        assertEquals(checkOriginalNotChanged, usingThisList);
    }

//    /**
//     * Test of getNumOccurrences method, of class PowerCalc.
//     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetNumOccurrences(PowerCalc instance) {
        System.out.println("getNumOccurrences");
        List<Integer> inThisList = Arrays.asList(7,4,7,6,7);
        int thisNumber = 7;
        int expResult = 3;
        int result = instance.getNumOccurrences(thisNumber, inThisList);
        assertEquals(expResult, result);

        thisNumber = 8;
        expResult = 0;
        result = instance.getNumOccurrences(thisNumber, inThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(7,4,7,6,7);
        assertEquals(checkOriginalNotChanged, inThisList);

    }

//    /**
//     * Test of addTwoLists method, of class PowerCalc.
//     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testAddTwoLists(PowerCalc instance) {
        System.out.println("addTwoLists");
        List<Integer> listA = Arrays.asList(101,102,103,104,105);
        List<Integer> listB = Arrays.asList(1,2,3,4,5);
        List<Integer> emptyList = new ArrayList<>();

        List<Integer> expResult = Arrays.asList(102,104,106,108,110);
        List<Integer> result = instance.addTwoLists(listA, listB);
        assertEquals(expResult, result);

        result = instance.addTwoLists(listA, emptyList);
        assertEquals(listA, result);
        
        result = instance.addTwoLists(emptyList, listB);
        assertEquals(listB, result);

        List<Integer> checkListANotChanged = Arrays.asList(101,102,103,104,105);
        assertEquals(checkListANotChanged, listA);
        
        List<Integer> checkListBNotChanged = Arrays.asList(1,2,3,4,5);
        assertEquals(checkListBNotChanged, listB);
               
    }

//    /**
//     * Test of mapTheseLists method, of class PowerCalc.
//     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testMapTheseLists(PowerCalc instance) {
        System.out.println("mapTheseLists");
        List<Integer> listOfKeys = Arrays.asList(101,102,103,104,105);;
        List<Integer> listOfValues = Arrays.asList(1,2,3,4,5);

        Map<Integer, Integer> expResult = new HashMap()
        {{
            put(101, 1);
            put(102, 2);
            put(103, 3);
            put(104, 4);
            put(105, 5);
        }};
        Map<Integer, Integer> result = instance.mapTheseLists(listOfKeys, listOfValues);
        assertEquals(expResult, result);
        
        
    }
   
}
