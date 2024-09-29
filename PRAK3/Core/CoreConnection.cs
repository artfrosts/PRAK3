using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PRAK3.Core
{
    public static class CoreConnection
    {

        public static Frame CoreFrame { get; set; }

        public static TaskTwoDBEntities DB {  get; set; }
    }
}
