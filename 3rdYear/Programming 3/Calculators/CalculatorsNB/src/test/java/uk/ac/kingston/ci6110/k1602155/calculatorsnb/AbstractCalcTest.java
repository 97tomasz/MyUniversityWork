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
public class AbstractCalcTest {
    
    public AbstractCalcTest() {
    }

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
     * Test of doYourCalc method, of class AbstractCalc.
     */
    @org.junit.jupiter.api.Test
    public void testDoYourCalc() {
        
        System.out.println("doYourCalc");
        
        TwoParameterCalc myMultiplyCalc = 
                (int a, int b) -> {return a*b;}; 
        
        int a = 5;
        int b = 4;
        TwoParameterCalc c = new AdditionCalc();
        AbstractCalc instance = new AbstractCalc();
        int expResult = 9;
        int result = instance.doYourCalc(a, b, (int a1, int b1) -> {return a1/b1;}); {
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
    }}

    /**
     * Test of doMyCalc method, of class AbstractCalc.
     */
    @org.junit.jupiter.api.Test
    public void testDoMyCalc() {
        System.out.println("doMyCalc");
        int a = 0;
        int b = 0;
        AbstractCalc instance = new AbstractCalc();
        int expResult = 0;
        int result = instance.doMyCalc(a, b);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
    }
    
}
