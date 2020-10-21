using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKIDene
{
    public partial class WebForm1 : System.Web.UI.Page
    { 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //.Replace(",", " .")
            double boy = Convert.ToDouble(TextBox1.Text);
            double kilo = Convert.ToDouble(TextBox2.Text);


            VucutKitleLib vk = new VucutKitleLib(kilo, boy);
            double endeks = Math.Round(vk.EndeksHesapla());
            string durum = vk.DurumDegerlendir();
            double ikg = vk.IdealKgHesapla(boy);

            TextBox3.Text = endeks + " " + durum;


            TextBox4.Text = Convert.ToString(ikg);
        }
    }
}