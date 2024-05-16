using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Abstractions
{
    [GenerateSerializer, Immutable]
    public record UserProfile
    {
        [Id(0)]
        public string FirstName { get; set; } = string.Empty;

        [Id(1)]
        public string LastName { get; set; } = string.Empty;

        [Id(2)]
        public string Email { get; set; } = string.Empty;

        [Id(3)]
        public string Address { get; set; } = string.Empty;

        [Id(4)]
        public string ZipCode { get; set; } = string.Empty;

        [Id(5)]
        public string City { get; set; } = string.Empty;

        [Id(6)]
        public string Country { get; set; } = string.Empty;
    }

}
