namespace MyTaskList
{
    using System;

    /// <summary>
    /// Defines the <see cref="ITaskListInterface" />
    /// </summary>
    internal interface ITaskListInterface
    {
        /// <summary>
        /// Creates a new task
        /// </summary>
        /// <param name="title">Task title<see cref="string"/></param>
        /// <param name="description">Task description<see cref="string"/></param>
        /// <param name="DueDate">Dae when task is due<see cref="DateTime"/></param>
        /// <param name="done">Is task done<see cref="bool"/></param>
        /// <returns>Boolean value depending on success <see cref="bool"/></returns>
        bool CreateTask(string title, string description, DateTime DueDate, bool done = false);

        /// <summary>
        /// Deletes a task
        /// </summary>
        /// <param name="id">Task id<see cref="string"/></param>
        /// <returns>Boolean value depending on success <see cref="bool"/></returns>
        bool DeleteTask(string id);

        /// <summary>
        /// Deletes a task
        /// </summary>
        /// <param name="index">List index<see cref="string"/></param>
        /// <returns>Boolean value depending on success <see cref="bool"/></returns>
        bool DeleteTask(int index);

        /// <summary>
        /// Gets the data of a task
        /// </summary>
        /// <param name="id">Task id<see cref="string"/></param>
        /// <returns>The Task instance<see cref="Task"/></returns>
        Task GetTaskData(string id);

        /// <summary>
        /// Gets the data of a task
        /// </summary>
        /// <param name="index">list index<see cref="string"/></param>
        /// <returns>The Task instance<see cref="Task"/></returns>
        Task GetTaskData(int index);

        /// <summary>
        /// Size of the task list
        /// </summary>
        /// <returns>The size as <see cref="int"/></returns>
        int GetTaskListLenght();
    }
}
