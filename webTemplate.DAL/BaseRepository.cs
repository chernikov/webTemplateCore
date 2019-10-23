using System;
using webTemplate.Data;

namespace webTemplate.DAL
{
    public class BaseRepository
    {

        private readonly Lazy<IWebTemplateDbContext> lazyContext;

        private IWebTemplateDbContext context => lazyContext.Value;


        protected readonly Func<IWebTemplateDbContext> getDbContext;

        public BaseRepository(Func<IWebTemplateDbContext> getDbContext)
        {
            this.getDbContext = getDbContext;
            lazyContext = new Lazy<IWebTemplateDbContext>(() => getDbContext());
        }

        protected T Execute<T>(Func<IWebTemplateDbContext, T> functor)
        {
            using (var dbContext = getDbContext())
            {
                return functor(dbContext);
            }
        }

        protected T Query<T>(Func<IWebTemplateDbContext, T> functor)
        {
            return functor(context);
        }
    }
}
