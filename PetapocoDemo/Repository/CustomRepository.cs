using PetaPoco;
using PetaPoco.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetapocoDemo.Repository
{
    public class CustomRepository : ICustomRepository
    {
        //private static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=PetapocoDemo;Trusted_Connection=True;MultipleActiveResultSets=true";private static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=PetapocoDemo;Trusted_Connection=True;MultipleActiveResultSets=true";
        private static string connectionString = "Server=localhost;Database=PetapocoDemo;uid=root;pwd=10jqka@admin;";
        IDatabase db = DatabaseConfiguration.Build().UsingCommandTimeout(60)
            .WithAutoSelect()
            .WithNamedParams()
            .UsingConnectionString(connectionString)
            .UsingProvider<MySqlDatabaseProvider>().Create();
        public async Task<object> AddData<T>(T t)
        {
            var result = await db.InsertAsync(t);
            return result;
        }

        public async Task<int> DeleteById<T>(int id)
        {
            int result = await db.DeleteAsync<T>(id);
            return result;
        }

        public async Task<List<T>> SelectAllData<T>()
        {
            List<T> tList = await db.FetchAsync<T>();
            return tList;
        }


        public async Task<T> SelectById<T>(int id)
        {
            T t = await db.SingleOrDefaultAsync<T>(id);
            return t;
        }

        public async Task<List<T>> SelectByQueryClass<T>(long page, long itemsPerPage, Sql sql)
        {
            List<T> list = await db.FetchAsync<T>(page, itemsPerPage, sql);
            return list;
        }

        public async Task<int> UpdateData<T>(T t, int id)
        {
            int result = await db.UpdateAsync(t, id);
            return result;
        }
    }
}
