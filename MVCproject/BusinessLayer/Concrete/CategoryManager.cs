using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public   class CategoryManager
    {
        //CategoryManager içerisine öncelikle üzerinde çalışacağımız sınıfı çağırıyoruz. Yani Repositories sınıfına bağlı olarak çağırıyoruz.
        //Küçüktür büyüktür sembolü içerisine bir T değeri göndermemiz gerekiyor. T değeri bir class olacak yani üzerinde çalışacağımız Entity olacak.
        //Nesne türetiyoruz ve ismine (repo) diyoruz.
        GenericRepository<Category> repo = new GenericRepository<Category>();
    
        //Daha sonra her bir (CRUD) işlemleri için metodlar tanımlıyoruz.
        //Listeleme işlemi
        public List<Category> GetAllBl()
        {
            return repo.List();
        }

        //Ekleme işlemi
        public void CategoryADDBl(Category p)
        {
            repo.Insert(p);
            //Eğer bizim dışarıdan gönderdiğimiz paratmetre if bloğuna takılırsa hata mesajı gönderir.
            //Aksi durumda insert metodu çağırılsın ve p parametresi gelsin.
            //if (p.CategoryName== "" || p.CategoryName.Length <= 3 || p.CategoryDescription=="" || p.CategoryName.Length >= 51)
            //{
            //    Hata mesajı
            //}
            //else
            //{
            //    
            //}
           
        }

    }
}
