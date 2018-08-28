using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LoggerPLC.Models
{
    public class EFRepository : IRepository
    {
        private LoggerPLCDbContext context;
        public EFRepository(LoggerPLCDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Data> Datas => context.Datas;
        public IQueryable<Error> Errors => context.Errors.Include(p => p.Task);
        public IQueryable<Task> Tasks => context.Tasks;

        public void DeleteTask(int id)
        {
            context.Errors.RemoveRange(context.Errors.Where(p => p.Task.TaskID == id).ToList());
            context.Datas.RemoveRange(context.Datas.Where(p => p.Task.TaskID == id).ToList());
            context.Tasks.Remove(context.Tasks.First(p => p.TaskID == id));
            context.SaveChanges();
        }
        public void EditTask(Task task)
        {
            context.Tasks.Update(task);
            context.SaveChanges();
        }
        public void CreateTask(Task task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public void DeleteError(int id)
        {
            context.Errors.Remove(context.Errors.First(p => p.ErrorID == id));
            context.SaveChanges();
        }
    }
}