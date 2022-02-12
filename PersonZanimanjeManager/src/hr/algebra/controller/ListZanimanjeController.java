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
import javafx.collections.FXCollections;
import javafx.collections.ListChangeListener;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;

/**
 *
 * @author GraphX
 */
public class ListZanimanjeController implements Initializable {
    
      public static final ObservableList<ZanimanjeViewModel> zanimanjes = FXCollections.observableArrayList();

    public static ZanimanjeViewModel selectedZanimanjeViewModel;

    @FXML
    private TableView<ZanimanjeViewModel> tvZanimanjes;
    @FXML
    private TableColumn<ZanimanjeViewModel, String> tcName;

    public static TableView<ZanimanjeViewModel> tvZanimanjesOut;

    @Override
    public void initialize(URL location, ResourceBundle resources) {
        initKlubs();
        initTable();
        setupListeners();
        tvZanimanjesOut = tvZanimanjes;
    }
    
     private void initTable() {
        tcName.setCellValueFactory(klub -> klub.getValue().getNameProperty());
        tvZanimanjes.setItems(zanimanjes);
    }

    private void initKlubs() {
        try {
            RepositoryFactory.getRepository(Zanimanje.class).getAll().forEach(klub -> zanimanjes.add(new ZanimanjeViewModel((Zanimanje) klub)));
        } catch (Exception ex) {
            Logger.getLogger(ListZanimanjeController.class.getName()).log(Level.SEVERE, null, ex);
            new Alert(Alert.AlertType.ERROR, "Unable to load the form. Exiting...").show();
        }
    }

    private void setupListeners() {
        zanimanjes.addListener((ListChangeListener.Change<? extends ZanimanjeViewModel> change) -> {
            if (change.next()) {
                if (change.wasRemoved()) {
                    change.getRemoved().forEach(pvm -> {
                        try {
                            RepositoryFactory.getRepository(Zanimanje.class).delete(pvm.getZanimanje());
                        } catch (Exception ex) {
                            Logger.getLogger(ListZanimanjeController.class.getName()).log(Level.SEVERE, null, ex);
                        }
                    });
                } else if (change.wasAdded()) {
                    change.getAddedSubList().forEach(pvm -> {
                        try {
                            int idKlub = RepositoryFactory.getRepository(Zanimanje.class).add(pvm.getZanimanje());
                            pvm.getZanimanje().setIDZanimanje(idKlub);
                        } catch (Exception ex) {
                            Logger.getLogger(ListZanimanjeController.class.getName()).log(Level.SEVERE, null, ex);
                        }
                    });
                }
            }
        });
    }

    @FXML
    private void delete(ActionEvent event) {
        if (tvZanimanjes.getSelectionModel().getSelectedItem() != null) {
            ListPeopleController.people.removeIf(p -> p.getZanimanjeProperty().getValue().getIDZanimanje()== tvZanimanjes.getSelectionModel().getSelectedItem().getZanimanje().getIDZanimanje());
            zanimanjes.remove(tvZanimanjes.getSelectionModel().getSelectedItem());
        }
    }

    @FXML
    private void edit(ActionEvent event) {
        if (tvZanimanjes.getSelectionModel().getSelectedItem() != null) {
            selectedZanimanjeViewModel = tvZanimanjes.getSelectionModel().getSelectedItem();
            AddZanimanjeController.fillForm();
            TabMenuController.switchTab(3);
        }

    }
    
}
