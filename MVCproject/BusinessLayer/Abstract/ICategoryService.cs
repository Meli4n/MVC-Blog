using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        //List içerisinde kategoriyi getiriyoruz.
        //İsmine GetList koyuyoruz.
        List<Category> GetList();

        //Kategori ekleme metodunu tanımlıyoruz.
        //Kategoriden bir kategori parametresi alıcak.
        void CategoryAddBL(Category category);

        //Silme işlemi için ID ye göre getirme işlemi
        //GetByID id ye göre değişken alıcak.
        Category GetByID(int id);   

        //Silme işlemi yazmamız gereken metod.
        void CategoryDelete(Category category);

        //Güncelleme işlemi için yazdığımız metod.
        void CategoryUpdate(Category category);
    }
}
