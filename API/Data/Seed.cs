using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedUsers(DataContext context)
        {
            if(await context.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);

            foreach(var user in users)
            {
                using var hmac = new HMACSHA512();

                user.UserName = user.UserName.ToLower();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));
                user.PasswordSalt = hmac.Key;

                context.Users.Add(user);
            }

            await context.SaveChangesAsync();
        }

        public static async Task SeedPilot(DataContext context)
        {
            var pilotData = await System.IO.File.ReadAllTextAsync("Data/PilotSeedData.json");
            var pilots = JsonSerializer.Deserialize<List<Pilot>>(pilotData);
            
            foreach(var pilot in pilots)
            {
                
                context.Pilots.Add(pilot);
            }

            await context.SaveChangesAsync();
        }

/*
        public static async Task SeedPilotCards(DataContext context)
        {
            var pilotCardData = await System.IO.File.ReadAllTextAsync("Data/PilotCardSeedData.json");
            var pilotCardsIn = JsonSerializer.Deserialize<List<PilotCard>>(pilotCardData);

            foreach(var pilotCard in pilotCardsIn)
            {
                pilotCard.Name = pilotCard.Name; //is this what we want?
                pilotCard.

            }


            await context.SaveChangesAsync();
        }
        */




    }
}