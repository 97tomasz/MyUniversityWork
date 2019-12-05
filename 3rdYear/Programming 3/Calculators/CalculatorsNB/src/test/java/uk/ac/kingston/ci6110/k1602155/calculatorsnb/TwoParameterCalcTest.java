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
public class TwoParameterCalcTest {
    
    public TwoParameterCalcTest() {
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
     * Test of getAnswer method, of class TwoParameterCalc.
     */
    @org.junit.jupiter.api.Test
    public void testGetAnswer() {
        System.out.println("getAnswer");
        int a = 0;
        int b = 0;
        TwoParameterCalc instance = new TwoParameterCalcImpl();
        int expResult = 0;
        int result = instance.getAnswer(a, b);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    public class TwoParameterCalcImpl implements TwoParameterCalc {

        public int getAnswer(int a, int b) {
            return 0;
        }
    }
    
}
