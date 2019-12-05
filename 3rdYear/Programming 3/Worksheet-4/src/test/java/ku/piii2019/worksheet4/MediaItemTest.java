/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet4;

import static org.junit.jupiter.api.Assertions.assertTrue;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

/**
 *
 * @author ku14009
 */
@Disabled
public class MediaItemTest {
    
    @Test
    public void testEqualsWrapper() {
        assertTrue(testEquals());        
    }
    @Test
    public void testHashCodeWrapper(){
        assertTrue(testEquals());        
    }

    
    
    public static boolean testEquals()
    {
        MediaItem foo = new MediaItem().setAbsolutePath("foo");
        MediaItem bar = new MediaItem().setAbsolutePath("bar");
        
        if(foo.equals(bar)){
            System.out.println("testEquals: foo does not equal bar!");
            return false;
        }
        bar.setAbsolutePath("foo");
        if(foo.equals(bar)==false){
            System.out.println("testEquals: foo does now equal bar, so .equals() method should return true!");
            return false;
        }
        return true;
    }
    public static boolean testHashCode()
    {
        MediaItem foo = new MediaItem().setAbsolutePath("foo");
        MediaItem bar = new MediaItem().setAbsolutePath("bar");
        
        int fooHashCode = foo.hashCode();
        int barHashCode = bar.hashCode();
        
        if(fooHashCode==barHashCode){
            System.out.println("testHashCode: slightly surprising (but not actually incorrect) for these to have the same hashcode...");
        }
        bar.setAbsolutePath("foo");
        fooHashCode = foo.hashCode();
        barHashCode = bar.hashCode();
        if(fooHashCode!=barHashCode){
            System.out.println("testHashCode: foo and bar hashCodes must be the same...");
            return false;
        }
        return true;
    }
    
}
