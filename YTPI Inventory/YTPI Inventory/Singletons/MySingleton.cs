using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTPI_Inventory.Singletons
{
    public class MySingleton
    {
        #region Initialize Singleton class (cold start at class created)
        //private static MySingleton _instance = new MySingleton();
        //public static MySingleton Instance
        //{
        //    get
        //    {
        //        return _instance;
        //    }
        //}
        #endregion


        #region Initialize Singleton class (lazy loading)
        private static MySingleton _instance = null;
        //private MySingleton() { }
        public static MySingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MySingleton();
                }
                return _instance;
            }
        }
        #endregion

        public void HelloWorld()
        {
            //MessageBox.Show("Hello World!!! Singleton Class Called! ");
            System.Diagnostics.Debug.WriteLine("Singleton Class Called!");
        }
    }
}
