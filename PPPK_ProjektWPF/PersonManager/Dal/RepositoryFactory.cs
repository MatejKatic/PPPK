﻿using System;
using System.Collections.Generic;
using Zadatak.Models;

namespace Zadatak.Dal
{
    static class RepositoryFactory
    {
        private static readonly Lazy<Dictionary<string, Object>> repositorys = new Lazy<Dictionary<string, Object>>(() =>
       {
           Dictionary<string, Object> repos = new Dictionary<string, Object>();
           repos.Add(nameof(Person), new SqlRepository());
           repos.Add(nameof(Zanimanje), new SqlzanimanjeRepository());
           return repos;
       });


        public static IRepository<T> GetRepository<T>()
        {

            return (IRepository<T>)repositorys.Value[typeof(T).Name];

        }


    }
}
