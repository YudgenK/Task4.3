using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task2
    {
        
            public void Run()
            {
                ClassRoom room = new ClassRoom(
                    new ExcellentPupil(),
                    new GoodPupil(),
                    new BadPupil()
                );

                room.ShowPupilsActivities();
            }
        

        class ClassRoom
        {
            private Pupil[] pupils;

            public ClassRoom(params Pupil[] inputPupils)
            {
                pupils = new Pupil[4];

                for (int i = 0; i < 4; i++)
                {
                    if (i < inputPupils.Length)
                        pupils[i] = inputPupils[i];
                    else
                        pupils[i] = new Pupil();
                }
            }

            public void ShowPupilsActivities()
            {
                for (int i = 0; i < pupils.Length; i++)
                {
                    Console.WriteLine($"\nУчень {i + 1}:");
                    pupils[i].Study();
                    pupils[i].Read();
                    pupils[i].Write();
                    pupils[i].Relax();
                }
            }
        }

        class Pupil
        {
            public virtual void Study()
            {
                Console.WriteLine("Навчається.");
            }

            public virtual void Read()
            {
                Console.WriteLine("Читає.");
            }

            public virtual void Write()
            {
                Console.WriteLine("Пише.");
            }

            public virtual void Relax()
            {
                Console.WriteLine("Відпочиває.");
            }
        }

        class ExcellentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Навчається відмінно.");
            }

            public override void Read()
            {
                Console.WriteLine("Читає багато.");
            }

            public override void Write()
            {
                Console.WriteLine("Пише ідеально.");
            }

            public override void Relax()
            {
                Console.WriteLine("Рідко відпочиває.");
            }
        }

        class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Навчається добре.");
            }

            public override void Read()
            {
                Console.WriteLine("Читає регулярно.");
            }

            public override void Write()
            {
                Console.WriteLine("Пише з невеликими помилками.");
            }

            public override void Relax()
            {
                Console.WriteLine("Відпочиває помірно.");
            }
        }

        class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Погано навчається.");
            }

            public override void Read()
            {
                Console.WriteLine("Майже не читає.");
            }

            public override void Write()
            {
                Console.WriteLine("Пише з багатьма помилками.");
            }

            public override void Relax()
            {
                Console.WriteLine("Постійно відпочиває.");
            }
        }

   

    }

}


