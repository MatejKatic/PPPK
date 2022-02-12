/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.controller;


import hr.algebra.dao.RepositoryFactory;
import hr.algebra.model.Zanimanje;
import hr.algebra.viewmodel.ZanimanjeViewModel;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;

/**
 *
 * @author GraphX
 */
public class AddZanimanjeController implements Initializable{

    
     @FXML
    private TextField tfName;
    @FXML
    private Label lbNameError;

    /**
     * Initializes the controller class.
     */
    private static TextField tfNameOut;

    private static Label lbNameErrorOut;
    @FXML
    private Label lbIconError;
    
    @Override
    public void initialize(URL location, ResourceBundle resources) {
        tfNameOut = tfName;
        lbNameErrorOut = lbNameError;
    }
    
     @FXML
    private void commit(ActionEvent event) {
        ListZanimanjeController.selectedZanimanjeViewModel = ListZanimanjeController.selectedZanimanjeViewModel != null ? ListZanimanjeController.selectedZanimanjeViewModel : new ZanimanjeViewModel(null);

        if (formValid()) {
            ListZanimanjeController.selectedZanimanjeViewModel.getZanimanje().setNaziv(tfName.getText().trim());
            if (ListZanimanjeController.selectedZanimanjeViewModel.getZanimanje().getIDZanimanje()== 0) {
                ListZanimanjeController.zanimanjes.add(ListZanimanjeController.selectedZanimanjeViewModel);
            } else {
                try {
                    RepositoryFactory.getRepository(Zanimanje.class).update(ListZanimanjeController.selectedZanimanjeViewModel.getZanimanje());
                    ListZanimanjeController.tvZanimanjesOut.refresh();
                } catch (Exception ex) {
                    Logger.getLogger(AddZanimanjeController.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
            ListZanimanjeController.selectedZanimanjeViewModel = null;
            TabMenuController.switchTab(2);
            ListZanimanjeController.tvZanimanjesOut.refresh();
            resetForm();
        } else {
            lbNameError.setVisible(true);
        }
    }

    private boolean formValid() {
        return !tfName.getText().trim().isEmpty();
    }

    public static void fillForm() {
        tfNameOut.setText(ListZanimanjeController.selectedZanimanjeViewModel.getZanimanje().getNaziv());
    }

    private void resetForm() {
        ListZanimanjeController.selectedZanimanjeViewModel = null;
        tfNameOut.clear();
        lbNameErrorOut.setVisible(false);
    }

    @FXML
    private void reset(ActionEvent event) {
        resetForm();
    }
    
}
