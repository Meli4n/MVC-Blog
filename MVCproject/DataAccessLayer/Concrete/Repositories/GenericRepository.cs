using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Concrete.Repositories
{
    //Bütün bileşenlerin tamamını kapsar.
    //GenericRepository<T> => T değer alacak.
    //Interface olarak değerleri IRepository den alıcak ve o da IRepository<T> => T değer alıcak.
    //where şartını belirliyoruz ve yanına (T : Class) => "T değeri bir class olmalıdır" yazıyoruz. 
    //T değeri zaten entity olarak gönderiyoruz.

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        //Metodların içerisine ilgili ifadeleri yazabilmek için belirli sınıfları çağırmalıyız.
        //Context sınıfından bir "c" nesnesi türettik.
        //_object T değerine denk gelen sınıfı tutyor
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            //Peki bunu nasıl yapacağız, (ctor) (constructor) dır, iki kere tab tuşuna bastıktan sonra oluşturduğumuz sınıfın ismiyle aynı isimde bir metod oluştu, bu metodların türü constructor metotdu denir.
            //Bu metodun içerisine değer ataması yapıyoruz. Tanımladığımız _object değer ataması yapıyoruz. _object değeri context e bağlı olarak gönderilern T değeri olucak.
            //Artık _object isimli field ım dışarıdan gönderdiğimiz entity neyse o olucak.
             _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            //SingleOrDefault bir dizide veya listede sadece bir tane değer döndüren metodtur.
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
           return _object.ToList(); 
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            //filter den gelen değere göre listeleme yapıcak.
            //filter den neyi göndericeksek onu bize listelicek.
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
