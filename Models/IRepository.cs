using System.Collections.Generic;
using System.Linq;

namespace LoggerPLC.Models
{
    public interface IRepository
    {
        IQueryable<Data> Datas { get; }
        IQueryable<Error> Errors { get; }
        IQueryable<Task> Tasks { get; }

        void DeleteTask(int id);
        void CreateTask(Task task);
        void EditTask(Task task);
        void DeleteError(int id);
    }
}