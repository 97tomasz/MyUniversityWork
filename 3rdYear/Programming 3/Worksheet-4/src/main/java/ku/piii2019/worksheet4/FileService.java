/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet4;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;
import java.util.Set;
import java.util.stream.Stream;

/**
 *
 * @author James
 */
public interface FileService {
    Set<MediaItem>          getAllMediaItems    (String rootFolder);
    Set<Set<MediaItem>>     getDuplicates       (Set<MediaItem> allMediaItems);
    Set<MediaItem>          getItemsToRemove    (Set<Set<MediaItem>> duplicates);
    boolean                 removeFiles         (Set<MediaItem> listToRemove);
    
}
