using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;


namespace AWPteacher.Model.Repositories
{
    public class Repository<T>
    {
        protected ISession session; 
        public Repository(ISession session) { this.session = session; }
        public virtual T Load(Guid id)
        {
            return session.Get<T>(id);
        }
        public virtual void Save(T entity)
        {
            using (var tran = session.BeginTransaction())
            {
                try
                {
                    session.Save(entity);
                    tran.Commit();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
