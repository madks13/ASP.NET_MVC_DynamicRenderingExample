using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRenderingExample.MVC.Models
{
    public interface IInput
    {
        string Title { get; }
        object Value { get; set; }
    }
}
