using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Logic.SecurityManagement.Contract;

namespace Fuchsbau.Components.Logic.SecurityManagement
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(
            IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public void Add(User user)
        {
            _userRepository.Insert(user);
        }

        public User Get(Guid id)
        {
            return _userRepository.Query().Single(x => x.Id == id);
        }

        public IQueryable<User> GetAll()
        {
            return _userRepository.Query();
        }

        public IQueryable<User> GetAllSortedByLastName()
        {
            return _userRepository.Query().OrderBy(x => x.LastName);
        }

        public void Remove(User user)
        {
            _userRepository.Delete(user);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}
