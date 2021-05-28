using System;
using Xunit;
using LISTED.Adapter;
using LISTED.Plugin;
using LISTED.Kern;

namespace LISTED_Testing
{
    public class IoHandler_Test
    {
        InputHandler myHandler = new InputHandler();
        [Fact]
        public void int_InputHandler_CheckDatabase()
        {
            //arrange
            var TestVar = 0;
            //act
            var result = myHandler.int_InputHandler_CheckDatabase("Was!");
            //assert //mehrere au 
            Assert.Equal(TestVar, result);

        }
    }
}
