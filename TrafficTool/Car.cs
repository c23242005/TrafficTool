using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TrafficTool
{
    public abstract class Car
    {
        /// <summary>
        /// 廠牌
        /// </summary>
        public string logo;
        /// <summary>
        /// 排氣量
        /// </summary>
        public int cc;
        /// <summary>
        /// 型號
        /// </summary>
        public string model;

        /// <summary>
        /// 生產序號
        /// </summary>
        private string createNumber;
        /// <summary>
        /// 生產時間
        /// </summary>
        private string createTime;

        public Car(string logo, int cc, string model)
        {
            this.logo = logo;
            this.cc = cc;
            this.model = model;
            this.createNumber = logo + Guid.NewGuid().ToString();
            this.createTime = logo + model + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff");
        }

        public abstract void Drive();

        public abstract void Sound();

        public void getCreateNumber()
        {
            Console.WriteLine($"我的生產序號是{createNumber}！");
        }

        public void getCreateTime()
        {
            Console.WriteLine($"我的生產時間是{createTime}！");
        }
    }
}
