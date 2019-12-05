/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programming2projectv1;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.border.LineBorder;
/**
 * @author k1602155
 */
public class BoardFrame extends JFrame
{
    private char playerTurn = 'X';
    private boolean gameOver = false;
    private char position = ' '; 
    private Cell[][]cell = new Cell[4][4];
    private JLabel jstatus = new JLabel("X turn");
    private JButton resetButton = new JButton("Reset");
    //private JPopupMenu jpopup = new JPopupMenu("X's Has Won");
    private int xCount = 0;
    private int oCount = 0;
    public BoardFrame()
    {
        JPanel panel = new JPanel(new GridLayout(4,4,0,0));
        for(int i =0; i<4; i++)
        {
            for(int j = 0; j<4; j++)
            {
                panel.add(cell[i][j] = new Cell());
                cell[i][j].addMouseListener(new PanelListener());
            }
        }
        JPanel bottomPanel = new JPanel(new GridLayout(1,2,0,0));
        JPanel reset = new JPanel(new GridLayout(1,2,0,0));
        panel.setBorder(new LineBorder(Color.BLACK,1));
        jstatus.setBorder(new LineBorder(Color.blue,1));
        add(panel, BorderLayout.CENTER);
        add(bottomPanel, BorderLayout.SOUTH);
        bottomPanel.add(jstatus);
        bottomPanel.add(reset);
        reset.add(resetButton);
        resetButton.addActionListener(e -> 
        {
            for(int i =0; i<4; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    cell[i][j].setPosition(' ');
                }
            }
            playerTurn = 'X';
            oCount = 0;
            xCount = 0;
            gameOver=false;
        });               
    }
    public boolean isDraw()
    {
        for(int i =0; i<4; i++)
        {
            for(int j = 0; j<4; j++)
            {
                if(cell[i][j].getPosition() ==' ') 
                {
                    return false;
                }
            }
        }
        return true;
    }
    public boolean playerWon(char postion)
    {
        // Checks rows for win
        for(int i =0; i<4; i++)
        {
            if ((cell[i][0].getPosition() == postion)&&(cell[i][1].getPosition() == postion)&&(cell[i][2].getPosition() == postion)&&(cell[i][3].getPosition() == postion))
            {
                return true;
            }
        }
        // Checks Coloumns for Win
        for (int j =0; j<4; j++)
        {
            if ((cell[0][j].getPosition() == postion)&&(cell[1][j].getPosition() == postion)&&(cell[2][j].getPosition() == postion)&&(cell[3][j].getPosition() == postion))
            {
                return true;
            }
        }
        //Checks diagonally bottom left to top right/top right to bottom left
        if ((cell[0][0].getPosition() == postion)&&(cell[1][1].getPosition() == postion)&&(cell[2][2].getPosition() == postion)&&(cell[3][3].getPosition() == postion))
        {
            return true;
        }
        //Checks diagonally top left to bottom right/bottom right to top left  
        else if ((cell[0][3].getPosition() == postion)&&(cell[1][2].getPosition() == postion)&&(cell[2][1].getPosition() == postion)&&(cell[3][0].getPosition() == postion))
        {
            return true;
        }     
        return false;
    }
    public char getPlayerTurn() //getter for playerTurn
    {
        return playerTurn;
    }
    public JLabel getJstatus() // getter for jstatus
    {
        return jstatus;
    }
    public void setJstatus(JLabel jstatus) // setter for jstatus
    {
        this.jstatus = jstatus;
    }
    private class PanelListener extends MouseAdapter //Panel event listener
    {     
        @Override
        public void mousePressed(MouseEvent e) //Mouse click event trigger 
        {
            Cell cell = (Cell)e.getSource();
            System.out.println("CELL: " + cell.getPosition() + "PLAYER: "+ playerTurn);   //displays in console, used for testing       
            if(gameOver)
            {
                return;
            }
            if(cell.getPosition() !=' ') { //if cell is taken, display warning & let the player take another turn
                jstatus.setText("This field is taken. Please choose a different field. " +playerTurn+ "'s turn.");
            }
            else if(cell.getPosition() ==' ' && playerTurn != ' ') //if cell is empty, and the cell is not equal to X OR O do the following:
            {                             
                cell.setPosition(playerTurn); //set the new "status" (i.e. X or O) of the cell                         
                if(playerWon(playerTurn))// if the new cell causes a game to be won, display following message in jstatus:
                {
                    jstatus.setText(playerTurn + " has won the game! Press RESET to play again.");
                    playerTurn = ' ';
                    gameOver = true;
                    JOptionPane.showMessageDialog(null, " X's has won the game! Press RESET to play again.","WINNER", JOptionPane.INFORMATION_MESSAGE);
                    //cell.setBackground(Color.ORANGE);
                }
                else if(isDraw()) //if the new cell causes a draw, display the following message in jstatus:
                {
                    jstatus.setText("The Game is a draw! Press RESET to play again.");
                    playerTurn =' ';
                    gameOver = true;
                    JOptionPane.showMessageDialog(null, "The Game is a draw! Press RESET to play again.","DRAW", JOptionPane.INFORMATION_MESSAGE);
                }                                  
                else if (playerTurn == 'X') //if it is currently X's turn, do the following:
                {
                    if (xCount == 1) //if it is X's 2nd turn, change playerTurn to 'O' and reset turn count, otherwise let X take another turn
                    {
                        playerTurn = 'O';
                        xCount = 0;
                    } 
                    else
                    {
                    xCount = 1;
                    }
                    jstatus.setText(playerTurn+ "'s turn.");
                }
                else //else (if it's O's turn) do the following:
                {
                    if (oCount==1) //if it is O's 2nd turn, change playerTurn to 'X' and reset turn count, otherwise let O take another turn
                    {
                    playerTurn = 'X';
                    oCount = 0;
                    }
                    else 
                    {
                    oCount =1;    
                    }
                    jstatus.setText(playerTurn+ "'s turn.");
                }
            }                             
            else 
            {
                while(gameOver == true) //if user tries to move after game has been declared finished, move is invalidated and Label displays the text below.
                {
                jstatus.setText(playerTurn+ " you can't move anymore, game is over; Press RESET to play again");
                }
            }                                           
        }

       
    }
}
     

 

