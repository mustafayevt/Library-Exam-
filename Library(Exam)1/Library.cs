namespace Library_Exam_1
{
    using global::Library.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Library : DbContext
    {
        // Your context has been configured to use a 'Library' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Library_Exam_1.Library' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Library' 
        // connection string in the application configuration file.
        public Library()
            : base("name=Library")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
    }

}