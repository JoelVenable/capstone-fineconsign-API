using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data
{
    public class DbInitializer
    {
        public static void Initialize(MyAppContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
