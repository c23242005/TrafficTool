using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficTool
{

    public class Toyota : Car
    {
        public Toyota(string logo, int cc, string model) : base(logo, cc, model)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"我是 Toyota 出廠{cc}CC的車哦！");
        }

        public override void Sound()
        {
            Console.WriteLine($"我是 Toyota - {model}！");
        }
    }
}
