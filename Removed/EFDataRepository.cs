// using System.Linq;

// namespace LoggerPLC.Models
// {
//     public class EFDataRepository : IDataRepository
//     {
//         private LoggerPLCDbContext context;
//         public EFDataRepository(LoggerPLCDbContext ctx)
//         {
//             context = ctx;
//         }
//         public IQueryable<Data> Datas => context.Datas;
//     }
// }