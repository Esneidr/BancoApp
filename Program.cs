using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp
{
    class Banco
    {
        //public void Usuario()
        // Metodo para guarda los nombrese de los usuarios en un vector.
        //{
        //    String[] nombres = new string[3];
        //    int a = 1;

        //    for (int i = 0; i < nombres.Length; i++)
        //    {
        //        Console.WriteLine("Ingrese el nombre del " + a + " Usuario: ");
        //        nombres [i] = Console.ReadLine();
        //        a++;
        //    }
        //    Console.Clear();
        //} 

        int DineroIn = 0, DineroOut = 0, DineroPre = 0, DineroRet = 0, DineroCons = 0;
        string Usu1, Usu2, Usu3;

        public void User()
        {

            Console.WriteLine("Ingrese el nombre del 1er Usuario: ");
            Usu1 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del 2nd Usuario: ");
            Usu2 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del 3er Usuario: ");
            Usu3 = Console.ReadLine();

            Console.Clear();
            EscogerUsuario();
        }
        public void EscogerUsuario()
        {
           
            int menu;

            Console.WriteLine("Escoge un Usuario: ");
            Console.WriteLine("*** " + Usu1 + " ***");
            Console.WriteLine("*** " + Usu2 + " ***");
            Console.WriteLine("*** " + Usu3 + " ***");
            Console.WriteLine("");
            Console.WriteLine("*** Salir ***");

            Console.WriteLine("Escoja un Usuario: ");
            menu = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (menu)
            {
                case 1: Console.WriteLine(Usu1 + " Que deseas hacer hoy: "); Interracion(); break;
                case 2: Console.WriteLine(Usu2 + " Que deseas hacer hoy: "); Interracion(); break;
                case 3: Console.WriteLine(Usu3 + " Que deseas hacer hoy: "); Interracion(); break;
                case 4: Console.WriteLine("Gracias..."); break;
                default: Console.WriteLine("Usuario no registrado: "); break;
            }
        }

        public void Interracion()
        {
            int saldo = 0, prestar = 100000, consignar = 0, retirar = 0;
            int Accion;
            bool correr = true;

            while (correr)
            {
                Console.WriteLine("*** Ver Mi Saldo ***");
                Console.WriteLine("*** Prestar ***");
                Console.WriteLine("*** Consignar ***");
                Console.WriteLine("*** Retirar ***");
                Console.WriteLine("*** Salir ***");

                Console.WriteLine("Escoge una Opcion: ");
                Accion = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (Accion)
                {
                    case 1: Console.WriteLine("Tu saldo es: " + saldo + "$"); break;
                    case 2:
                        Console.WriteLine("Tu cupo de prestamo es de: " + prestar + "$");
                        Console.WriteLine("Cuanto dinero necesitas: ");
                        int pre = int.Parse(Console.ReadLine());

                        if (pre <= prestar)
                        {
                            saldo = pre;
                            Console.WriteLine("Tu nuevo saldo es: " + saldo + "$");
                        }
                        else
                        {
                            Console.WriteLine("Haz paso el limite de tu cupo.");
                        }

                        saldo = pre;
                        prestar -= pre;
                        DineroPre += prestar;
                        break;

                    case 3:
                        Console.WriteLine("Cuanto dinero deseas consignar? ");
                        consignar = int.Parse(Console.ReadLine());

                        saldo = consignar;
                        Console.WriteLine("tu nuevo saldo es: " + saldo + "$");
                        DineroCons += consignar;
                        break;

                    case 4:
                        Console.WriteLine("Cuanto dinero vas a retirar? ");
                        retirar = int.Parse(Console.ReadLine());

                        if (saldo >= retirar)
                        {
                            saldo -= retirar;
                            Console.WriteLine("tu nuevo saldo es: " + saldo + "$");
                        }
                        else
                        {
                            Console.WriteLine("No tienes esa cantidad de dinero, verifica tu cupo.");
                        }
                        DineroRet += retirar;
                        break;

                    case 5: Console.WriteLine("Vuelve pronto.");
                        correr = false;
                        EscogerUsuario();
                        break;
                    default: Console.WriteLine("Esa opcion no existe: "); break;
                }
            }

        }

        public void Actividad()
        {
            int DineroTol = 0;
            DineroOut = DineroPre + DineroRet;
            DineroIn = DineroCons;
            DineroTol = DineroIn - DineroOut;

            Console.WriteLine("El banco recaudo: *** " + DineroIn + "$");
            Console.WriteLine("El banco entrego: *** " + DineroOut + "$");
            Console.WriteLine("En Total: *** " + DineroTol + "$");
        }
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            //banco.Usuario();
            banco.User();
            banco.Actividad();
            Console.ReadKey();
        }
    }
}
