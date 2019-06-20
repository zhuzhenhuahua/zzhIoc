using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository;

namespace Repository
{
    public class Task2Repository : ITaskRepository
    {
        public string writeTask()
        {
            return "task2在写任务";
        }
    }
}
