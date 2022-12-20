//請設計一套系統，這個系統是關於 "交通工具"

//以 "汽車" 為例

//每台汽車有自己的
//1. 廠牌
//2. 排氣量
//3. 型號

//工廠在產生車子的時候，每台車子都會有
//1. 生產序號
//2. 生產時間

//每台車子都有以下行為
//1. Drive - 使用自己的排氣量行駛
//2. Sound - 喊出自己的型號

//請自己設計一套工廠可以製造出各種型號的汽車
//並且讓他在道路上面行駛

//注意有些東西在車子生產出來之後就不能再改

namespace TrafficTool
{
    public class Program
    {
        static void Main(string[] args)
        {
            Toyota vios = new Toyota("Toyota", 2000, "vios");
            vios.Drive();
            vios.Sound();
            vios.getCreateNumber();

            Bmw i8 = new Bmw("BMW", 2000, "i8");
            i8.Drive();
            i8.Sound();
            i8.getCreateNumber();
        }
    }
}