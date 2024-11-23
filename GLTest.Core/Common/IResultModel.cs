using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLTest.Core.Common
{
    public interface IResultModel<T>
    {
        bool IsSuccess { get; }
        string ErrorMessage { get; }
        T Result { get; }
    }
}
