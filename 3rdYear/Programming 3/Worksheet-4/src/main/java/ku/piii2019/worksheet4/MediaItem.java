/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet4;
import java.util.Objects;

/**
 *
 * @author James
 */
public class MediaItem {

    private String absolutePath;

    public String getAbsolutePath() {
        return absolutePath;
    }

    public MediaItem setAbsolutePath(String absolutePath) {
        this.absolutePath = absolutePath;
        return this;
    }
    @Override
    public boolean equals(Object s) {
        if (s==null) {
            return false;
        }
        if (s==this) {
            return true;
            
        }else{
            return false;
        }
    
    }
    @Override
    public int hashCode() {
        return Objects.hash(absolutePath);
        
    }

}
