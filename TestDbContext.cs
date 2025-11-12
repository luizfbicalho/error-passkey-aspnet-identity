using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test.Query.Error
{
    public class TestDbContext : IdentityDbContext<Identity, Role, int>
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }

    }

    public class TestDbContext2 : IdentityDbContext<Identity, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken, UserPassKey>
    {
        public TestDbContext2(DbContextOptions<TestDbContext2> options) : base(options) { }

    }

    public class TestDbContext3 : IdentityDbContext<Identity, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken, UserPassKey>
    {
        public TestDbContext3(DbContextOptions<TestDbContext3> options) : base(options) { }

        public DbSet<UserPassKey> MyUserPasskeys { get; set; }

    }

    public class UserPassKey : IdentityUserPasskey<int>
    {
    }

    public class UserToken : IdentityUserToken<int>


    {
    }

    public class RoleClaim : IdentityRoleClaim<int>


    {
    }

    public class UserLogin : IdentityUserLogin<int>

    {
    }

    public class UserRole : IdentityUserRole<int>
    {
    }

    public class UserClaim : IdentityUserClaim<int>
    {
    }

    public class Role : IdentityRole<int>
    {
    }

    public class Identity : IdentityUser<int>
    {
    }

}
