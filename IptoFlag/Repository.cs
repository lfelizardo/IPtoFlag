using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IptoFlag
{
    public class Repository
    {
        private GlobeDatabaseEntities entities;
        public Repository() : this(new GlobeDatabaseEntities ())
        {
        }

        public Repository(GlobeDatabaseEntities globeEnt)
        {
            this.entities = globeEnt;
        }

        public IQueryable<Countries> GetCountries() 
        {
            return this.entities.Countries;
        }

        public Countries GetCountry(int idCountry)
        {
            return GetCountries().FirstOrDefault(c => c.IdCountry == idCountry);
        }

        public IQueryable<Info> GetInfos()
        {
            return this.entities.Info;
        }

        public Info GetInfo(int idCountry)
        {
            return this.entities.Info.FirstOrDefault(i => i.IdCountry == idCountry);
        }

        public void AddInfo(Info info)
        {
            var id = this.entities.Info.Max(i => i.IdInfo);
            info.IdInfo = id+1;
            this.entities.Info.Add(info);
        }

        public void SubmitChanges()
        {
            this.entities.SaveChanges();
        }


        //controller.repository.viewbag.contries    //return this.entities.Info.FirstOrDefault().Countries; 

        //public Info GetInfo(int idInfo)
        //{
        //    return this.entities.Info.FirstOrDefault(i => i.IdInfo == idInfo);
        //}


    }
}