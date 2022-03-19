using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        /*
         * Claims: Sisteme giriş yapan kullanıcının ek bilgilerinin tutulduğu yapıdır.
         * Role: Sisteme giriş yapankullanıcının hangi rol yapısında olduğunu
         * ve rolün kullanıldığı yerlerde kontrol sağlayan yapıdır.
         * 
         * */
        // bir kullanıcının claimlerini çekmek
        List<OperationClaim> GetClaims(User user);
    }
}
