using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{

    [TestClass]
    public class ItemsControllerTest
    {
      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        //Arrange
        ItemsController controller = new ItemsController();

        //Act
        ActionResult view = controller.Create("Walk the dog");

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

    }
}
