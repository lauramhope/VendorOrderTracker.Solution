using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "Test Title 1";
      string title02 = "Test Title 2";
      string description01 = "Test Description 1";
      string description02 = "Test Description 2";
      Order newOrder1 = new Order(title01, description01);
      Order newOrder2 = new Order(title02, description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}