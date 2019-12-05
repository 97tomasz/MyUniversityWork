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
public class AbstractCalc {

    public AbstractCalc(TwoParameterCalc myTwoParameterCalc) {
        
        this.myTwoParameterCalc = myTwoParameterCalc;
        AbstractCalc myModuloCalc = new AbstractCalc(
                (a1, b1) -> a1%b1);

            }
        
   

    public AbstractCalc() {
    }

    TwoParameterCalc myTwoParameterCalc; // the field

    int doYourCalc(int a, int b, TwoParameterCalc c) {
            
        return c.getAnswer(a,b);
    }

    int doMyCalc(int a, int b) { //second method
        return myTwoParameterCalc.getAnswer(a, b);
    }

    public static class SubtractCalc {

        public int getAnswer(int a, int b) {

            return b - a;
        }
    }

}
