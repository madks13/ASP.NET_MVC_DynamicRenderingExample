using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRenderingExample.MVC.Models
{
    public class DateInput : BaseInput<DateTime>
    {
        public override string Title => "Date Input";
    }
}
