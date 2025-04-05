using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task4
    {
        public void Run()
        {
            string licenseKeyPro = "1234";
            string licenseKeyExp = "1235";
            Console.WriteLine("Введіть ліцензійний ключ або натисніть ентер");
            string key = Console.ReadLine();

            DocumentWorker worker;
            if (key == licenseKeyPro)
            {
                worker = new ProDocumentWorker();
            }
            else if (key == licenseKeyExp)
            {
                worker = new ExpertDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
       
    }
     class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа у версії Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа у версії Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }
        public override void EditDocument() 
        {
            Console.WriteLine("Документ відредаговано");
        }
        public override void SaveDocument() 
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
        }
    }

    class ExpertDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматі");
        }
    }

}

