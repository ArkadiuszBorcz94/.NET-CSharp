﻿using System.Linq;
using TaskMenager.Models;

namespace TaskMenager.Repositories
{
    public interface ITaskRepository
    {

        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActive();
        void Add(TaskModel task);
        void Update(int taskId, TaskModel task);
        void Delete(int taskId);


    }
}
