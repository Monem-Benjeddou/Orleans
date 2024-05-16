//using GloboTicket.Abstractions;
//using GloboTicket.Abstractions.Models;
//using Orleans;
//using Orleans.Runtime;

//namespace GloboTicket.Silo.StartupTasks;

//public class SeedEventsStartupTask : IStartupTask
//{
//    //private readonly IGrainFactory _grainFactory;

//    //public SeedEventsStartupTask(IGrainFactory grainFactory)
//    //{
//    //    _grainFactory = grainFactory;
//    //}

//    //public async Task Execute(CancellationToken cancellationToken)
//    //{
//    //    List<EventDetails> events = GetEventDetailList();
//    //    foreach (var eventDetails in events)
//    //    {
//    //        var eventGrain = _grainFactory.GetGrain<IEventGrain>(eventDetails.Id);
//    //        await eventGrain.CreateEventAsync(eventDetails);
//    //    }
//    //}

//    //private static List<EventDetails> GetEventDetailList()
//    //{
//    //    return new List<EventDetails>
//    //        {
//    //            new EventDetails
//    //            {
//    //                Id = 1,
//    //                Name = "John Egbert Live",
//    //                Price = 65,
//    //                Artist = "John Egbert",
//    //                Date = DateTime.Now.AddDays(6),
//    //                Description =
//    //                    "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
//    //                ImageUrl = "https://lindseybroospluralsight.blob.core.windows.net/globoticket/images/banjo.jpg",
//    //                Category = EventCategory.Concert,
//    //                TotalTickets = 50,
//    //                AvailableTickets = 50
//    //            },
//    //            new EventDetails
//    //            {
//    //                Id = 2,
//    //                Name = "The State of Affairs: Michael Live!",
//    //                Price = 85,
//    //                Artist = "Michael Johnson",
//    //                Date = DateTime.Now.AddMonths(9),
//    //                Description =
//    //                    "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?",
//    //                ImageUrl = "https://lindseybroospluralsight.blob.core.windows.net/globoticket/images/michael.jpg",
//    //                Category = EventCategory.Concert,
//    //                TotalTickets = 100,
//    //                AvailableTickets = 100
//    //            },
//    //            new EventDetails
//    //            {
//    //                Id = 3,
//    //                Name = "Clash of the DJs",
//    //                Price = 85,
//    //                Artist = "DJ 'The Mike'",
//    //                Date = DateTime.Now.AddMonths(4),
//    //                Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
//    //                ImageUrl = "https://lindseybroospluralsight.blob.core.windows.net/globoticket/images/dj.jpg",
//    //                Category = EventCategory.Concert,
//    //                TotalTickets = 100,
//    //                AvailableTickets = 100
//    //            },
//    //            new EventDetails
//    //            {
//    //                Id = 4,
//    //                Name = "Spanish guitar hits with Manuel",
//    //                Price = 25,
//    //                Artist = "Manuel Santinonisi",
//    //                Date = DateTime.Now.AddMonths(4),
//    //                Description = "Get on the hype of Spanish Guitar concerts with Manuel.",
//    //                ImageUrl = "https://lindseybroospluralsight.blob.core.windows.net/globoticket/images/guitar.jpg",
//    //                Category = EventCategory.Concert,
//    //                TotalTickets = 100,
//    //                AvailableTickets = 100
//    //            },
//    //            new EventDetails
//    //            {
//    //                Id = 5,
//    //                Name = "Techorama 2023",
//    //                Price = 400,
//    //                Artist = "Many",
//    //                Date = DateTime.Now.AddMonths(10),
//    //                Description = "The best tech conference in the world",
//    //                ImageUrl = "https://lindseybroospluralsight.blob.core.windows.net/globoticket/images/conf.jpg",
//    //                Category = EventCategory.Conference,
//    //                TotalTickets = 2500,
//    //                AvailableTickets = 2500
//    //            },
//    //            new EventDetails
//    //            {
//    //                Id = 6,
//    //                Name = "To the Moon and Back",
//    //                Price = 135,
//    //                Artist = "Nick Sailor",
//    //                Date = DateTime.Now.AddMonths(8),
//    //                Description =
//    //                    "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.",
//    //                ImageUrl = "https://lindseybroospluralsight.blob.core.windows.net/globoticket/images/musical.jpg",
//    //                Category = EventCategory.Musical,
//    //                TotalTickets = 100,
//    //                AvailableTickets = 100
//    //            }
//    //        };
//    //}

//}
