/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.controller;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Tab;
import javafx.scene.control.TabPane;

/**
 *
 * @author GraphX
 */
public class TabMenuController implements Initializable{
    
    @FXML
    private TabPane tabPane;
    @FXML
    private Tab tabPeople;
    @FXML
    private static Tab tabAddPerson;
    @FXML
    private static Tab tabZanimanja;
    @FXML
    private static Tab tabAddZanimanje;

    public static TabPane tabPaneOut;

    /**
     * Initializes the controller class.
     */
  

    public static void switchTab(int index) {
        tabPaneOut.getSelectionModel().select(index);
    }

    @Override
    public void initialize(URL location, ResourceBundle resources) {
          tabPaneOut = tabPane;
    }
    
}
