/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.viewmodel;

import hr.algebra.model.Zanimanje;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

/**
 *
 * @author GraphX
 */
public class ZanimanjeViewModel {
    
   private final Zanimanje zanimanje;

    public ZanimanjeViewModel(Zanimanje zanimanje) {
          if (zanimanje == null) {
            zanimanje = new Zanimanje(0, "");
        }
        this.zanimanje = zanimanje;
    }


   
    public Zanimanje getZanimanje() {
        return zanimanje;
    }
    
      public StringProperty getNameProperty() {
        return new SimpleStringProperty(zanimanje.getNaziv());
    }


    @Override
    public String toString() {
        return zanimanje.toString();
    }

    
}
