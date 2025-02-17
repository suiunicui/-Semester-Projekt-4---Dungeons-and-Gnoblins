﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace DataBase
{
    public class DAL
    {
        public static void SaveGame(Save save)
        {
            var context = new MyDbContext();

            context.Add(save);

            context.SaveChanges();

        }


        public static Save GetSaveByID(int SaveId)
        {
            var Context = new MyDbContext();

            var saves = Context.Saves.Where(s => s.ID == SaveId);

            foreach (var save in saves)
            {
                if (save.ID == SaveId)
                    return save;
            }

            return null;

        }

        public static List<Save> GetAllSaves()
        {
            var Context = new MyDbContext();

            var rooms = Context.Saves.ToList();

            return rooms;

        }


        public static RoomDescription GetRoomDescription(int RDID)
        {
            var Context = new MyDbContext();

            var room = Context.RoomDescriptions.Where(i => i.RoomDescriptionID == RDID).First();

            if (room == null)
            {
                return null;
            }

            return room;

        }
    }
}
