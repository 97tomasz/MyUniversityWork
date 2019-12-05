/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Programming.tictactoe.view;

import Programming.tictactoe.controller.BoardController;
import Programming.tictactoe.controller.Reset;
import Programming.tictactoe.model.BoardModel;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.Arrays;
import javax.swing.border.LineBorder;

/**
 *
 * @author k1744168
 * @author k1602155
 */
public class BoardView extends JFrame {

    private CellView[][] cell = new CellView[4][4];
    private JLabel jstatus = new JLabel("X turn");
    private JButton resetButton = new JButton("Reset");
    private BoardController cellListener = new BoardController();
    private Reset restart = new Reset();
    public static BoardView instance = null;
    JPanel panel = new JPanel(new GridLayout(4, 4, 0, 0));

    public static BoardView getInstance() {
        if (instance == null) {
            instance = new BoardView();
        }
        return instance;
    }

    private BoardView() {
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                panel.add(cell[i][j] = new CellView());
                cell[i][j].addMouseListener(cellListener);
            }
        }
        JPanel bottomPanel = new JPanel(new GridLayout(1, 2, 0, 0));
        JPanel reset = new JPanel(new GridLayout(1, 2, 0, 0));
        panel.setBorder(new LineBorder(Color.BLACK, 1));
        jstatus.setBorder(new LineBorder(Color.blue, 1));
        add(panel, BorderLayout.CENTER);
        add(bottomPanel, BorderLayout.SOUTH);
        bottomPanel.add(jstatus);
        bottomPanel.add(reset);
        reset.add(resetButton);
        resetButton.addActionListener(restart);
    }

    /**
     * @param text
     * @param jstatus the jstatus to set
     */
    public void setJstatusText(String text) {
        this.jstatus.setText(text);
    }

    /**
     * @return the cell
     */
    public void updateBoard() {

        panel.removeAll();
        panel.updateUI();
        setJstatusText("");
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                panel.add(getCell()[i][j] = new CellView());
                getCell()[i][j].addMouseListener(cellListener);
            }
        }

    }

    /**
     * @return the cell
     */
    public CellView[][] getCell() {
        return cell;
    }

    /**
     * @param cell the cell to set
     */
    public void setCell(CellView[][] cell) {
        this.cell = cell;
    }

}
