using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public delegate void OnStyleChanged();
    public class AppSettings
    {
        private static AppSettings _instance = null;
        private static readonly object _lock = new object();
        public event OnStyleChanged OnStyleChanged;

        public static AppSettings getInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new AppSettings();
                }
            }

            return _instance;
        }

        private AppSettings()
        {
            r_StyleFactory = new DayMode();
        }

        private IStyleFactory r_StyleFactory;

        public IStyleFactory StyleFactory
        {
            get
            {
                return r_StyleFactory;
            }
        }

        public void SwitchStyleFactory()
        {
            if(r_StyleFactory is DayMode)
            {
                r_StyleFactory = new NightMode();
            }
            else
            {
                r_StyleFactory = new DayMode();
            }
            OnStyleChanged.Invoke();
        }

    }
}
