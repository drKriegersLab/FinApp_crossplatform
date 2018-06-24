using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp_crossplatform
{

    public class MasterDetailNavigationMenuItem
    {
        public MasterDetailNavigationMenuItem()
        {
            TargetType = typeof(MasterDetailNavigationDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}