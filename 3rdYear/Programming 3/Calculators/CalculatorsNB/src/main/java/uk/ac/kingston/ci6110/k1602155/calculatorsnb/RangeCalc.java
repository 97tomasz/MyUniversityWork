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
public class RangeCalc {

    public NParameterCalc nRangeCalc = (intArray) -> {
        int max = 0;
        int min = 0;
        for (int position : intArray) {
            if (position > max) {
                max = position;
            }
            if (position < min) {
                min = position;
            }

        }
        return max - min;
    };

}
