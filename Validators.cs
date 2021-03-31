using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarnishMixApp
{
    public class Validators
    {

        public static bool CheckIsAnyAdditionalProducts(int baseproductidvalue, int thinnerrowscount, int hardenerrowscount)
        {
            
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                bool isanythinner = db.GetAnyThinner(baseproductidvalue);
                bool isanyhardener = db.GetAnyHardener(baseproductidvalue);
                bool isanyoptional = db.GetAnyOptional(baseproductidvalue);


                if (isanythinner == false && isanyhardener == false)
                {
                    MessageBox.Show("Bazowy produkt nie posiada żadnego produktu wymaganego do zmieszania");
                    return false;
                }

                else if (isanythinner == true && thinnerrowscount == 0)
                {
                    MessageBox.Show("Nie zaznaczono rozcieńczalnika, pomimo że jest wymagany i znajduje się na liście");
                    return false;
                }

                else if (isanyhardener == true && hardenerrowscount == 0)
                {
                    MessageBox.Show("Nie zaznaczono utwardzacza, pomimo że jest wymagany i znajduje się na liście");
                    return false;
                }

                return true;
            }

            
        }
    }
}
