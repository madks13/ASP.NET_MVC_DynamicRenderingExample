using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRenderingExample.MVC.Models
{
    public class ColorInput : BaseInput<string>
    {
        public override string Title => "Color Input";
    }
}
