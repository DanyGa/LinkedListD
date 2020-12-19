using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LinkedListD
{
    class Lista
    {
        LinkedList<int> List = new LinkedList<int>();
        LinkedListNode<int> num;
        Menu regresar = new Menu();

        public void Agregar()
        {
            int op;
            Console.WriteLine("");
            Console.WriteLine(" 1.- Agregar al inicio ");
            Console.WriteLine(" 2.- Agregar al final ");
            Console.WriteLine("");
            Console.Write(" Opcion: ");

            op = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("");
            Console.Write("Inserte un numero: ");
            num = new LinkedListNode<int>(int.Parse(Console.ReadLine()));
            do
            {
                switch (op)
                {
                    //No entran los datos y se borra el count
                    case 1:
                        List.AddFirst(num);                        
                        regresar.Inicio();
                        break;
                    case 2:
                        List.AddLast(num);
                        regresar.Inicio();
                        break;

                }
            } 
            while (op != 3);

        }

        public void Eliminar()
        {
            int select;
            Console.WriteLine("");
            Console.WriteLine(" 1.- Eliminar al inicio ");
            Console.WriteLine(" 2.- Eliminar al final ");
            Console.WriteLine("");
            Console.Write(" Opcion: ");

            
            select = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Menu regresar = new Menu();

            do
            {
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Se borro el primer nodo");
                        List.RemoveFirst();
                        Console.ReadKey();
                        regresar.Inicio();
                        break;
                    case 2:
                        Console.WriteLine("Se borro el ultimo nodo");
                        List.RemoveLast();
                        Console.ReadKey();
                        regresar.Inicio();
                        break;

                }
            }
             while (select != 3);

        }

        public void EliminarL()
        {
            Console.WriteLine("");
            Console.WriteLine("Se borraron todos los elementos de la lista");
            List.Clear();
            Console.ReadKey();
            regresar.Inicio();
        }

        public void Mostrar()
        {
            LinkedListNode<int> reco = List.First;
            while (reco != null)
            {
                Console.WriteLine("");
                Console.WriteLine("Lista: " + List + ", ");
                reco = reco.Next;
            }
            
            Console.ReadKey();
            regresar.Inicio();
        }

        public void Contar()
        {
            if (List.Count > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("La lista tiene: " + List.Count() + " nodos");
            }
            Console.ReadKey();
            regresar.Inicio();
        }

        public void Guardar()
        {
            string ruta = @"C:\Users\DanyG\source\repos\LinkedListD\LinkedListD\Lista.txt";
            using (StreamWriter save = new StreamWriter(ruta))
            {
                foreach (int item in List)
                {
                    save.WriteLine(item + ""); 
                }
            }
            Console.WriteLine("Lista guardada");
            Console.ReadKey();
            regresar.Inicio();
        }

        public void Cargar()
        {
            string ruta = @"C:\Users\DanyG\source\repos\LinkedListD\LinkedListD\Lista.txt";
            string info = File.ReadAllText(ruta);
            Console.WriteLine("Lista: " + info);
            Console.ReadKey();
            regresar.Inicio();
        }
    }
}

