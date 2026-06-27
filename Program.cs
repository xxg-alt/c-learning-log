using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum E_xin_bie
    {
        man,
        woman,
    }
    enum E_zhi_yei
    {
        zhanshi,
        fashi,
        lieren,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("输入英雄性别男0，女1");
                E_xin_bie a =(E_xin_bie)int.Parse(Console.ReadLine());
                string sex = " ";
                int atk = 0;
                int def = 0;
                switch (a)
                {
                    case E_xin_bie.man:
                        sex = "男";
                        atk += 50;
                        def += 100;
                        break;
                    case E_xin_bie.woman:
                        sex = "女";
                        atk += 150;
                        def += 20;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("输入英雄职业战士0，猎人2，法师1");
                E_zhi_yei o=(E_zhi_yei)int.Parse(Console.ReadLine());
                string e=" ";
                string zhiyei=" ";
                switch (o)
                {
                    case E_zhi_yei.zhanshi:
                        atk += 20;
                        def += 100;
                        e = "冲锋";
                        zhiyei = "战士";
                        break;
                    case E_zhi_yei.fashi:
                        atk += 200;
                        def += 10;
                        e = "奥义冲击";
                        zhiyei = "法师";
                        break;
                    case E_zhi_yei.lieren:
                        atk += 120;
                        def += 30;
                        e = "假死";
                        zhiyei = "猎人";
                        break;
                    default:
                        break;
                }
                Console.WriteLine("你选择了{0}{1}，攻击力为{2},防御力为{3},技能为{4}",sex, zhiyei, atk,def,e);
            }
            catch
            {

                Console.WriteLine("输入数字");
            }

        }
    }
}
