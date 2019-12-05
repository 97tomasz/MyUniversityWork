/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Programming.tictactoe.model;

import Programming.tictactoe.view.BoardView;
import Programming.tictactoe.view.CellView;
import java.util.Arrays;
import javax.swing.JLabel;


/**
 *
 * @author k1744168
 */
public class BoardModel {
    
    private char playerTurn = 'X';
    private boolean gameOver = false;
    private char position = ' '; 
    //private CellView [][]cell = new CellView[4][4];
    private int xCount = 0;
    private int oCount = 0;
   
    
    
    
    private static BoardModel instance = null;
    
    private BoardModel(){
            for(int i =0; i<4; i++)
        {
            for(int j = 0; j<4; j++)
            {
        
        //BoardView.getInstance().getCell(i,j) = new CellView();
           }
        }
         ////System.out.println(Arrays.toString(cell));
    }
    
    public static BoardModel getInstance(){
        if(BoardModel.instance == null) BoardModel.instance = new BoardModel();
        return BoardModel.instance;
    }
    
     public boolean isDraw()
    {
        for(int i =0; i<4; i++)
        {
            for(int j = 0; j<4; j++)
            {
                if(BoardView.getInstance().getCell()[i][j].getPosition() == ' ') 
                {
                    ////System.out.println("isdraw 3");
                    return false;
                }
            }
        }
        return true;
    }
    public boolean playerWon(char position)
    {   ////System.out.println("PlayWon Called");
        // Checks rows for win
        for(int i =0; i<4; i++)
        {
            //cell[i][0] = new CellView();
         System.out.println((BoardView.getInstance().getCell()[i][1].getPosition()));
            ////System.out.println(cell);
            //System.out.println(position);
            //System.out.println(cell[i][0].getPosition());
            if ((BoardView.getInstance().getCell()[i][0].getPosition() == position)&&(BoardView.getInstance().getCell()[i][1].getPosition() == position)&&(BoardView.getInstance().getCell()[i][2].getPosition() == position)&&(BoardView.getInstance().getCell()[i][3].getPosition() == position))
            {
                ////System.out.println("PlayWon Called 1");
                return true;
            }
        }
        // Checks Coloumns for Win
        for (int j =0; j<4; j++)
        {
            if ((BoardView.getInstance().getCell()[0][j].getPosition() == position)&&(BoardView.getInstance().getCell()[1][j].getPosition() == position)&&(BoardView.getInstance().getCell()[2][j].getPosition() == position)&&(BoardView.getInstance().getCell()[3][j].getPosition() == position))
            {
               // //System.out.println("PlayWon Called 2");
                
                return true;
            }
        }
        //Checks diagonally bottom left to top right/top right to bottom left
        if ((BoardView.getInstance().getCell()[0][0].getPosition() == position)&&(BoardView.getInstance().getCell()[1][1].getPosition() == position)&&(BoardView.getInstance().getCell()[2][2].getPosition() == position)&&(BoardView.getInstance().getCell()[3][3].getPosition() == position))
        {
           // //System.out.println("PlayWon Called 3");
            return true;
        }
        //Checks diagonally top left to bottom right/bottom right to top left  
        else if ((BoardView.getInstance().getCell()[0][3].getPosition() == position)&&(BoardView.getInstance().getCell()[1][2].getPosition() == position)&&(BoardView.getInstance().getCell()[2][1].getPosition() == position)&&(BoardView.getInstance().getCell()[3][0].getPosition() == position))
        {
            return true;
        }     
        return false;
    }
    public void restart()
    {
        for(int i =0; i<4; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    BoardView.getInstance().getCell()[i][j] = new CellView();
                    BoardView.getInstance().getCell()[i][j].setPosition(' ');
                }
            }
    }

    /**
     * @return the playerTurn
     */
    public char getPlayerTurn() {
        return playerTurn;
    }

    /**
     * @param playerTurn the playerTurn to set
     */
    public void setPlayerTurn(char playerTurn) {
        this.playerTurn = playerTurn;
    }

    /**
     * @return the position
     */
    
    /**
     * @param position the position to set
     */
    

    /**
     * @return the gameOver
     */
    public boolean isGameOver() {
        return gameOver;
    }

    /**
     * @param gameOver the gameOver to set
     */
    public void setGameOver(boolean gameOver) {
        this.gameOver = gameOver;
    }

    /**
     * @return the xCount
     */
    public int getxCount() {
        return xCount;
    }

    /**
     * @param xCount the xCount to set
     */
    public void setxCount(int xCount) {
        this.xCount = xCount;
    }

    /**
     * @return the oCount
     */
    public int getoCount() {
        return oCount;
    }

    /**
     * @param oCount the oCount to set
     */
    public void setoCount(int oCount) {
        this.oCount = oCount;
    }

   

  

    
  
}
