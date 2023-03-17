namespace 测试专用
{
    interface IUSB
    {
        public abstract void DataTrans();
    }
    abstract class Playback : IUSB
    {
        public virtual void DataTrans() { Console.WriteLine("播放设备数据传输"); }
    }
    abstract class Storage : IUSB
    {
        public virtual void DataTrans() { Console.WriteLine("存储设备数据传输"); }
    }
    class PortableHardDrive : Storage
    {
        public override void DataTrans() { Console.WriteLine("移动硬盘数据传输"); }
    }
    class USBFlashDrive : Storage
    {
        public override void DataTrans() { Console.WriteLine("U盘数据传输"); }
    }
    class MP3 : Playback
    {
        public override void DataTrans() { Console.WriteLine("MP3数据传输"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("测试专用专用程序");

            PortableHardDrive portableHardDrive = new PortableHardDrive();
            portableHardDrive.DataTrans();
        }
    }
}