using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Test_LISTED.Controller;
using Test_LISTED.Model;
using Xunit;

namespace LISTED_Testing
{
    public class Storagez
    {
        [Fact]
        public void StorageDate()
        {
            //arrange
            DateTime datetime = DateTime.Today;
            DateTime myDate = new DateTime(2021, 5, 23);
            DateTime myDateBackToTheFuture = new DateTime(2021, 5, 25);

            //act
            Storage.myLocalDate = datetime;

            //assert
            Assert.Equal(myDate, Storage.myLocalDate);
            Assert.NotEqual(myDateBackToTheFuture, Storage.myLocalDate);
        }
    } 
}

