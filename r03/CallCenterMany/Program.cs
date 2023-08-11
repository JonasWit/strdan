/* Plik przykładowy do rozdziału 3 - Stosy i kolejki. */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace CallCenterMany
{
    class Program
    {
        static void Main(string[] args)
        {
            CallCenter center = new CallCenter();
            Parallel.Invoke(
                () => CallersAction(center),
                () => ConsultantAction(center, "Marcin", ConsoleColor.Red),
                () => ConsultantAction(center, "Jakub", ConsoleColor.Yellow),
                () => ConsultantAction(center, "Oliwia", ConsoleColor.Green));
        }

        private static void CallersAction(CallCenter center)
        {
            Random random = new Random();
            while (true)
            {
                int clientId = random.Next(1, 10000);
                int waitingCount = center.Call(clientId);
                Log($"Połączenie przychodzące od klienta {clientId}, liczba oczekujących w kolejce: {waitingCount}");
                Thread.Sleep(random.Next(1000, 5000));
            }
        }

        private static void ConsultantAction(CallCenter center, string name, ConsoleColor color)
        {
            Random random = new Random();
            while (true)
            {
                IncomingCall call = center.Answer(name);
                if (call != null)
                {
                    Console.ForegroundColor = color;
                    Log($"Połączenie #{call.Id} od klienta {call.ClientId} odebrał(a) {call.Consultant}.");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Thread.Sleep(random.Next(1000, 10000));
                    center.End(call);

                    Console.ForegroundColor = color;
                    Log($"Połączenie #{call.Id} z klientem {call.ClientId} zakończył(a) {call.Consultant}.");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Thread.Sleep(random.Next(500, 1000));
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private static void Log(string text)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {text}");
        }
    }
}
