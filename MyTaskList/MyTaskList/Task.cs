namespace MyTaskList
{
    using System;

    /// <summary>
    /// Defines the <see cref="Task" />
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Defines the taskID
        /// </summary>
        private readonly string taskID;

        /// <summary>
        /// Defines when the task was created
        /// </summary>
        private readonly DateTime taskCreated;

        /// <summary>
        /// Gets or sets a value indicating whether task is Done
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the DueDate
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets the ID
        /// </summary>
        public string ID { get => taskID; }

        /// <summary>
        /// Gets the GetDateCreated
        /// </summary>
        public DateTime GetDateCreated { get => taskCreated; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Task"/> class.
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        public Task(string id, bool alreadyDone)
        {
            taskID = id;
            taskCreated = DateTime.UtcNow;
            Done = alreadyDone;
        }
    }
}
