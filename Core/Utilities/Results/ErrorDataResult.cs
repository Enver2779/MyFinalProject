using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string massage) : base(data, false, massage)
        {
            //1.versiyon data+mesajlı
        }
        public ErrorDataResult(T data) : base(data, false)
        {
            //2.versiyon  data
        }
        public ErrorDataResult(string massage) : base(default, false, massage)
        {
            //3.versiyon sadece mesaj
        }
        public ErrorDataResult() : base(default, false)
        {
            //4.versiyon hiçbirşey verme
        }
    }
}


