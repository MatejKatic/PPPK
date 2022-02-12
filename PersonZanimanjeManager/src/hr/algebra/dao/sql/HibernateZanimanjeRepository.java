/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.dao.sql;

import hr.algebra.dao.Repository;
import hr.algebra.model.Zanimanje;
import java.util.List;
import javax.persistence.EntityManager;

/**
 *
 * @author GraphX
 */
public class HibernateZanimanjeRepository implements Repository<Zanimanje> {

    @Override
    public int add(Zanimanje data) throws Exception {
         try (EntityManagerWrapper entityManager = HibernateFactory.getEntityManager()) {
            EntityManager em = entityManager.get();
            em.getTransaction().begin();
            Zanimanje zanimanje = new Zanimanje(data);
            em.persist(zanimanje);
            em.getTransaction().commit();
            return zanimanje.getIDZanimanje();
        }
    }

    @Override
    public void delete(Zanimanje zanimanje) throws Exception {
        try (EntityManagerWrapper entityManager = HibernateFactory.getEntityManager()) {
            EntityManager em = entityManager.get();
            em.getTransaction().begin();
            em.remove(em.contains(zanimanje) ? zanimanje : em.merge(zanimanje));
            em.getTransaction().commit();
        }
    }

    @Override
    public List<Zanimanje> getAll() throws Exception {
       try (EntityManagerWrapper entityManager = HibernateFactory.getEntityManager()) {
            return entityManager.get().createNamedQuery(HibernateFactory.SELECT_ZANIMANJES).getResultList();
        }
    }

    @Override
    public Zanimanje get(int idItem) throws Exception {
        try (EntityManagerWrapper entityManager = HibernateFactory.getEntityManager()) {
            EntityManager em = entityManager.get();
            return em.find(Zanimanje.class, idItem);
        }
    }

    @Override
    public void update(Zanimanje item) throws Exception {
          try (EntityManagerWrapper entityManager = HibernateFactory.getEntityManager()) {
            EntityManager em = entityManager.get();
            em.getTransaction().begin();
            em.find(Zanimanje.class, item.getIDZanimanje()).updateZanimanje(item);
            em.getTransaction().commit();
        }
    }
    
     public void release() throws Exception {
        HibernateFactory.release();
    }
    
}
