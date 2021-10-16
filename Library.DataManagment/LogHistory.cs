using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataManagment
{
    class LogHistory
    {
        private List<Log> _logList;

        private int _generatedID = 0;
        public LogHistory()
        {
            _logList = new List<Log>();
        }

        public int Add(Log log)
        {
            _generatedID++;
            log.Id = _generatedID;
            _logList.Add(log);
            return log.Id;
        }

        public void Delete(int Id)
        {
            int index = GetIndexById(Id);
            if (index == -1)
            {
                throw new Exception("Log Id not found");
            }
            _logList.RemoveAt(index);
        }
        private int GetIndexById(int Id)
        {
            for (int i = 0; i < _logList.Count; i++)
            {
                if (_logList[i].Id == Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
