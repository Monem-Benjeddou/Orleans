using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Abstractions
{
    public class UsersGrain
    {
        public Guid Id { get; set; }
        public List<UserProfile> Users { get; set; }
    }
}
