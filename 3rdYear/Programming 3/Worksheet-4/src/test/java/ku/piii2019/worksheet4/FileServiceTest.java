/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ku.piii2019.worksheet4;

//import ku.piii2019.worksheet4.FileService;
//import ku.piii2019.worksheet4.FileServiceImpl;
//import ku.piii2019.worksheet4.MediaItem;
import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Disabled;
/**
 *
 * @author James
 */
@Disabled
public class FileServiceTest {
    
    public FileServiceTest() {
    }
    
    @BeforeAll
    public static void setUpClass() {
    }
    
    @AfterAll
    public static void tearDownClass() {
    }
    
    @BeforeEach
    public void setUp() {
        Path currentWorkingFolder = Paths.get("").toAbsolutePath();
        
        File srcFolder = new File(FileServiceTestHelper.PERMANENT_TEST_INPUT_FOLDER);
        File destFolder = new File(FileServiceTestHelper.TEMP_TEST_INPUT_FOLDER);
        
        try {
//            FileServiceTestHelper.deleteFolderRecursively(destFolder);    
            FileServiceTestHelper.deleteFolderWithFileVisitor(destFolder.toString());
        }
        catch (Exception e) {
            // no problem
            e.printStackTrace();
        }
        try {
            FileServiceTestHelper.copyFolder(currentWorkingFolder, srcFolder, destFolder);
        }
        catch (Exception e) {
            // problem
            e.printStackTrace();
            Assertions.fail("could not create test folder");
        }
        // remove temporary folder, if it is there
        // copy permanent folder to temp location
        
    }
    
    @AfterEach
    public void tearDown() {
//        FileServiceTestHelper.deleteFolderRecursively
//                    (new File(FileServiceTestHelper.TEMP_TEST_INPUT_FOLDER));
            FileServiceTestHelper.
                    deleteFolderWithFileVisitor
                        (FileServiceTestHelper.TEMP_TEST_INPUT_FOLDER);
    }

    /**
     * Test of getAllMediaItems method, of class FileService.
     */
    @Test
    public void testGetAllMediaItems() {
        System.out.println("getAllMediaItems: begin by testing .equals and .hashcode...");
        Assertions.assertTrue(MediaItemTest.testEquals());
        Assertions.assertTrue(MediaItemTest.testHashCode());
        
        Path currentWorkingFolder = Paths.get("").toAbsolutePath();
        String rootFolder = FileServiceTestHelper.TEMP_TEST_INPUT_FOLDER;
        FileService instance = new FileServiceImpl();
        Set<MediaItem> expResult = FileServiceTestHelper.getAllMediaItems(currentWorkingFolder.toString());
        Set<MediaItem> result = instance.getAllMediaItems(rootFolder);
        System.out.println("the expected result:");
        FileServiceTestHelper.print2(expResult);
        System.out.println("the actual result:");
        FileServiceTestHelper.print2(result);
        Assertions.assertEquals(expResult, result);
    }

    /**
     * Test of getDuplicates method, of class FileService.
     */
    @Test
    public void testGetDuplicates() {
        System.out.println("getDuplicates");
        Assertions.assertTrue(MediaItemTest.testEquals());
        Assertions.assertTrue(MediaItemTest.testHashCode());

        String currentWorkingFolder = Paths.get("").toAbsolutePath().toString();
        Set<MediaItem> allMediaItems = FileServiceTestHelper.getAllMediaItems(currentWorkingFolder);
        FileService instance = new FileServiceImpl();
        Set<Set<MediaItem>> expResult = FileServiceTestHelper.getDuplicates(currentWorkingFolder);
        Set<Set<MediaItem>> result = instance.getDuplicates(allMediaItems);
        System.out.println("the expected result:");
        FileServiceTestHelper.print1(expResult);
        System.out.println("the actual result:");
        FileServiceTestHelper.print1(result);
        
        Assertions.assertEquals(expResult, result);
    }

    /**
     * Test of getListToRemove method, of class FileService.
     */
    @Test
    public void testGetListToRemove() {
        System.out.println("getListToRemove");
        Assertions.assertTrue(MediaItemTest.testEquals());
        Assertions.assertTrue(MediaItemTest.testHashCode());
        List<MediaItem> listOfDuplicates = null;
        FileService instance = new FileServiceImpl();
        String currentWorkingFolder = Paths.get("").toAbsolutePath().toString();
        Set<Set<MediaItem>> duplicates = 
                FileServiceTestHelper.getDuplicates(currentWorkingFolder);

        Set<MediaItem> itemsToRemove = instance.getItemsToRemove(duplicates);
        
        System.out.println("the duplicates to choose from:");
        FileServiceTestHelper.print1(duplicates);
        System.out.println("the list selected to remove:");
        FileServiceTestHelper.print2(itemsToRemove);
        
        for(Set<MediaItem> thisDuplicateSet : duplicates) {
            // for each duplicate set, find out how many elements in 'itemsToRemove'
            // are the duplicates (i.e. have the same filename)
            // the answer should be #num-items-in-set - 1 
            MediaItem firstDuplicateInSet = thisDuplicateSet.iterator().next();
            int numLikeThis = 
                    FileServiceTestHelper.getNumLikeThis(firstDuplicateInSet, itemsToRemove);
            Assertions.assertEquals( thisDuplicateSet.size()-1, numLikeThis);
        }
    }

    /**
     * Test of removeFiles method, of class FileService.
     */
    @Test
    public void testRemoveFiles() {
        System.out.println("removeFiles");
        Assertions.assertTrue(MediaItemTest.testEquals());
        Assertions.assertTrue(MediaItemTest.testHashCode());
        Set<MediaItem> listToRemove = null;
        String currentWorkingFolder = Paths.get("").toAbsolutePath().toString();
        Set<MediaItem> allMediaItems = 
                        FileServiceTestHelper.getAllMediaItems(currentWorkingFolder);
        Assertions.assertTrue(FileServiceTestHelper.filesExist(allMediaItems));

        FileService instance = new FileServiceImpl();
        
        Set<MediaItem> allDuplicates = new HashSet<>();
        Set<Set<MediaItem>> duplicates = 
                        FileServiceTestHelper.getDuplicates(currentWorkingFolder);
        for(Set<MediaItem> m : duplicates)
            allDuplicates.addAll(m);
        instance.removeFiles(allDuplicates);
        allMediaItems.removeAll(allDuplicates);
        Assertions.assertTrue(FileServiceTestHelper.filesExist(allMediaItems));
        Assertions.assertTrue(FileServiceTestHelper.filesDontExist(allDuplicates));
    }
}
