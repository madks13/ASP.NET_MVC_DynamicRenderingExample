using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRenderingExample.MVC.Models
{
    public class BaseInput<T> : IInput
    {
        public virtual string Title => "Base Input";
        protected T TypedValue { get; set; }
        public object Value { get => TypedValue; set => TypedValue = (T)value; }
    }
}
