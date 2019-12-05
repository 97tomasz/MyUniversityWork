/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package uk.ac.kingston.ci6110.k1602155.calculatorsnb;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

/**
 *
 * @author k1602155
 */
public class CalculatorTest {
    
    
    @org.junit.jupiter.api.BeforeAll
    public static void setUpClass() throws Exception {
    }

    @org.junit.jupiter.api.AfterAll
    public static void tearDownClass() throws Exception {
    }

    @org.junit.jupiter.api.BeforeEach
    public void setUp() throws Exception {
    }

    @org.junit.jupiter.api.AfterEach
    public void tearDown() throws Exception {
    }
    
    

    /**
     * Test of add method, of class Calculator.
     */
    @org.junit.jupiter.api.Test
    public void testAdd() {
        System.out.println("add");
        int a = 2;
        int b = 4;
        Calculator instance = new BrokenPercentageCalculator();
        int expResult = 6;
        int result = instance.add(a, b);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        
    }

    /**
     * Test of divide method, of class Calculator.
     */
    @org.junit.jupiter.api.Test
    public void testDivide() {
        System.out.println("divide");
        int num = 10;
        int denom = 2;
        Calculator instance = new WorkingCalculator();
        int expResult = 5;
        int result = instance.divide(num, denom);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        
    }

    /**
     * Test of getPercentage method, of class Calculator.
     */
    @org.junit.jupiter.api.Test
    public void testGetPercentage() {
        System.out.println("getPercentage");
        float amount = 20.0F;
        float total = 100.0F;
        Calculator instance = new WorkingCalculator();
        int expResult = 20;
        int result = instance.getPercentage(amount, total);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        
    }

    
    
}
