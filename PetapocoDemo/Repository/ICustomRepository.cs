using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetaPoco;

namespace PetapocoDemo.Repository
{
    public interface ICustomRepository
    {

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<List<T>>  SelectAllData<T>();

        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<T> SelectById<T>(int id);

        /// <summary>
        /// 根据id 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<int> DeleteById<T>(int id);

        /// <summary>
        /// 增加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public Task<Object> AddData<T>(T t);

        /// <summary>
        /// 修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<int> UpdateData<T>(T t, int id);

        /// <summary>
        /// 使用查询类查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public Task<List<T>> SelectByQueryClass<T>(long page, long itemsPerPage, Sql sql);
    }
}
