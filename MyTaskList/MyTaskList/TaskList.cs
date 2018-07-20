namespace MyTaskList
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="TaskList" />
    /// </summary>
    public class TaskList : ITaskListInterface
    {
        /// <summary>
        /// Defines the Tasks
        /// </summary>
        public List<Task> Tasks { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskList"/> class.
        /// </summary>
        public TaskList()
        {
            Tasks = new List<Task>();
        }

        /// <summary>
        /// Create a new task
        /// </summary>
        /// <param name="title">Task title<see cref="string"/></param>
        /// <param name="description">Task description<see cref="string"/></param>
        /// <param name="dueDate">Date when task is due<see cref="DateTime"/></param>
        /// <param name="done">Is task done, deafault is no<see cref="bool"/></param>
        /// <returns>True if task was created, or false if not <see cref="bool"/></returns>
        public bool CreateTask(string title, string description, DateTime dueDate, bool done = false)
        {
            string taskID = Guid.NewGuid().ToString();

            // Better safe than sorry
            if (Tasks.Find(t => t.ID == taskID) == null)
            {
                Task task = new Task(taskID, done)
                {
                    Title = title,
                    Description = description,
                    DueDate = dueDate
                };

                Tasks.Add(task);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Deleted a task
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>True if success, false if not. ArgumentNullException if id was empty <see cref="bool"/></returns>
        public bool DeleteTask(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("Deleting a task failed. Task ID not defined!");
            }

            if (Tasks.Find(t => t.ID == id) != null)
            {
                Tasks.Remove(Tasks.Find(t => t.ID == id));
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Deleted a task
        /// </summary>
        /// <param name="index">List index<see cref="string"/></param>
        /// <returns>True if success. ArgumentOutOfRangeException if index is out of bounds <see cref="bool"/></returns>
        public bool DeleteTask(int index)
        {
            if (Tasks.Count == 0 || index > Tasks.Count - 1 || index < Tasks.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Deleting a task failed. Index is out of range!");
            }

            Tasks.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Get a task
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>Task object if one was found, null otherwise. ArgumentNullException if id was empty <see cref="Task"/></returns>
        public Task GetTaskData(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("Finding a task failed. Task ID not defined!");
            }

            if (Tasks.Find(t => t.ID == id) != null)
            {
                return Tasks.Find(t => t.ID == id);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get a task
        /// </summary>
        /// <param name="index">List index<see cref="string"/></param>
        /// <returns>Task object if one was found, null otherwise. ArgumentOutOfRangeException if index is out of bounds <see cref="Task"/></returns>
        public Task GetTaskData(int index)
        {
            if (Tasks.Count == 0 || index > Tasks.Count - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Finding a task failed. Index is out of range!");
            }

            return Tasks[index];
        }

        /// <summary>
        /// Total number of taska in the list
        /// </summary>
        /// <returns>The number of tasks as <see cref="int"/></returns>
        public int GetTaskListLenght()
        {
            return Tasks.Count;
        }
    }
}
