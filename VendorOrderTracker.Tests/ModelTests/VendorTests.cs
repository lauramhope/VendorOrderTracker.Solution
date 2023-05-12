using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor", "Test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorNameAndDescription_ReturnsVendorNameAndDescription_String()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string resultVendorName = newVendor.VendorName;
      string resultVendorDescription = newVendor.VendorDescription;
      Assert.AreEqual(vendorName, resultVendorName);
      Assert.AreEqual(vendorDescription, resultVendorDescription);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName01 = "Test Vendor 1";
      string vendorName02 = "Test Vendor 2";
      string vendorDescription01 = "Test Description 1";
      string vendorDescription02 = "Test Description 2";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName01 = "Test Vendor 1";
      string vendorName02 = "Test Vendor 2";
      string vendorDescription01 = "Test Description 1";
      string vendorDescription02 = "Test Description 2";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}