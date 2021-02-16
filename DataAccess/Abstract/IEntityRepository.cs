using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    /*
     * Aşağıdaki kod Bizim her Entity için (Product,Category,Car,Brand...) DAL'da aynı CRUD işlemlerini tekrarlamak yerine
     * (tekrar tekrar yazmak yerine, Generic bir Class oluşturup içine yapılacak işlemleri bir Class'ta toplamaya yarıyor
     * Yani hangi tipin DAL'ını yazmak istiyorsak <T> ye onu veriyoruz ve böylece otomatikman ilgili Class'ın dalını 
     * oluşturmuş oluyoruz. Tabi burada dikkat etmemiz gereken şey; <T> olarak herşeyin gelebileceği, bir int veya string bile 
     * gelebilir. 
     * Burada <T> olarak gelecek şeyi belirlemek için "where" koşul ifadesi ile inherit edilecek tipi kısıtlamak istedik:
     * - "T:class" inherit edilecek tipin bir referans tipi (class yazısı sadece class olarak algılanmasın string te bir referanstır)
     * olması gerektiğini belirtir.
     * - inherit edilecek tip Entities klasöründeki tipler olmalı. Bu durumda onların ortak özelliği olan "IEntity"i kullanarak
     * inherit edilecek nesnenin "IEntity" olması gerektiğini söylüyorum.
     * - Ancak IEntity soyut bir sınıf ve soyut sınıfa aşağıdaki işlemleri yaptıramayız. Bu yüzden Car,Brand,Product,Category 
     * gibi nesneler için bu işlemleri yapabilirken IEntity'i dışlamamız lazım. Bunun içinde "new'lene bilir olmalı" 
     * anlamına gelen "new()" ifadesini de kullandık. Bu durumda IEntity'nin kendisini de dışlamış olduk.
     */
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {        
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
