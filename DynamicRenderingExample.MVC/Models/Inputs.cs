using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRenderingExample.MVC.Models
{
    public class Inputs
    {
        public ICollection<IInput> InputList { get; set; } = new List<IInput>();
    }
}
