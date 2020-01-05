using AddressBook.IDAL;
using AddressBook.Model;
using AddressBook.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace AddressBook.DAL
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
    {
        private readonly AddressBookContext _db;
        public BaseService(AddressBookContext db)
        {
            _db = db;
        }

        public async Task CreateAsync(T model, bool saved = true)
        {
            _db.Set<T>().Add(model);
            if (saved)
            {
                await _db.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task EditAsync(T model, bool saved = true)
        {
            //先关掉EF校验
            _db.Configuration.ValidateOnSaveEnabled = false;
            _db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            if (saved)
            {
                await _db.SaveChangesAsync();
            }
            _db.Configuration.ValidateOnSaveEnabled = true;
        }
        /// <summary>
        /// 返回所有未被删除的数据（没有真的执行sql语句）
        /// </summary>
        /// <returns></returns>
        public  IQueryable<T> GetAllAsync()
        {
            return _db.Set<T>().Where(m => !m.IsRemoved).AsNoTracking();
        }

        public IQueryable<T> GetAllByPageAsync(int pagesize = 10, int pageindex = 1)
        {
            return GetAllAsync().Skip(pagesize * (pageindex - 1)).Take(pagesize);
        }

        public IQueryable<T> GetAllByPageOrderAsync(int pageindex = 1, int pagesize = 10, bool asc = true)
        {
            return GetAllOrderAsync(asc).Skip(pagesize * (pageindex - 1)).Take(pagesize);
        }

        public IQueryable<T> GetAllOrderAsync(bool asc = true)
        {
            var datas = GetAllAsync();
            if (asc)
            {
                datas = datas.OrderBy(m => m.CreatedOn);
            }
            else
            {
                datas = datas.OrderByDescending(m => m.CreatedOn);
            }
            return datas;
        }

        public async Task<T> GetOneByIdAsync(Guid id)
        {
            return await GetAllAsync().FirstAsync(i => i.Id == id);
        }

        public async Task RemoveAsync(Guid id, bool saved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            var t = new T() { Id = id };
            _db.Entry(t).State = System.Data.Entity.EntityState.Unchanged;
            t.IsRemoved = true;
            if (saved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }

        }

        public async Task RemoveAsync(T model, bool saved = true)
        {
            await RemoveAsync(model.Id, saved);
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
            _db.Configuration.ValidateOnSaveEnabled = true;
        }
    }
}
