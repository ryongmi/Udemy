using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StartingAndStoppingProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");
            // Process 클래스, Start() 괄호안에 있는 프로세스를 실행한다.

            Process[] notepads = Process.GetProcessesByName("notepad");
            foreach (var process in notepads)
            {
                process.Kill();
            }

            Process[] GetProcess = Process.GetProcesses();
            // GetProcesses() : 현재 로컬에서 실행중인 프로세스 목록 반환
            
            foreach (var process in GetProcess)
            {
                Console.WriteLine(process.Id + " / " + process.ProcessName + " / " + process.MainWindowTitle);
                
            }
        }
    }
}
