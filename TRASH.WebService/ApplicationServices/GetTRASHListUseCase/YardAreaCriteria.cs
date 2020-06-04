using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TRASH.ApplicationServices.GetYardAreaListUseCase
{
    public class YardAreaCriteria : ICriteria<trash>
    {
        public string yardarea { get; }

        public YardAreaCriteria (string yardarea)
            => this.yardarea = yardarea;

        public Expression<Func<trash, bool>> Filter
            => (b => b.YardArea == yardarea);
    }
}
