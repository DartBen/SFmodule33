﻿namespace SFmosule33
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public UserRepository()
        {
            _users.Add(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            });

            _users.Add(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Максим",
                LastName = "Максимов",
                Email = "maksim@gmail.com",
                Password = "11",
                Login = "maxim"
            });

            _users.Add(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Антон",
                LastName = "Антонов",
                Email = "anton@gmail.com",
                Password = "111zzxc1",
                Login = "anton"
            });
            _users.Add(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Дмитрий",
                LastName = "Рябов",
                Email = "MyDuck@gmail.com",
                Password = "12345678",
                Login = "DM"
            });
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetByLogin(string login)
        {
            return _users.FirstOrDefault(v => v.Login == login);
        }
    }
}