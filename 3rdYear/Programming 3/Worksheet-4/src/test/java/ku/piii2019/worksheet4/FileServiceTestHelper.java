/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet4;

import ku.piii2019.worksheet4.MediaItem;
import java.io.File;
import java.io.IOException;
import java.nio.file.FileVisitResult;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.SimpleFileVisitor;
import java.nio.file.attribute.BasicFileAttributes;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.stream.Stream;

/**
 *
 * @author James
 */
public class FileServiceTestHelper {

    public static String PERMANENT_TEST_INPUT_FOLDER = "test-music-files";
    public static String TEMP_TEST_INPUT_FOLDER = "tmp-music-files";

    public static void copyFolder(Path commonFolder, 
                                  File srcFolder, 
                                  File destFolder)  {
        try {
            Files.createDirectory(Paths.get(destFolder.toString()));
        }
        catch(IOException e){
            e.printStackTrace();
        }
       
        try (Stream<Path> stream = Files.walk(srcFolder.toPath())) {
            stream.forEach(sourcePath -> {

                try {
                    Path absSourcePath = Paths.get(commonFolder.toString(), 
                                                   sourcePath.toString());
                    Path absDestPath = Paths.get(commonFolder.toString(),
                                                 destFolder.toString(), sourcePath.toString());
                    Files.copy(absSourcePath,absDestPath);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            });
        }
        catch(IOException e){
            e.printStackTrace();
        }

    }
    public static boolean deleteFolderWithFileVisitor(String rootFolder) {
        Path p = Paths.get(rootFolder);
        if (!p.isAbsolute()) {
            Path currentWorkingFolder = Paths.get("").toAbsolutePath();
            rootFolder = Paths.get(currentWorkingFolder.toString(), rootFolder).toString();
        }

        SimpleFileVisitor myDeleteVisitor = new SimpleFileVisitor<Path>() {
            @Override
            public FileVisitResult visitFile(Path file, BasicFileAttributes attrs) throws IOException {
                    Files.delete(file);
                return FileVisitResult.CONTINUE;
            }
            @Override
            public FileVisitResult postVisitDirectory(Path dir, IOException exc) {
                    try {
                        Files.delete(dir);
                    }
                    catch (IOException e) {
                        e.printStackTrace();                        
                    }
                return FileVisitResult.CONTINUE;               
            }
        };
        try {
            Files.walkFileTree(Paths.get(rootFolder), myDeleteVisitor);
        } catch (IOException ex) {
            ex.printStackTrace();
            return false;
        }
        return true;
    }
    public static boolean deleteFolderRecursively(File dir) {

        if (dir.isDirectory()) {
            File[] children = dir.listFiles();
            for (int i = 0; i < children.length; i++) {
                boolean success = deleteFolderRecursively(children[i]);
                if (!success) {
                    return false;
                }
                try {
                    Files.delete(Paths.get(children[i].toString()));
                }
                catch (IOException e){
                    
                }
            }
        }
        try {
            Files.delete(Paths.get(dir.toString()));
        }
        catch (IOException e) {
            
        }
        return true;
    }

    static void print1(Set<Set<MediaItem>> result) {
        for(Set<MediaItem> s : result) {
            for (MediaItem m : s) {
                System.out.println(m.getAbsolutePath());
            }
        }
    }
    static void print2(Set<MediaItem> result) {
        for(MediaItem s : result) {
                System.out.println(s.getAbsolutePath());
            
        }
    }

    static int getNumLikeThis(MediaItem thisItem, Set<MediaItem> otherItems) {
        Path p = Paths.get(thisItem.getAbsolutePath());
        String filenameToSearchFor = p.getFileName().toString();

        int num=0;
        for(MediaItem m : otherItems) {
            Path otherP = Paths.get(m.getAbsolutePath());
            String otherFilename = otherP.getFileName().toString();
            if(filenameToSearchFor.equals(otherFilename)) {
//                System.out.println("same: " + filenameToSearchFor + " is the same as " + otherFilename);
                num++;
            }
            else {
//                System.out.println("different: " + filenameToSearchFor + 
//                        " is NOT the same as " + otherFilename);                
            }
        }
        return num;    
    }

    static boolean filesExist(Set<MediaItem> allMediaItems) {
        for(MediaItem m : allMediaItems) {
            if(Files.exists(Paths.get(m.getAbsolutePath()))==false)
                return false;
        }
        return true;
    }

    static boolean filesDontExist(Set<MediaItem> allDuplicates) {
        for(MediaItem m : allDuplicates){
            if(Files.exists(Paths.get(m.getAbsolutePath())))
                return false;
        }
        return true;    
    }

    public static Set<MediaItem> getAllMediaItems(String currentWorkingFolder) {
        List<String> relativeFilenames = new ArrayList<String>();
        relativeFilenames.add("collection-A" + 
                              File.separator + "Anshlavs - Second Trip - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + 
                              "DARKPOP BAND ANGELIQUE - PERFECT WORLD (AMBIENT) - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "Gem Reflection - Tubeman - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "IX - la chichonera - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "Omnibrain - Neverending - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "After Many Days" + 
                              File.separator + "Cannibal Eyes - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "Freak Fandango Orchestra - No means no - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "Freak Fandango Orchestra" + 
                              File.separator + "Freak Fandango Orchestra - No means no - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "Orxata Sound System" + 
                              File.separator + "als nous amos - clip.mp3");
        relativeFilenames.add("collection-A" + 
                              File.separator + "Orxata Sound System" + 
                              File.separator + "fuster meets guevara - clip.mp3");
        relativeFilenames.add("collection-B" + 
                              File.separator + "Freak Fandango Orchestra - No means no - clip.mp3");
        relativeFilenames.add("collection-B" + 
                              File.separator + "Red Horizons - Shadows of Promises - clip.mp3");
        relativeFilenames.add("collection-B" + 
                              File.separator + "Richard Stallman - Guantanamero - clip.mp3");
        relativeFilenames.add("collection-B" + 
                              File.separator + "Stellardrone - Nightscape - clip.mp3");
        relativeFilenames.add("collection-B" + 
                              File.separator + "Wortrausch - Sommerzeit (Doppelzeit) - (Live) - clip.mp3");
        relativeFilenames.add("collection-B" + 
                              File.separator + "After Many Days" + 
                              File.separator + "I Could Burn Your House - clip.mp3");
        relativeFilenames.add("collection-B" + 
                              File.separator + "Orxata Sound System" + 
                              File.separator + "fuster meets guevara - clip.mp3");
        Set<MediaItem> output = new HashSet<MediaItem>();
        for (String filename : relativeFilenames) {
            String abs = Paths.get(currentWorkingFolder, 
                                   TEMP_TEST_INPUT_FOLDER, 
                                   PERMANENT_TEST_INPUT_FOLDER, 
                                   filename).toString();
            output.add(new MediaItem().setAbsolutePath(abs));
        }
        return output;
    }
    public static Set<Set<MediaItem>> getDuplicates(String currentWorkingFolder) {
        List<String> firstDuplicateFilenames = new ArrayList<>();
        firstDuplicateFilenames.add("collection-A" + 
                                    File.separator + "Freak Fandango Orchestra" + 
                                    File.separator + "Freak Fandango Orchestra - No means no - clip.mp3");
        firstDuplicateFilenames.add("collection-A" + 
                                    File.separator + "Freak Fandango Orchestra - No means no - clip.mp3");
        firstDuplicateFilenames.add("collection-B" + 
                                    File.separator + "Freak Fandango Orchestra - No means no - clip.mp3");
        List<String> secondDuplicateFilenames = new ArrayList<>();
        secondDuplicateFilenames.add("collection-A" + 
                                    File.separator + "Orxata Sound System" + 
                                    File.separator + "fuster meets guevara - clip.mp3");
        secondDuplicateFilenames.add("collection-B" + 
                                    File.separator + "Orxata Sound System" + 
                                    File.separator + "fuster meets guevara - clip.mp3");

        Set<MediaItem> firstDuplicate = new HashSet<>();
        for (String item : firstDuplicateFilenames) {
            String abs = Paths.get(currentWorkingFolder, 
                                   TEMP_TEST_INPUT_FOLDER,
                                   PERMANENT_TEST_INPUT_FOLDER, 
                                   item).toString();
            
            firstDuplicate.add(new MediaItem().setAbsolutePath(abs));
        }
        Set<MediaItem> secondDuplicate = new HashSet<>();
        for (String item : secondDuplicateFilenames) {            
            String abs = Paths.get(currentWorkingFolder, 
                                   TEMP_TEST_INPUT_FOLDER,
                                   PERMANENT_TEST_INPUT_FOLDER, 
                                   item).toString();
            secondDuplicate.add(new MediaItem().setAbsolutePath(abs));
        }

        Set<Set<MediaItem>> duplicates = new HashSet<>();
        duplicates.add(firstDuplicate);
        duplicates.add(secondDuplicate);

        return duplicates;
    }
   

}
