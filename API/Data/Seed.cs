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
            if(await context.Pilots.AnyAsync()) return;

            var pilotData = await System.IO.File.ReadAllTextAsync("Data/PilotSeedData.json");
            var pilots = JsonSerializer.Deserialize<List<Pilot>>(pilotData);
            
            foreach(var pilot in pilots)
            {

                context.Pilots.Add(pilot);
            }

            await context.SaveChangesAsync();
        }

        public static async Task SeedRobots(DataContext context)
        {
            if(await context.Robots.AnyAsync()) return;
            
            var robotData = await System.IO.File.ReadAllTextAsync("Data/RobotSeedData.json");
            var robots = JsonSerializer.Deserialize<List<Robot>>(robotData);

            foreach(var robot in robots)
            {
                context.Robots.Add(robot);
            }
            await context.SaveChangesAsync();
        }

        public static async Task SeedPilotAbilities(DataContext context)
        {
            if(await context.PilotAbilities.AnyAsync()) return;

            var pAbilitiesData = await System.IO.File.ReadAllTextAsync("Data/PilotAbilitySeedData.json");
            var pAbilities = JsonSerializer.Deserialize<List<PilotAbility>>(pAbilitiesData);

            foreach(var pAbility in pAbilities)
            {
                context.PilotAbilities.Add(pAbility);
            }
            await context.SaveChangesAsync();
        }

        public static async Task SeedRobotAbilities(DataContext context)
        {
            if(await context.RobotAbilities.AnyAsync()) return;

            var rAbilitiesData = await System.IO.File.ReadAllTextAsync("Data/RobotAbilitySeedData.json");
            var rAbilities = JsonSerializer.Deserialize<List<RobotAbility>>(rAbilitiesData);

            foreach(var rAbility in rAbilities)
            {
                context.RobotAbilities.Add(rAbility);

            }
            await context.SaveChangesAsync();

        }

        public static async Task SeedPilotCards(DataContext context)
        {
            if(await context.PilotCards.AnyAsync()) return;

            var pCardsData = await System.IO.File.ReadAllTextAsync("Data/PilotCardSeedData.json");
            var pCards = JsonSerializer.Deserialize<List<PilotCard>>(pCardsData);

            foreach(var pCard in pCards)
            {
                context.PilotCards.Add(pCard);
            }

            await context.SaveChangesAsync();
        }


        public static async Task SeedRobotCards(DataContext context)
        {
            if(await context.RobotCards.AnyAsync()) return;

            var rCardData = await System.IO.File.ReadAllTextAsync("Data/RobotCardSeedData.json");
            var rCardsIn = JsonSerializer.Deserialize<List<RobotCard>>(rCardData);

            foreach(var rCard in rCardsIn)
            {
                context.RobotCards.Add(rCard);
            }

            await context.SaveChangesAsync();
        }

    }
}