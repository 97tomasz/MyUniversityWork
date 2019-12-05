/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package uk.ac.kingston.ci6110.k1602155.calculatorsnb;

/**
 *
 * @author k1602155
 */
public class WorkingCalculator implements Calculator {

        public int add(int a, int b) {
            
            return a+b;
        }

        public int divide(int num, int denom) {
            return num/denom;
        }

        public int getPercentage(float amount, float total) {
            int newAmount = (int) (total *(amount/100));
            
            return newAmount;
        }
    }