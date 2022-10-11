using Roommates.Models;
using Roommates.Repositories;
using System;
using System.Collections.Generic;

namespace Roommates
{
    internal class Program
    {
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true;TrustServerCertificate=True";
        static void Main(string[] args)
        {

        RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);

            Console.WriteLine("Get All Room:");
            Console.WriteLine();

            List<Room> allRooms = roomRepo.GetAll();

            allRooms.ForEach(room => Console.WriteLine($"{room.Name} has an Id of {room.Id} and a max occupancy of {room.MaxOccupancy}"));

            Console.WriteLine("----------------------------");
            Console.WriteLine("Getting Room with Id 1");

            Room singleRoom = roomRepo.GetById(1);

            Console.WriteLine($"{singleRoom.Id} {singleRoom.Name} {singleRoom.MaxOccupancy}");

            Room bathroom = new Room
            {
                Name = "Bathroom",
                MaxOccupancy = 1
            };

            roomRepo.Insert(bathroom);

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Added the new room {bathroom.Name} with an id of {bathroom.Id} ");

            bathroom.MaxOccupancy = 5;
            bathroom.Name = "Sarah's Bathroom";

            roomRepo.Update(bathroom);
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Changed Bathroom to {bathroom.Name}");


            roomRepo.Delete(7);



        }
    }
}
