using System;
using System.Collections.Generic;
using CadastroDeSerie.Interfaces;

namespace CadastroDeSerie
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> serieList = new List<Serie>();
        public void Update(int id, Serie entity)
        {
            serieList[id] = entity;
        }

        public void Delete(int id)
        {
            serieList[id].Deleting();
        }

        public void Insert(Serie entity)
        {
            serieList.Add(entity);
        }

        public List<Serie> List()
        {
            return serieList;
        }

        public int NextId()
        {
            return serieList.Count;
        }

        public Serie ReturnById(int id)
        {
            return serieList[id];
        }
    }
}