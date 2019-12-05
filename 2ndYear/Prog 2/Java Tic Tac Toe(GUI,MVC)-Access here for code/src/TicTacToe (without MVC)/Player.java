/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programming2projectv1;
/**
 *
 * @author k1602155
 */
public class Player 
{
    private String name;
    private int playerWinCount;
    /*public String getName(){
    /    return name;
    /}
    /public void setName(String newName) {
        this.name = newName;
    }*/
    public Player(String pName, int pWC) 
    {
        this.name = pName;
        this.playerWinCount = pWC;
    }
}
