﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_DZ__Интерфейсы
{
    internal class TaskManager
    {
        public List<Task> Tasks { get; set; } = new();
        public List<Event> Events { get; set; } = new();
        public void AddTask(Task task) => Tasks.Add(task);
        public void RemoveTaskEvent(string name)
        {
            foreach (var task in Tasks)
            {
                if (task.Name == name)
                {
                    Tasks.Remove(task);
                    break;
                }
            }
            foreach (var @event in Events)
            {
                if (@event.Name == name)
                {
                    Events.Remove(@event);
                    break;
                }
            }
        }
        public int findTask(string name)
        {
            int i = 0;
            foreach (var task in Tasks)
            {
                if (task.Name == name)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public void AddEvent(Event @event) => Events.Add(@event);


        public void Print()
        {
            foreach (var task in Tasks)
            {
                task.Display();
            }
            foreach (var @event in Events)
            {
                @event.Display();
            }
        }
    }
}
