using System;
using System.Collections.Generic;
using System.Text;
using Task3.DoNotChange;

namespace Task3
{
    public interface IUserTaskService
    {
        int AddTaskForUser(int userId, UserTask task);
    }
}
