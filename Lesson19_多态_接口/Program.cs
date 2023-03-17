using Lesson19_多态_接口;

namespace Lesson19_多态_接口
{    //练习一
    class Person : IRegister
    {
        public void Register()
        { 
            Console.WriteLine("去派出所登记");
        }

    }
    class Car : IRegister
    {
        public void Register()
        {
            Console.WriteLine("去车管所登记");
        }
    }
    class House : IRegister
    {
        public void Register()
        {
            Console.WriteLine("去房管局登记");
        }
    }
    interface IRegister
    {
        public void Register();
    }
    //练习二
    interface IFly
    {
    }
    interface IWalk
    {
    }
    interface ISwim
    {

    }
    class Sparrow : IWalk , IFly
    {
    }
    class Ostrich : IWalk
    {
    }
    class Penguin : IWalk , ISwim
    {
    }
    class Parrot : IWalk, IFly
    {

    }
    class Helicopter : IFly
    {

    }
    class Swan : IWalk, IFly, ISwim
    {

    }
    //练习三
    //存储设备 - Storage device 播放设备 - Playback device 移动硬盘 - Portable hard drive U盘 - USB flash drive
    interface IUSB
    {

    }
    abstract class Playback
    {
        public abstract void DataTrans1();
    }
    abstract class Storage
    {
        public abstract void DataTrans2();
    }
    class PortableHardDrive : Storage , IUSB
    {
        public override void DataTrans2() { Console.WriteLine("移动硬盘数据传输"); }
    }
    class USBFlashDrive : Storage , IUSB
    {
        public override void DataTrans2() { Console.WriteLine("U盘数据传输"); }
    }
    class MP3 : Playback , IUSB
    {
        public override void DataTrans1() { Console.WriteLine("MP3数据传输"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多态 接口");

            //练习三
            MP3 mP3 = new MP3();
            mP3.DataTrans1();
            USBFlashDrive uSBFlashDrive = new USBFlashDrive();
            uSBFlashDrive.DataTrans2();
            PortableHardDrive portableHardDrive = new PortableHardDrive();
            portableHardDrive.DataTrans2();

            //练习二


            //练习一
            Person p = new Person();
            p.Register();
            Car p2 = new Car();
            p2.Register();
            House p3 = new House();
            p3.Register();


        }
    }
}