﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new BlogContext())
            {
                Console.WriteLine("输入：");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }


                Console.ReadKey();
            }
        }

        public class Blog
        {
            public int BlogID { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
            public virtual List<Post> Posts { get; set; }
        }
        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public int BlogId { get; set; }
            public virtual Blog Blog { get; set; }
        }
        public class BlogContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<User> Users { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().Property(m => m.DisplayName).HasColumnName("display_name");
            }
        }
        public class User
        {
            [Key]
            public string Username { get; set; }
            public string  DisplayName { get; set; }
        }
    }
}
