namespace S00209545_Exam_2022_OOD.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<S00209545_Exam_2022_OOD.RentalPropertyData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "S00209545_Exam_2022_OOD.RentalPropertyData";
        }

        protected override void Seed(S00209545_Exam_2022_OOD.RentalPropertyData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
