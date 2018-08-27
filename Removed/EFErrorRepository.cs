// using System.Linq;
// using Microsoft.EntityFrameworkCore;

// namespace LoggerPLC.Models
// {
//     public class EFErrorRepository : IErrorRepository
//     {
//         private LoggerPLCDbContext context;
//         public EFErrorRepository(LoggerPLCDbContext ctx)
//         {
//             context = ctx;
//         }
//         public IQueryable<Error> Errors => context.Errors;
//     }
// }