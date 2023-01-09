using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //(CategoryRepository) classına kalıtım yaparak (ICategoryDal) ekliyoruz,ama (ICategoryDal) intetface olduğu için başta hata vericektir, o yüzden (ctrl + .) yaparak (ICategoryDal) Implement ediyoruz.
    public class CategoryRepository : ICategoryDal
    {
        //Metodların içerisine ilgili ifadeleri yazabilmek için belirli sınıfları çağırmalıyız.
        //Context sınıfından bir "c" nesnesi türettik.
        //_object T değerine denk gelen sınıfı tutyor
        Context c = new Context();
        DbSet<Category> _object;

        public void Delete(Category p)
        {
            //Silme işleminde parametreden gelen değeri kaldırır.
            //SaveChanges() Context deki değişiklikleri kaydet.
            _object.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            //Ekleme işleminde parametreden gelen değeri _object içerisinde bulunan sınıfa ekler.
            //SaveChanges() Context deki değişiklikleri kaydet.
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            //Burada listelemek için _object in tuttuğu (Category) sınıfındaki değerleri gelen değerleri ToList() e dönüştürüyoruz. 
            //ToList() verileri listelemek için kullanılan metod.
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            //Güncellemede direkt olarak değişiklileri kaydediyoruz çünkü güncelleme işleminden önce yeni halini yansıtıyoruz.
            c.SaveChanges();
        }
    }
}
