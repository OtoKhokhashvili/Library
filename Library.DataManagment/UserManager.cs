using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataManagment
{
    class UserManager
    {
        private List<User> _userList;

        private int _generatedID = 0;
        public UserManager()
        {
            _userList = new List<User>();
        }

        public int Add(User user)
        {
            _generatedID++;
            user.Id = _generatedID;
            _userList.Add(user);
            return user.Id;
        }

        public void Delete(int Id)
        {
            int index = GetIndexById(Id);
            if (index == -1)
            {
                throw new Exception("User Id not found");
            }
            _userList.RemoveAt(index);
        }

        public void Edit(User user)
        {
            int index = GetIndexById(user.Id);
            if (index == -1)
            {
                throw new Exception("User Id not found");
            }
            _userList[index] = user;
        }

        private int GetIndexById(int Id)
        {
            for (int i = 0; i < _userList.Count; i++)
            {
                if (_userList[i].Id == Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
