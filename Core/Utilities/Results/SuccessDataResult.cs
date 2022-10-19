using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
  public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string massage):base(data,true,massage)
        {
            //1.versiyon data+mesajlı
        }
        public SuccessDataResult(T data):base(data,true)
        {
            //2.versiyon  data
        }
        public SuccessDataResult(string massage):base(default,true,massage)
        {
                //3.versiyon sadece mesaj
        }
        public SuccessDataResult():base(default,true)
        {
            //4.versiyon hiçbirşey verme
        }
    }
}
