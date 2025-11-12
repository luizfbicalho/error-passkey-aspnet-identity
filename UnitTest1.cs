using Microsoft.EntityFrameworkCore;

namespace Test.Query.Error
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var options = new DbContextOptionsBuilder<TestDbContext>()
                .UseSqlite("Filename=:memory:")
                .Options;

            using var context = new TestDbContext(options);
            CreateDatabase(context);

            var query = context.UserPasskeys.ToList();

            Assert.NotNull(query);
        }

        [Fact]
        public void Test2()
        {
            var options = new DbContextOptionsBuilder<TestDbContext2>()
                .UseSqlite("Filename=:memory:")
                .Options;

            using var context = new TestDbContext2(options);
            CreateDatabase(context);

            var query = context.UserPasskeys.ToList();

            Assert.NotNull(query);
        }


        [Fact]
        public void Test4()
        {
            var options = new DbContextOptionsBuilder<TestDbContext3>()
                .UseSqlite("Filename=:memory:")
                .Options;

            using var context = new TestDbContext3(options);
            CreateDatabase(context);

            var query = context.MyUserPasskeys.ToList();

            Assert.NotNull(query);
        }
        [Fact]
        public void Test3()
        {
            var options = new DbContextOptionsBuilder<TestDbContext2>()
                .UseSqlite("Filename=:memory:")
                .Options;

            using var context = new TestDbContext2(options);
            CreateDatabase(context);

            var query = context.RoleClaims.ToList();
            var query2 = context.Roles.ToList();
            var query3 = context.UserClaims.ToList();
            var query4 = context.UserLogins.ToList();
            var query5 = context.UserRoles.ToList();
            var query6 = context.Users.ToList();
            var query7 = context.UserTokens.ToList();

            Assert.NotNull(query);
        }


        private static void CreateDatabase(DbContext context)
        {
            context.Database.OpenConnection();
            context.Database.EnsureCreated();
        }
    }
}
