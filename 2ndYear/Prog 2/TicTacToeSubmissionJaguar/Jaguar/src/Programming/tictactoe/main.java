/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Programming.tictactoe;

import Programming.tictactoe.model.BoardModel;
import Programming.tictactoe.view.BoardView;
import java.awt.BorderLayout;
import javax.swing.JFrame;

/**
 *
 * @author k1744168
 * @author k1602155
 */
public class main {

    public static void main(String[] args) {
        JFrame board = BoardView.getInstance();
        BoardModel bm = BoardModel.getInstance();
        BoardView bv = BoardView.getInstance();
        board.setTitle("Tic Tac Toe 4x4");
        board.setSize(700, 600);
        board.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        board.setLocationRelativeTo(null);
        board.setVisible(true);
    }
}
