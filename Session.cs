using BeautySalon1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon1
{
    public class Session
    {
        private Session()
        {
            context = new SalonContext();
        }

        private static Session? instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        private SalonContext context;
        public SalonContext Context => context;

    }
}
