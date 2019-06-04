using Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Logic_UnitTest
{
    public class LProduct_Test
    {
        [Fact]
        public void sum_test()
        {
            LProduct test = new LProduct();
            //Arrange
            int one = 5;
            int two = 6;
            int Expect = 11;

            //Act
            int actual = test.Sum(one, two);

            //Assert
            Assert.Equal(Expect, actual);



        }
    }
}
