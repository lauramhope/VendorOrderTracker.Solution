using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Title", "Test Description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]

    public void GetTitleAndDescription_ReturnsTitleAndDescription_String()
    {
      string title = "Test Title";
      string description = "Test Description";
      Order newOrder = new Order(title, description);
      string resultTitle = newOrder.Title;
      string resultDescription = newOrder.Description;
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(description, resultDescription);
    }

    [TestMethod]
    public void SetTitleAndDescription_SetTitleAndDescription_String()
    {
      string title = "Test Title";
      string description = "Test Description";
      Order newOrder = new Order(title, description);
      string updatedTitle = "Updated Title";
      string updatedDescription = "Updated Description";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;
      string resultTitle = newOrder.Title;
      string resultDescription = newOrder.Description;
      Assert.AreEqual(updatedTitle, resultTitle);
      Assert.AreEqual(updatedDescription, resultDescription);
    }
  }
}