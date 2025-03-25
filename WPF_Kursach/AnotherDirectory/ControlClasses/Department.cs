using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public class Department
    {
        public string Spec { get; private set; }
        public int WardsCount { get; private set; }
        public int BedsCount { get; private set; }
        public Department(string spec, int wardsCount, int bedsCount)
        {
            this.Spec = spec;
            this.WardsCount = wardsCount;
            this.BedsCount = bedsCount;
        }

    }
}
