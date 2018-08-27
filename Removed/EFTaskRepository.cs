// using System.Linq;

// namespace LoggerPLC.Models
// {
//     public class EFTaskRepository : ITaskRepository
//     {
//         private LoggerPLCDbContext context;
//         public EFTaskRepository(LoggerPLCDbContext ctx)
//         {
//             context = ctx;
//         }
//         public IQueryable<Task> Tasks => context.Tasks;
//     }

// }