using Data.Context;
using Moq;
using System;
using Xunit;
using Models;
using Logic;
using System.Collections.Generic;
using Data;
using FluentAssertions;
using Autofac.Extras.Moq;
using MemoryContext.Context;
using MemoryContext;


namespace Logic_UnitTest
{
    public class AdminLogic_Test
    {
        //[Fact]
        //public void AddProduct_test()
        //{
        //    //Arrange
        //    //string ProductName
        //    //string ProductDescription
        //    //int ProductPrijs
        //    //string ProductCode
        //    //int QuantityInStock
        //    //string Productimagelink
        //    var mock = new Mock<IAdminContext>();
        //    //Act

        //    //Assert
        //}
        //private List<Product> Products()
        //{
        //    List<Product> output = new List<Product>
        //    {
        //        new Product { ProductName = "HI1"},
        //        new Product { ProductName = "HI2"}
        //    };
        //    return output;

        //}
        //[Fact]
        //public void GetAllProducts1_test()
        //{
        //    using (var moc = AutoMock.GetLoose())
        //    {
        //        moc.Mock<AdminLogic>()
        //            .Setup(x => x.GetAllProducts()).Returns(Products());
        //        var cls = moc.Create<AdminContext>();
        //        var expected = Products();
        //        var actual = cls.GetAllProducts();

        //        Assert.True(actual != null);
        //        Assert.Equal(expected.Count, actual.Count);
        //    }

        //        throw new NotImplementedException();
        //    //Arrange
        // //   var ListOfProducts = new List<Product>();
        // //   ListOfProducts.Add(new Product { ProductName = "Test1", ProductDescription = "Good Test", ProductPrijs = 10 });

        // //   //Mock<AdminLogic> mocAdmin = new Mock<AdminLogic>();
        // //   AdminLogic logic = new AdminLogic();
        // //  //mocAdmin.Setup(x => x.GetAllProducts()).Returns(ListOfProducts);
        // //// var AdminLogic = new AdminRepository(mocAdmin.Object);
        // // // AdminLogic obj = new AdminLogic();
        // // //logic.GetAllProducts.retur
        // //   //Act

        // //   Assert.Equal(mocAdmin., ListOfProducts);
        // //   //Assert
        //}
        //[Fact]
        //public void GetAllProducts_test()
        //{
        //    AdminLogic admin = new AdminLogic();
        //   // AdminRepo_MemoryContext ex = new AdminRepo_MemoryContext(new AdminRepo_MemoryContext());


        //   //var exp =  ex
        //}



    }
}
