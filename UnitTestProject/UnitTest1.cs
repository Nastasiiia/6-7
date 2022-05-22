using BLL;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System.Reflection;
using DAL;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void GetSeasonDishes()
        {
            // Arrange
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var Test = kernel.Get<IUOW>();
            Process Data = new Process(Test);

            // Act
            var Result = Data.GetSeasonDishes();

            // Assert
            TestContext.WriteLine(Result);
            Assert.IsNotNull(Result);

        }

        [TestMethod]
        public void GetTypeDishes()
        {
            // Arrange
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var Test = kernel.Get<IUOW>();
            Process Data = new Process(Test);

            // Act
            var Result = Data.GetTypeDishes();

            // Assert
            TestContext.WriteLine(Result);
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void Exists()
        {
            // Arrange
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var Test = kernel.Get<IUOW>();
            Process Data = new Process(Test);

            // Act
            var Result = Data.GetSeasonDishes();

            // Assert
            TestContext.WriteLine(Result);
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void Order()
        {
            // Arrange
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var Test = kernel.Get<IUOW>();
            Process Data = new Process(Test);

            // Act
            var Result = Data.GetSeasonDishes();

            // Assert
            TestContext.WriteLine(Result);
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void CreateOrder()
        {
            // Arrange
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var Test = kernel.Get<IUOW>();
            Process Data = new Process(Test);

            // Act
            var Result = Data.CreateOrder("[{\"Id\":\"0\",\"Name\":\"Борщ\",\"OrderId\":\"0\"}]");

            // Assert
            TestContext.WriteLine(Result);
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void RemoveOrder()
        {
            // Arrange
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var Test = kernel.Get<IUOW>();
            Process Data = new Process(Test);

            // Act
            var Result = Data.RemoveOrder("[{\"Id\":\"0\",\"Name\":\"Борщ\",\"OrderId\":\"0\"}]");

            // Assert
            TestContext.WriteLine(Result);
            Assert.IsNotNull(Result);
        }
    }
}
