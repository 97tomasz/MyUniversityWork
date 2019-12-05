/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet3;


import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.List;
import java.util.stream.Stream;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.MethodSource;

/**
 *
 * @author James
 */
//@Disabled
public class TesterForQuestions1and2 {


    public static Stream<ku.piii2019.worksheet3.PowerCalc> instancesToTest() {

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
    public void testGetListOfIntegers(PowerCalc argInstance) {
        System.out.println("getListOfIntegers");
        int start = 5;
        int finish = 9;
        List<Integer> expResult = Arrays.asList(5, 6, 7, 8, 9);
        List<Integer> result = argInstance.getListOfIntegers(start, finish);
        assertEquals(expResult, result);
    }

    /**
     * Test of printThisList method, of classes implementing the PowerCalc
     * interface
     */
    // @Test
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testPrintThisList(PowerCalc argInstance) {
        System.out.println("printThisList");
        List<Integer> thisList = Arrays.asList(5, 6, 7, 8, 9);

        argInstance.printThisList(thisList);

        // to test this we can use the System.setOut() method
        // contributions welcome! 
    }

    /**
     * Test of getEvenNumbers method, of classes implementing the PowerCalc
     * interface
     */
    // @Test
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetEvenNumbers(PowerCalc argInstance) {
        System.out.println("getEvenNumbers");
        List<Integer> inThisList = Arrays.asList(5, 6, 7, 8, 9);

        List<Integer> expResult = Arrays.asList(6, 8);
        List<Integer> result = argInstance.getEvenNumbers(inThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(5, 6, 7, 8, 9);
        assertEquals(checkOriginalNotChanged, inThisList);

    }

    /**
     * Test of getOddNumbers method, of classes implementing the PowerCalc
     * interface
     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetOddNumbers(PowerCalc argInstance) {
        System.out.println("getOddNumbers");
        List<Integer> inThisList = Arrays.asList(5, 6, 7, 8, 9);

        List<Integer> expResult = Arrays.asList(5, 7, 9);
        List<Integer> result = argInstance.getOddNumbers(inThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(5, 6, 7, 8, 9);
        assertEquals(checkOriginalNotChanged, inThisList);
    }

    /**
     * Test of getNumbersBiggerThan method, of classes implementing the
     * PowerCalc interface
     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetNumbersBiggerThan(PowerCalc argInstance) {
        System.out.println("getNumbersBiggerThan");
        int thisNumber = 7;
        List<Integer> fromThisList = Arrays.asList(5, 6, 7, 8, 9);

        List<Integer> expResult = Arrays.asList(8, 9);
        List<Integer> result = argInstance.getNumbersBiggerThan(thisNumber, fromThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(5, 6, 7, 8, 9);
        assertEquals(checkOriginalNotChanged, fromThisList);

    }

    /**
     * Test of getSum method, of classes implementing the PowerCalc interface
     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetSum(PowerCalc argInstance) {
        System.out.println("getSum");
        List<Integer> inThisList = Arrays.asList(5, 6, 7, 8, 9);

        int expResult = 35;
        int result = argInstance.getSum(inThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(5, 6, 7, 8, 9);
        assertEquals(checkOriginalNotChanged, inThisList);

    }

    /**
     * Test of getRange method, of classes implementing the PowerCalc interface
     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testGetRange(PowerCalc argInstance) {
        System.out.println("getRange");
        List<Integer> inThisList = Arrays.asList(5, 6, 7, 8, 9);

        int expResult = 4;
        int result = argInstance.getRange(inThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(5, 6, 7, 8, 9);
        assertEquals(checkOriginalNotChanged, inThisList);

    }

    /**
     * Test of isPresent method, of classes implementing the PowerCalc interface
     */
    @ParameterizedTest
    @MethodSource("instancesToTest")
    public void testIsPresent(PowerCalc argInstance) {
        System.out.println("isPresent");
        List<Integer> inThisList = Arrays.asList(5, 6, 7, 8, 9);
        int thisNumber = 0;
        boolean expResult = false;
        boolean result = argInstance.isPresent(thisNumber, inThisList);
        assertEquals(expResult, result);
        thisNumber = 9;
        expResult = true;
        result = argInstance.isPresent(thisNumber, inThisList);
        assertEquals(expResult, result);

        List<Integer> checkOriginalNotChanged = Arrays.asList(5, 6, 7, 8, 9);
        assertEquals(checkOriginalNotChanged, inThisList);

    }
}
