using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Interfaces
{
    public interface INewsRepository
    {
        News GetById(int id);

        IEnumerable<News> GetNews(int pageIndex = 1, int pageSize = 3);
        int GetCount();
    }
}
