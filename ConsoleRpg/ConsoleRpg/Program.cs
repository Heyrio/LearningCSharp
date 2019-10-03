using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg {
    class Program {

        public static Player currentPlayer = new Player();
        static void Main(string[] args) {
            Start();
        }

        static void Start() {
            Console.WriteLine("Console RPG");
            Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a cold dark room, you feel dazed and having trouble \n " +
                "remembering who you are..");
            if (currentPlayer.name.Length == 0) {
                Console.WriteLine("You can't even remember your name.");
            } else { 
                Console.WriteLine("but you know your name is " + currentPlayer.name);

            }
            //Hey this is a comment in C#
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You wander around the darkness untill you find a door handle");
            Console.WriteLine("You  open the door and find a big fucking monster standing in front of you!");
            
        }
    }
}
