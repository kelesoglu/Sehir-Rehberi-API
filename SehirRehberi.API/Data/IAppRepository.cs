using SehirRehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T:class; //Ekleme işlemi
        void Delete<T>(T entity) where T : class; //Silme işlemi
        bool SaveAll(); //Yapılan işleri kaydetme

        List<City> GetCities(); //Şehirleri getirme işlemi
        List<Photo> GetPhotosByCity(int cityId); //Şehir fotoğraflarını listeleme
        City GetCityById(int cityId); //Belirli bir şehrin verisini getirme işlemi
        Photo GetPhoto(int id);
    }
}
