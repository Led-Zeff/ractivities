using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence.Migrations
{
    public class Seed
    {
        public static void SeedData(DataContext context) {
            if (!context.Activities.Any()) {
                var activities = new List<Activity> {
                    new Activity {
                        Title = "Past Activity 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Activity 2 months ago",
                        Category = "Drinks",
                        City = "London",
                        Venue = "Pub"
                    },
                    new Activity {
                        Title = "Past Activity 2",
                        Date = DateTime.Now.AddMonths(-4),
                        Description = "Activity 4 months ago",
                        Category = "Drinks",
                        City = "London",
                        Venue = "Pub"
                    },
                    new Activity {
                        Title = "Past Activity 3",
                        Date = DateTime.Now.AddDays(-2),
                        Description = "Activity 2 days ago",
                        Category = "Drinks",
                        City = "London",
                        Venue = "Pub"
                    },
                    new Activity {
                        Title = "Past Activity 4",
                        Date = DateTime.Now.AddHours(-8),
                        Description = "Activity 8 hours ago",
                        Category = "Drinks",
                        City = "London",
                        Venue = "Pub"
                    }
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}