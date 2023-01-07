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
    }
}
