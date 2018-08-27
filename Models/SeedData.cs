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
                Task t4 = new Task { TaskName = "Task4", IpPLC = "10.10.10.14", TagName = "Tag4", TaskInterval = 24, IsActive = true };
                Task t5 = new Task { TaskName = "Task5", IpPLC = "10.10.10.15", TagName = "Tag5", TaskInterval = 25, IsActive = true };
                Task t6 = new Task { TaskName = "Task6", IpPLC = "10.10.10.16", TagName = "Tag6", TaskInterval = 26, IsActive = true };
                Task t7 = new Task { TaskName = "Task7", IpPLC = "10.10.10.17", TagName = "Tag7", TaskInterval = 27, IsActive = true };
                Task t8 = new Task { TaskName = "Task8", IpPLC = "10.10.10.18", TagName = "Tag8", TaskInterval = 28, IsActive = true };
                Task t9 = new Task { TaskName = "Task9", IpPLC = "10.10.10.19", TagName = "Tag9", TaskInterval = 29, IsActive = true };

                Error e1 = new Error { Task = t1, Descryption = "Error 1" };
                Error e2 = new Error { Task = t2, Descryption = "Error 2" };
                Error e3 = new Error { Task = t3, Descryption = "Error 3" };
                Error e4 = new Error { Task = t4, Descryption = "Error 4" };
                Error e5 = new Error { Task = t5, Descryption = "Error 5" };
                Error e6 = new Error { Task = t6, Descryption = "Error 6" };
                Error e7 = new Error { Task = t7, Descryption = "Error 7" };
                Error e8 = new Error { Task = t8, Descryption = "Error 8" };
                Error e9 = new Error { Task = t9, Descryption = "Error 9" };

                context.Tasks.Add(t1); context.Errors.Add(e1);
                context.Tasks.Add(t2); context.Errors.Add(e2);
                context.Tasks.Add(t3); context.Errors.Add(e3);
                context.Tasks.Add(t4); context.Errors.Add(e4);
                context.Tasks.Add(t5); context.Errors.Add(e5);
                context.Tasks.Add(t6); context.Errors.Add(e6);
                context.Tasks.Add(t7); context.Errors.Add(e7);
                context.Tasks.Add(t8); context.Errors.Add(e8);
                context.Tasks.Add(t9); context.Errors.Add(e9);

                Random rnd = new Random();

                for (int i = 1; i < 100; i++)
                {
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t1, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t2, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t3, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t4, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t5, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t6, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t7, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t8, Value = rnd.Next(-100, 100) });
                    context.Datas.Add(new Data { Date = DateTime.Now, Task = t9, Value = rnd.Next(-100, 100) });
                }

                context.SaveChanges();
            }
        }
    }
}