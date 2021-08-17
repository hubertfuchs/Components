using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contexts;

namespace Fuchsbau.Components.Data.FileStorage.Tests
{
    [TestClass]
    public class ProjectContextUnitTests
    {
        [TestMethod]
        public void XXX()
        {
            try
            {
                var projectContext = new ProjectContext();
                var sut = new ProjectRootRepository(projectContext);
                var result = sut.Query();
                var x = new ProjectRoot();
                x.Path = "Test";
                sut.Insert(x);
            }
            catch (Exception e)
            {
                var message = e.Message;
                var x = e.InnerException;
                var y = e.StackTrace;
            }
        }
    }
}
