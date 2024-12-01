using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Promise.Converter
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    internal sealed class ContentPropertyAttribute : Attribute
    {
        public ContentPropertyAttribute() { }

        public ContentPropertyAttribute(string name)
        {
            Name = name;
        }

        public string? Name { get; set; }
    }
}
