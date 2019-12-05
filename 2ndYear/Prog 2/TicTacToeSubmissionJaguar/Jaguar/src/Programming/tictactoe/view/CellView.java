/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author k1744168
 */
package Programming.tictactoe.view;

import Programming.tictactoe.controller.BoardController;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import javax.swing.JPanel;
import javax.swing.border.LineBorder;

/**
 *
 * @author k1744168
 * @author k1602155
 */
public class CellView extends JPanel {

    private char position = ' ';

    public CellView() {
        setBorder(new LineBorder(Color.BLACK, 1));
    }

    public void setPosition(char position) //setter for position
    {
        this.position = position;
        repaint();
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        if (position == 'X') {
            Font f = new Font("Arial", Font.BOLD, 50);
            g.setFont(f);
            g.setColor(Color.RED);
            g.drawString("X", 50, 80);
        } else if (position == 'O') {
            Font f = new Font("Arial", Font.BOLD, 50);
            g.setFont(f);
            g.setColor(Color.BLUE);
            g.drawString("O", 50, 80);
        }
    }

    public char getPosition() //getter for position
    {
        return position;
    }

}
