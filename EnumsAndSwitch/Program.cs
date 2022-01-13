﻿using System;
using System.Collections.Generic;


namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string [] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1" , EstimationHours = 6, Status = Status.Completed},
                new Todo { Description = "Task 2" , EstimationHours = 2, Status = Status.InProgress},
                new Todo { Description = "Task 3" , EstimationHours = 8, Status = Status.NotStarted},
                new Todo { Description = "Task 4" , EstimationHours = 12, Status = Status.Deleted},
                new Todo { Description = "Task 5" , EstimationHours = 6, Status = Status.InProgress},
                new Todo { Description = "Task 6" , EstimationHours = 2, Status = Status.NotStarted},
                new Todo { Description = "Task 7" , EstimationHours = 14, Status = Status.Completed},
                new Todo { Description = "Task 8" , EstimationHours = 8, Status = Status.InProgress},
                new Todo { Description = "Task 9" , EstimationHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 10" , EstimationHours = 8, Status = Status.OnHold},
                new Todo { Description = "Task 11" , EstimationHours = 4, Status = Status.NotStarted},
                new Todo { Description = "Task 12" , EstimationHours = 10, Status = Status.Completed},
                new Todo { Description = "Task 13" , EstimationHours = 12, Status = Status.Deleted},
                new Todo { Description = "Task 14" , EstimationHours = 6, Status = Status.Completed},


            };
            Console.ForegroundColor = ConsoleColor.DarkRed;
            PrintAssessment(todos);
            Console.ReadLine();
        }
        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;

                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;

                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;

                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        break;
                   default:

                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimationHours { get; set; }
        public Status Status { get; set; }
    }
    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}