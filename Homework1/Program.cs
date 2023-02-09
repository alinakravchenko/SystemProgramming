using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading.Channels;



//ЗАДАНИЕ 1. Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функцию
//MessageBox из Windows API. Отобразите с помощью
//MessageBox информацию о вас. Данные должны быть
//показаны в нескольких MessageBox.


//ЗАДАНИЕ 3. Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функции
//Beep и MessageBeep из Windows API. С помощью импортированных функций сгенерируйте набор звуковых
//сигналов через определенные промежутки времени.

namespace Homework1
{
    internal class Program
    {
        public class DllImportExample
        {
            ////унаследованный код, winapi
            //[DllImport("user32.dll")]
            //public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

            [DllImport("Kernel32.dll")]
            public static extern int Beep(uint dwFreq, uint dwDuration);
            [DllImport("User32.dll")]
            public static extern bool MessageBeep(uint type);
        }

        const uint MB_ICONWARNING = 0x0000030;
            const uint MB_CANCELTRYCONTINUE = 0x00000006;
            const uint MB_DEFBUTTON2 = 0x00000100;
            const uint MB_INFORMATION = 64;
            const uint MB_OKCANCEL = 0x00000001;
            const uint MB_YESNO = 0x00000004;
            const uint MB_OK = 0x00000000;
        
        static void Main(string[] args)
        {


            //DllImportExample.MessageBox(IntPtr.Zero, "Кравченко Алина Евгеньевна", "Текстовое сообщение", MB_INFORMATION | MB_OK);
            //DllImportExample.MessageBox(IntPtr.Zero, "Студент компьютерной академии \"ТОП\"", "Текстовое сообщение", MB_INFORMATION | MB_OK);
           
               Console.WriteLine("Включите звук, пожалуйста!");
                DllImportExample.Beep(750, 2000);
                DllImportExample.Beep(1000, 2000);
                DllImportExample.Beep(1500, 2000);
            
            DllImportExample.Beep(2000, 3000);



        }
    }
}