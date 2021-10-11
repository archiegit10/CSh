using System;
using System.Collections;
using System.Collections.Generic;
//using utils;
using DayFour.Animals;
namespace DayFour
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            int[] arr = { 1,2,3};
            IList myArr = new ArrayList(arr);
            ArrayList cars = new ArrayList();
            Car c1 = new Car(4);
            Car c2 = new Car(2);
            cars.Add(c1);
            cars.Add(c2);

            foreach (Car car in cars)
            {
                Console.WriteLine("Car num of doors: " +car.NumOfDoors);
            }

            foreach (var item in myArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count before add: " + myArr.Count);
            myArr.Add(5); // add element of 5
            Console.WriteLine("Count after add: " + myArr.Count);

            myArr.Remove(0); //remove first element
            for(int i = 0; i < myArr.Count; i++)
            {
                Console.WriteLine(myArr[i]);
            }
            */

            /*
            Queue queue = new Queue();

            Car c1 = new Car(5);
            Car c2 = new Car(3);

            queue.Enqueue(c1);
            queue.Enqueue(c2);
      
            Console.WriteLine(((Car)queue.Dequeue()).NumOfDoors);
            //car junkyard 
            Stack stack = new Stack();
            stack.Push(c1);
            stack.Push(c2);

            //returns element from top of stack
            Console.WriteLine($"Junk car with {((Car)stack.Pop())} doors");
            */

            /*
            //generic list of cars
            List<Car> cars = new List<Car>();
            Car c1 = new Car(3);
            Car c2 = new Car(5);
            cars.Add(c1);
            Console.WriteLine(cars[0].NumOfDoors);
            */


            /*
            // stack
            Stack nonGenericStack = new Stack();
            Stack<Car> genericStackOfCars = new Stack<Car>();

            Car c1 = new Car(3);
            Car c2 = new Car(5);

            // not type safe
            nonGenericStack.Push(c1);
            nonGenericStack.Push(10);

            // type safe
            genericStackOfCars.Push(c2);
            //genericStackOfCars.Push(10); //cannot be done as stack can only store car variable

            Console.WriteLine(((Car)nonGenericStack.Pop()).NumOfDoors);
            Console.WriteLine(genericStackOfCars.Pop().NumOfDoors);
            */

            /*
            IList<User> users = new List<User>();
            User u1 = new User("Archie", "Ward","ragweed",22,"wardar");
            User u2 = new User("user2", "u2", "usnick2", 22, "u2@gmail");
            User u3 = new User("user3", "u3", "usnick3", 22, "u3@gmail");
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            foreach(var user in users)
            {
                Console.WriteLine(user.GetInfo());
            }
            */
            /*
            Queue<User> users = new Queue<User>();
            User u1 = new User("Archie", "Ward", "ragweed", 22, "wardar");
            User u2 = new User("user2", "u2", "usnick2", 22, "u2@gmail");
            User u3 = new User("user3", "u3", "usnick3", 22, "u3@gmail");
            users.Enqueue(u1);
            users.Enqueue(u2);
            users.Enqueue(u3);
            for(int i=0; i< users.Count; i++)
            {
                User useratFrontofQueue = users.Dequeue();
                if(useratFrontofQueue != null)
                {
                    i--;
                }
                Console.WriteLine(useratFrontofQueue.GetInfo());
            }
            */
            /*
            //stack junkyard 
            Stack stack = new Stack();
            stack.Push(u1);
            stack.Push(u2);
            stack.Push(u3);
            //returns element from top of stack
            //Console.WriteLine($"Junk car with {((User)stack.Pop())}");
            */

            Animal a = new Animal();
            Fish fish = new Fish();

            fish.Swim();
        }
        
    }
}
