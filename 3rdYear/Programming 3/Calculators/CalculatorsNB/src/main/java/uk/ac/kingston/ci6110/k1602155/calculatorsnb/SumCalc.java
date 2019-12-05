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
public class SumCalc {

    public NParameterCalc nSumCalc = (intArray) -> {
        int sum = 0;
        for (int position : intArray) {
            sum += position;
        }
        return sum;
    };

}
