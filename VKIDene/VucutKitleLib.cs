using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI.WebControls;

namespace VKIDene
{
    public class VucutKitleLib
    {
        private double _boy;
        private double _kilo;

        public double Boy
        {
            get { return _boy; }
            set
            {
                if (value > 1.0 && value < 2.0)
                {
                    _boy = value;
                }
               
                
                else { 
                
                    throw new Exception("Boy için uygun değer girilmelidir.");
                }
            }
        }
        public double Kilo
        {
            get { return _kilo; }
            set
            {
                if (value >= 40 && value < 150)
                {
                    _kilo = value;
                }
                else
                {
                    throw new Exception("Kilo için uygun değer girilmelidir.");
                }
            }
        }

        public static double EndeksHesapla(double kilo, double boy)
        {
            if (kilo >= 40 && kilo < 200 && boy >= 1.0 && boy < 2.5)
            {

                double VKI = kilo / ((boy / 100) * (boy / 100));
                return VKI;
            }
            else
            {
                throw new Exception("Lütfen geçerli bir değer giriniz");
            }
        }


        public VucutKitleLib(double kilo, double boy)
        {
            this.Kilo = kilo;
            this.Boy = boy;
        }

        public double EndeksHesapla()
        {

            double vki = Kilo / (Boy * Boy);
            return vki;
        }

        public double IdealKgHesapla(double boy)
        {
            double cmcevir = boy * 100;
            double inccevir = cmcevir / 2.54;

            double IdeaKg = Math.Round(50 + 2.3 * (inccevir - 60));

            return IdeaKg;

            //50 + 2,3 X(İnç cinsinden boy - 60)
        }

        //[Obsolete("IdealKg metodu demode olmuştur. Yeni projelerinizde IdealKgHesapla isimli metodu kullanınız.")]
        public double IdealKg(double boy)
        {
            return IdealKgHesapla(boy);
        }

        public string DurumDegerlendir()
        {
            string durum;
            double endeks = EndeksHesapla();

            if (endeks < 20)
            {
                durum = "Zayıf";
            }
            else if (endeks > 20 && endeks < 24.9)
            {
                durum = "Normal";
            }
            else if (endeks > 25 && endeks < 29.9)
            {
                durum = "Hafif şişman";
            }
            else if (endeks > 30 && endeks < 34.9)
            {
                durum = "Şişman";
            }
            else if (endeks > 35 && endeks < 44.9)
            {
                durum = "Obez";
            }
            else if (endeks > 45 && endeks < 49.9)
            {
                durum = "Aşırı obez";
            }
            else
            {
                durum = "Morbid(ölümcül) obez";
            }

            return durum;
        }
    }
}