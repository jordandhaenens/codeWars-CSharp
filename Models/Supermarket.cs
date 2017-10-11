using System;
using System.Collections.Generic;
using System.Linq;

namespace codeWars_CSharp.Models
{
    public class Register
    {
        public List<int> Queue { get; set; }
        public int Timer { get; set; }
    }
    public class Supermarket
    {
        public static int QueueTime(int[] customers, int registers)
        {

            List<int> TotalQTimes = new List<int>();
            List<int> DisposableList = new List<int>(customers);
            List<Register> RegistersList = MakeRegisters(registers);
            int TotalTime = 0;

            // handle zero customer scenario
            if (DisposableList.Count == 0)
            {
                return 0;
            }
            else if (DisposableList.Count <= registers)
            {
                TotalTime = DisposableList.Max();
                return TotalTime;
            }
            else
            {
                // loop through Registers and add each first customer in queue
                for (int i = 0; i < RegistersList.Count; i++)
                {
                    RegistersList[i].Queue.Add(DisposableList[0]);
                    RegistersList[i].Timer = DisposableList[0];
                    DisposableList.RemoveAt(0);
                }

                // Countdown timers and add each first customer in queue as a register's timer == 0
                while (DisposableList.Count != 0)
                {
                    for (int i = 0; i < RegistersList.Count; i++)
                    {
                        if (RegistersList[i].Timer == 0 && DisposableList.Count != 0)
                        {
                            // add new customer to register.queue and register.timer
                            RegistersList[i].Queue.Add(DisposableList[0]);
                            RegistersList[i].Timer = DisposableList[0];
                            // remove 1 unit of time from register.Timer
                            RegistersList[i].Timer -= 1;
                            // remove customer from DisposableList
                            DisposableList.RemoveAt(0);
                        }
                        else
                        {
                            // remove 1 unit of time from register.timer
                            RegistersList[i].Timer -= 1; 
                        }
                    }
                }
                // Sum each register's queue and return the greatest.
                for (int i = 0; i < RegistersList.Count; i++)
                {
                    TotalQTimes.Add(RegistersList[i].Queue.Sum());
                }
                TotalTime = TotalQTimes.Max();

                return TotalTime;
            }

        }

        public static List<Register> MakeRegisters(int registers)
        {
            List<Register> Registers = new List<Register>();
            for (int i = 0; i < registers; i++)
            {
                  Registers.Add(new Register(){Queue = new List<int>()});
            }
            return Registers;
        }
    }
}