using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Language { get; set; } // English, Deutsch

        public User() 
            : this( Guid.NewGuid() )
        {
        }

        public User( Guid id )
        {
            Id = id;
        }
    }
}
