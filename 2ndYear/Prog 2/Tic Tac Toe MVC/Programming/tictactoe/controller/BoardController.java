/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Programming.tictactoe.controller;

import java.awt.event.MouseEvent;
import javax.swing.JOptionPane;
import Programming.tictactoe.view.CellView;
import Programming.tictactoe.view.BoardView;
import Programming.tictactoe.model.BoardModel;
import java.awt.event.MouseListener;

/**
 *
 * @author k1744168
 */
public class BoardController implements MouseListener{
     
        @Override
        public void mousePressed(MouseEvent e) //Mouse click event trigger 
        {
            CellView cell = (CellView)e.getSource();
            BoardModel bm = BoardModel.getInstance();
            BoardView bv = BoardView.getInstance();
            //System.out.println("CELL: " + cell.getPosition() + "PLAYER: "+ bm.getPlayerTurn());   //displays in console, used for testing       
            if(bm.isGameOver())
            {
                 return;
            }
            if(cell.getPosition() == 'X' || cell.getPosition() == 'O') { //if cell is taken, display warning & let the player take another turn
                ////System.out.println("Cell taken");
                bv.setJstatusText("This field is taken. Please choose a different field. "+bm.getPlayerTurn()+" Chose another place");
            }
            else if(cell.getPosition() ==' ' && bm.getPlayerTurn() != ' ') //if cell is empty, and the cell is not equal to X OR O do the following:
            {   
                ////System.out.println("1");
                System.out.println(cell.getPosition());
                
                
                cell.setPosition(bm.getPlayerTurn());//set the new "status" (i.e. X or O) of the cell
                System.out.println("Player " +bm.getPlayerTurn());
                System.out.println("Cell " +cell.getPosition());
                if(bm.playerWon(bm.getPlayerTurn())) // if the new cell causes a game to be won, display following message in jstatus:
                {
                    //System.out.println("2");
                    bv.setJstatusText(bm.getPlayerTurn() + " has won the game! Press RESET to play again.");
                    bm.setPlayerTurn(' ');
                    bm.setGameOver(true);
                    JOptionPane.showMessageDialog(null, " X's has won the game! Press RESET to play again.","WINNER", JOptionPane.INFORMATION_MESSAGE);
                    //cell.setBackground(Color.ORANGE);
                }
                else if(bm.isDraw()) //if the new cell causes a draw, display the following message in jstatus:
                {
                   // //System.out.println("3");
                    bv.setJstatusText("The Game is a draw! Press RESET to play again.");
                    bm.setPlayerTurn(' ');
                    bm.setGameOver(true);
                    JOptionPane.showMessageDialog(null, "The Game is a draw! Press RESET to play again.","DRAW", JOptionPane.INFORMATION_MESSAGE);
                }                                  
                else if (bm.getPlayerTurn() == 'X') //if it is currently X's turn, do the following:
                {
                    if (bm.getxCount() == 1) //if it is X's 2nd turn, change playerTurn to 'O' and reset turn count, otherwise let X take another turn
                    {
                        bm.setPlayerTurn('O');
                        bm.setxCount(0);
                        
                    } 
                    else
                    {
                    bm.setxCount(1);
                    }
                   bv.setJstatusText(bm.getPlayerTurn()+" TURN");
                }
                else if (bm.getPlayerTurn() =='O') //else (if it's O's turn) do the following:
                {
                    if (bm.getoCount() == 1) //if it is O's 2nd turn, change playerTurn to 'X' and reset turn count, otherwise let O take another turn
                    {
                    bm.setPlayerTurn('X');
                    bm.setoCount(0);
                    }
                    else 
                    {
                    bm.setoCount(1);
                    }
                   bv.setJstatusText(bm.getPlayerTurn()+" TURN");
                }
                                         
            else 
            {
                //System.out.println("5");
                while(bm.isGameOver() == true) //if user tries to move after game has been declared finished, move is invalidated and Label displays the text below.
                {
                 bv.setJstatusText(bm.getPlayerTurn()+" Can't move here");
                }
            }
                //System.out.println("4");
                
        }
        }
   
       

    @Override
    public void mouseClicked(MouseEvent e) {
    }

    @Override
    public void mouseReleased(MouseEvent e) {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void mouseEntered(MouseEvent e) {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void mouseExited(MouseEvent e) {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
