﻿//Agheorghiesei Madalina, grupa 3123A
using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate1
{
    public class AdministrareCarti_FisierBinar : IStocareData1
    {
        string NumeFisier { get; set; }
        public AdministrareCarti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddCarte(Carte s)
        {
            throw new Exception("Optiunea AddCarte nu este implementata");
        }

        public List<Carte> GetCarti()
        {
            throw new Exception("Optiunea GetCarti nu este implementata");
        }

        public Carte GetCarte(string titlu, string autor)
        {
            throw new Exception("Optiunea GetCarte nu este implementata");
        }
        public bool UpdateCarte(Carte carte)
        {
            throw new Exception("Optiunea UpdateCarte nu este implementata");
        }
        public int NrCarti()
        {
            throw new Exception("Optiunea NrCarti nu este implementata");
        }
        public Carte GetCarteByIndex(int index)
        {
            throw new Exception("Optiunea GetCarteByIndex nu este implementata");
        }
        public bool StergeCarte(Carte carte)
        {
            throw new Exception("Optiunea StergeCarte nu este implementata");
        }
    }
}
