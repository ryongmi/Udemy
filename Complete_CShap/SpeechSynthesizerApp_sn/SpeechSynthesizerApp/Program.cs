using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace SpeechSynthesizerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();

            robot.SelectVoiceByHints(VoiceGender.Female);
            // 음성의 성별을 정함
            robot.Volume = 45;
            robot.Rate = 0;
            // Rate :  말하기 속도, -10 ~ 10 사이의 값

            // robot.Speak("Hello, What is your name?");
            robot.SpeakAsync("Hello, What is your name?");
            // SpeakAsync : 비동기 말하기, 음성이 나오면서 프로그램이 진행됨
            Console.WriteLine("Hello, What is your name?");
            var name = Console.ReadLine();
            robot.SpeakAsync("Hello " + name);
            Console.WriteLine("Hello " + name);

            Console.ReadLine();

            robot.SetOutputToWaveFile(@"c:\sounds\app.wav");
            // SetOutputToWaveFile : 음성파일 저장, 아래에 나온 speak(x) 안에 있는 x를 app.wav로 저장한다. ( 실제 x 음성이 들림 )
            robot.Speak("Application is complete, please visit us again");
        }
    }
}
