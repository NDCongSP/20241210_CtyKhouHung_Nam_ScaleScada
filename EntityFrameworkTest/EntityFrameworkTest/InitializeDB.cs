using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    public static class InitializeDB
    {
        public static void InitializeDbContext(ApplicationDbContext context)
        {
            //// Ensure the database is created (or already exists), chỉ chạy 1 lần, sau đó nếu có sự thay đổi Entity thì nó ko cập nhật DB, nên nếu bật thì chỉ bật khi chạy runTime
            //context.Database.Create();

            ////chạy migration theo các migration đc tạo trong lúc build code.
            //if (context.Database.().Any())
            //    context.Database.Migrate();
            //context.SaveChanges();
        }
    }
}
