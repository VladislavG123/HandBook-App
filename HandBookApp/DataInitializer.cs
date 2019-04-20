using HandBookApp.Pages;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandBookApp
{
    public class DataInitializer : CreateDatabaseIfNotExists<AppContext>
    {
        private List<City> cities;

        public DataInitializer()
        {
            cities = new List<City>
            {
                new City
                {
                    Name = "Астана",
                    Code = 7172
                },
                new City
                {
                    Name = "Алматы",
                    Code =727
                },
                new City
                {
                    Name = "Байконыр",
                    Code =33622

                },
                new City
                {
                    Name = "Актау",
                    Code =7292

                },
                new City
                {
                    Name = "Актобе",
                    Code =7132

                },
                new City
                {
                    Name = "Атырау",
                    Code =7122

                },
                new City
                {
                    Name = "Балхаш",
                    Code =71036

                },
                new City
                {
                    Name = "Боровое",
                    Code =71630

                },
                new City
                {
                    Name = "Джезказган",
                    Code =7102

                },
                new City
                {
                    Name = "Караганда",
                    Code =7212

                },
                new City
                {
                    Name = "Кокшетау",
                    Code =7162

                },
                new City
                {
                    Name = "Костанай",
                    Code =7142

                },
                new City
                {
                    Name = "Кызылдорда",
                    Code =7242

                },
                new City
                {
                    Name = "Павлодар",
                    Code =7182

                },
                new City
                {
                    Name = "Семипалатинск",
                    Code =7222

                },
                new City
                {
                    Name = "Тараз",
                    Code =7262

                },
                new City
                {
                    Name = "Талдыкорган",
                    Code =7282

                },
                new City
                {
                    Name = "Уральск",
                    Code =7112

                },
                new City
                {
                    Name = "Усть-Каменогорск",
                    Code =7232

                },
                new City
                {
                    Name = "Шымкент",
                    Code =7252
                },

            };
        }

        protected override void Seed(AppContext context)
        {
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
