/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programming2projectv1;
import javax.swing.*;
/**
 *
 * @author k1602155
 * @author k1744168
 */
public class main 
{
    public static void main(String[] args) 
    {
        JFrame board = new BoardFrame();
        board.setTitle("Tic Tac Toe 4x4");
        board.setSize(700, 600);
        board.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        board.setLocationRelativeTo(null);
        board.setVisible(true);
    }
}   
