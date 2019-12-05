/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet4;

import java.io.IOException;
import java.nio.file.FileVisitResult;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.SimpleFileVisitor;
import java.nio.file.attribute.BasicFileAttributes;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
//regex = .*\.ccf$
/**
 *
 * @author James
 */
public class FileServiceImpl implements FileService {

    @Override
    public Set<MediaItem> getAllMediaItems(String rootFolder) {
        try (Stream<Path> stream = Files.walk(rootFolder.toPath())) {
            //stream.forEach(mediaFiles -> {
//
//                try {
//                    String pattern = (".*\.ccf$");
//                    if ()
            List<String> result = stream.map(mediaFiles -> mediaFiles.toString())
                    .filter(f -> f.endsWith(".mp3")).collect(Collectors.toList());

                } catch (Exception e) {
                    e.printStackTrace();
                
            };
        
        //catch(IOException e){
        //    e.printStackTrace();
        }
}
   
    

    @Override
    public Set<Set<MediaItem>> getDuplicates(Set<MediaItem> allMediaItems) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public Set<MediaItem> getItemsToRemove(Set<Set<MediaItem>> duplicates) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public boolean removeFiles(Set<MediaItem> listToRemove) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
