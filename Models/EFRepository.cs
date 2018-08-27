using System.Collections.Generic;
using System.Linq;

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
        public IQueryable<Error> Errors => context.Errors;
        public IQueryable<Task> Tasks => context.Tasks;

        public void DeleteTask(string id)
        {
            context.Errors.RemoveRange(context.Errors.Where(p => p.Task.TaskName == id).ToList());
            context.Datas.RemoveRange(context.Datas.Where(p => p.Task.TaskName == id).ToList());
            context.Tasks.Remove(context.Tasks.First(p => p.TaskName == id));
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
    }
}