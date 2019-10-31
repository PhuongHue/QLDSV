using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.BatLoi
{
    static class BindingSourceMessage
    {
        public static string ToMessage(ConstraintException constraintException, String name)
        {
            if( constraintException.TargetSite.DeclaringType.Name == "UniqueConstraint")
            {
                return $"{name} đã tồn tại";
            }
            return "Ops. Có lỗi xảy ra";
        }
    }
}
