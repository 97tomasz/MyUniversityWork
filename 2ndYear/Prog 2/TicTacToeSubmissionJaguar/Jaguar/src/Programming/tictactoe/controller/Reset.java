/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Programming.tictactoe.controller;

import java.awt.event.ActionListener;
import Programming.tictactoe.view.BoardView;
import Programming.tictactoe.model.BoardModel;
import Programming.tictactoe.view.CellView;
import java.awt.event.ActionEvent;

/**
 *
 * @author k1744168
 * @author k1602155
 */
public class Reset implements ActionListener {

    private CellView[][] cell = new CellView[4][4];

    @Override
    public void actionPerformed(ActionEvent e) {
        BoardView.getInstance().updateBoard();
        BoardModel.getInstance().setPlayerTurn('X');
        BoardModel.getInstance().setoCount(0);
        BoardModel.getInstance().setxCount(0);
        BoardModel.getInstance().setGameOver(false);
    }
}
