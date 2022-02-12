/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.Collection;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author GraphX
 */
@Entity
@Table(name = "Zanimanje")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Zanimanje.findAll", query = "SELECT z FROM Zanimanje z")
    , @NamedQuery(name = "Zanimanje.findByIDZanimanje", query = "SELECT z FROM Zanimanje z WHERE z.iDZanimanje = :iDZanimanje")
    , @NamedQuery(name = "Zanimanje.findByNaziv", query = "SELECT z FROM Zanimanje z WHERE z.naziv = :naziv")})
public class Zanimanje implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDZanimanje")
    private Integer iDZanimanje;
    @Basic(optional = false)
    @Column(name = "Naziv")
    private String naziv;
    @OneToMany(mappedBy = "zanimanjeID")
    private Collection<Person> personCollection;

    public Zanimanje() {
    }

      public Zanimanje(Zanimanje data) {
        updateZanimanje(data);
    }
    
    public Zanimanje(Integer iDZanimanje) {
        this.iDZanimanje = iDZanimanje;
    }

    public Zanimanje(Integer iDZanimanje, String naziv) {
        this.iDZanimanje = iDZanimanje;
        this.naziv = naziv;
    }

    public Integer getIDZanimanje() {
        return iDZanimanje;
    }

    public void setIDZanimanje(Integer iDZanimanje) {
        this.iDZanimanje = iDZanimanje;
    }

    public String getNaziv() {
        return naziv;
    }

    public void setNaziv(String naziv) {
        this.naziv = naziv;
    }

    @XmlTransient
    public Collection<Person> getPersonCollection() {
        return personCollection;
    }

    public void setPersonCollection(Collection<Person> personCollection) {
        this.personCollection = personCollection;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDZanimanje != null ? iDZanimanje.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Zanimanje)) {
            return false;
        }
        Zanimanje other = (Zanimanje) object;
        if ((this.iDZanimanje == null && other.iDZanimanje != null) || (this.iDZanimanje != null && !this.iDZanimanje.equals(other.iDZanimanje))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return naziv;
    }
    
    public void updateZanimanje(Zanimanje data) {
        this.naziv = data.getNaziv();

    }
    
}
