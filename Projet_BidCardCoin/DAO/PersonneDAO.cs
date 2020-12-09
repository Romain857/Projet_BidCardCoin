﻿using Projet_BidCardCoin.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BidCardCoin.DAO
{
    public class PersonneDAO
    {
        public int idDAO;
        public string nomPersonneDAO;
        public string prenomPersonneDAO;
        public string mailPersonneDAO;
        public int numerotelPersonneDAO;
        public string mdpPersonneDAO;
        public int ageDAO;
        public int idEnchereDAO;
        public int idLieuDAO;
        public PersonneDAO(int idDAO, string nomPersonneDAO, string prenomPersonneDAO, string mailPersonneDAO, int numerotelPersonneDAO, string mdpPersonneDAO, int ageDAO, int idEnchereDAO, int idLieuDAO)
        {
            this.idDAO = idDAO;
            this.nomPersonneDAO = nomPersonneDAO;
            this.prenomPersonneDAO = prenomPersonneDAO;
            this.mailPersonneDAO = mailPersonneDAO;
            this.numerotelPersonneDAO = numerotelPersonneDAO;
            this.mdpPersonneDAO = mdpPersonneDAO;
            this.ageDAO = ageDAO;
            this.idEnchereDAO = idEnchereDAO;
            this.idLieuDAO = idLieuDAO;
        }

        public static ObservableCollection<PersonneDAO> listePersonnes()
        {
            ObservableCollection<PersonneDAO> l = PersonneDAL.selectPersonnes();
            return l;
        }

        public static PersonneDAO getPersonne(int id)
        {
            PersonneDAO p = PersonneDAL.getPersonne(id);
            return p;
        }
    }
}
