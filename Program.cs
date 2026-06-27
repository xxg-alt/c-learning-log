using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Linq;

namespace 学习2._0
{
    public interface IAudio 
    {
        void Bofang();
    }
    public interface IUsb 
    {
        void Open();
        void Close();
        void Shuru();
    }
    public class Yp:IUsb 
    { 
        public void Open()
        {
            Console.WriteLine("硬盘打开");
        }
        public void Shuru()
        {
            Console.WriteLine("硬盘传输中");
        }
        public void Close()
        {
            Console.WriteLine("硬盘关闭");
        }
    }
    public class UP : IUsb
    {
        public void Open()
        {
            Console.WriteLine("U盘打开");
        }
        public void Shuru()
        {
            Console.WriteLine("U盘传输中");
        }
        public void Close()
        {
            Console.WriteLine("U盘关闭");
        }
    }
    public class MP3:IUsb,IAudio
    {
        public void Open()
        {
            Console.WriteLine("MP3打开");
        }
        public void Shuru()
        {
            Console.WriteLine("MP3传输中");
        }
        public void Close()
        {
            Console.WriteLine("MP3关闭");
        }
        public void Bofang()
        {
            Console.WriteLine("MP3播放");
        }
    }
    public class Computer
    {
        public void add()
        {
            Console.WriteLine("电脑启动");
        }
        public void Open(IUsb usb)
        {
            usb.Open();
        }
        public void Shuru(IUsb usb)
        {
            usb.Shuru();
        }
        public void Close(IUsb usb)
        {
            usb.Close();
        }
        public void Bofang(IAudio audio)
        {
            audio.Bofang();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Computer computer = new Computer();
            computer.Open(new Yp());
            List<IUsb> usbs = new List<IUsb>();
            usbs.Add(new Yp());
            usbs.Add(new UP());
            usbs.Add(new MP3());
            IAudio audio = new MP3();
            computer.add();
            foreach (var item in usbs)
            {

                if (item != null && item is MP3)
                {
                    computer.Open(item);
                    computer.Shuru(item);
                    computer.Close(item);

                }
                else if (item != null && item is UP)
                {

                }
            }
            //computer.Bofang(audio);
            ////IUsb[] arr =
            ////{
            ////    new Yp(),
            ////    new UP(),
            ////    new MP3(),
            ////};
        }
    }
}