using System;
using MyTaskList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTaskListUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateTask()
        {
            TaskList listOfTasks = new TaskList();

            Assert.IsTrue(listOfTasks.CreateTask("Title", "Some text ddfjdfjdfjdfjdjfdfj", DateTime.UtcNow));
            Assert.AreEqual(listOfTasks.GetTaskListLenght(), 1);
        }

        [TestMethod]
        public void ReadTaskData()
        {
            TaskList listOfTasks = new TaskList();

            Assert.IsTrue(listOfTasks.CreateTask("Title", "Some text ddfjdfjdfjdfjdjfdfj", DateTime.UtcNow));
            Assert.AreEqual(listOfTasks.GetTaskData(0).Title, "Title");
        }

        [TestMethod]
        public void DeleteTask()
        {
            TaskList listOfTasks = new TaskList();

            Assert.IsTrue(listOfTasks.CreateTask("Title", "Some text ddfjdfjdfjdfjdjfdfj", DateTime.UtcNow));
            Assert.IsTrue(listOfTasks.DeleteTask(0));
            Assert.AreEqual(listOfTasks.GetTaskListLenght(), 0);
        }
    }
}
