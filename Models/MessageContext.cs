using Microsoft.EntityFrameworkCore;

namespace Words_from_Strangers.Models
{
    public class MessageContext : DbContext
    {

       public MessageContext(DbContextOptions<MessageContext> options) : base(options) { }

        public DbSet<Message> Messages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creates categories
            modelBuilder.Entity<Message>().HasData(
                new Message { MessageId = 1, DateAdded = DateTime.Now, MessageText = "Hello World", Name = "BDAhearn", Location = "Earth" },
                new Message { MessageId = 2, DateAdded = new DateTime(2020, 1, 5), MessageText = "What's up everyone", Location = "Antartica" },
                new Message { MessageId = 3, DateAdded = new DateTime(2021, 2, 2), MessageText = "Hi, I'm Dave.", Name = "Dave" },
                new Message { MessageId = 4, DateAdded = new DateTime(2020, 3, 8), MessageText = "Honhonhon qui qui", Location = "France" },
                new Message { MessageId = 5, DateAdded = new DateTime(2222, 6, 9), MessageText = "Why am I on mars?", Name = "Bek", Location = "Mars" },
                new Message { MessageId = 6, DateAdded = new DateTime(2023, 4, 17), MessageText = "I can't wait to start this bonfire", Location = "Lordran" },
                new Message { MessageId = 7, DateAdded = new DateTime(2025, 8, 11), MessageText = "I have not seen the sun for a long time. Perhaps I could do with a change... ", Location = "New Londo" },
                new Message { MessageId = 8, DateAdded = new DateTime(2012, 11, 26), MessageText = "Hey guys, I think Im lost" },
                new Message { MessageId = 9, DateAdded = new DateTime(2019, 12, 22), MessageText = "It's great an Earth day is 25 hours long", Name = "Asher", Location = "Universe B" },
                new Message { MessageId = 10, DateAdded = new DateTime(2000, 10, 18), MessageText = "Who am I? Where am I?" },
                new Message { MessageId = 11, DateAdded = new DateTime(2011, 4, 7), MessageText = "All your base are belong to us", Name = "Aila" },
                new Message { MessageId = 12, DateAdded = new DateTime(2014, 6, 6), MessageText = "Have you really been far even as decided to use even go want to do look more like?", Name = "Claire" },
                new Message { MessageId = 13, DateAdded = new DateTime(2018, 5, 5), MessageText = "Where did the geese go", Location = "Canada" },
                new Message { MessageId = 14, DateAdded = new DateTime(2009, 6, 25), MessageText = "The moon is really cool", Name = "Yue", Location = "Mirror Earth" },
                new Message { MessageId = 15, DateAdded = new DateTime(2020, 9, 15), MessageText = "Freedom", Location = "Slightly Better Florida" }
                );
        }
    }
}
