using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Caching
{
    public interface ICacheManager
    {
        // object bütün veri tiplerinin base i oldugu icin( herşey olabilecegi icin object tipinde belirledik)
        // cache de ne kadar süre duracak -- duration -- dakike, saat cinsinden istediğimiz gibi tutabiliriz
        void Add(string key, object value, int duration);
        T Get<T>(string key); // bellekten key e karsılık gelen datayı ver demek
        object Get(string key);

        bool IsAdd(string key); // cache de var mı yok mu
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
