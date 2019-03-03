using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture.NUnit3;
using NUnit.Framework;

namespace SampleTest
{
    public class User
    {
        public User(int id)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException();
        }
    }

    public class MappedUser
    {
        protected MappedUser(int id, string name)
        {
        }

        public static MappedUser Create()
        {
            return null;
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test, AutoData]
        public void UserTest(User user)
        {
            Assert.That(user, Is.Not.Null);
        }

        [Test, AutoData]
        public void MappedUserTest(MappedUser user)
        {
            Assert.That(user, Is.Not.Null);
        }
    }
}