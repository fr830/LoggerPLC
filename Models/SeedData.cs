using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LoggerPLC.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            LoggerPLCDbContext context = app.ApplicationServices.GetRequiredService<LoggerPLCDbContext>();
            context.Database.Migrate();

            if (!context.Errors.Any() & !context.Datas.Any() && !context.Tasks.Any())
            {
                Task t1 = new Task { TaskName = "Task1", IpPLC = "10.10.10.11", TagName = "Tag1", TaskInterval = 21, IsActive = true };
                Task t2 = new Task { TaskName = "Task2", IpPLC = "10.10.10.12", TagName = "Tag2", TaskInterval = 22, IsActive = true };
                Task t3 = new Task { TaskName = "Task3", IpPLC = "10.10.10.13", TagName = "Tag3", TaskInterval = 23, IsActive = true };

                context.Tasks.Add(t1);
                context.Tasks.Add(t2);
                context.Tasks.Add(t3);


                Error e1 = new Error { TaskID = 1, Descryption = "Error 1" };
                Error e2 = new Error { TaskID = 2, Descryption = "Error 2" };
                Error e3 = new Error { TaskID = 3, Descryption = "Error 3" };

                context.Errors.Add(e1);
                context.Errors.Add(e2);
                context.Errors.Add(e3);


                Random rnd = new Random();

                for (int i = 0; i < 100; i++)
                {
                    context.Datas.Add(new Data { Date = DateTime.Now, TaskID = 1, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, TaskID = 2, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, TaskID = 3, Value = rnd.Next(-100, 100) });
                }
                
                context.SaveChanges();
            }
        }
    }
}