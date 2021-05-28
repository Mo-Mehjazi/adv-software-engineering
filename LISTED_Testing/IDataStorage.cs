//using System;
//using System.Collections.Generic;
//using System.Text;
//using Test_LISTED.Model;
//using Test_LISTED.Controller;
//using Test_LISTED.View;

//using Moq;

//namespace LISTED_Testing
//{
//    using Moq;

//    // Assumptions:

//    public interface IFoo
//    {
//        IoDatastorage MyIoDatastorage = new IoDatastorage();
//        Bar Bar { get; set; }
//        string Name { get; set; }
//        int Value { get; set; }
//        bool DoSomething(string value);
//        bool DoSomething(int number, string value);
//        Task<bool> DoSomethingAsync();
//        string DoSomethingStringy(string value);
//        bool TryParse(string value, out string outputValue);
//        bool Submit(ref Bar bar);
//        int GetCount();
//        bool Add(int value);
//    }

//    public class Bar
//    {
//        public virtual Baz Baz { get; set; }
//        public virtual bool Submit() { return false; }
//    }

//    public class Baz
//    {
//        public virtual string Name { get; set; }
//    }

    
//    //Mock<IFoo> mockss = new Mock<IFoo>();
//    Mock<IoDatastorage> mockFileWrapper = new Mock<IoDatastorage>();
//    //Mock<T> : Mock, IMock<T> where T : class
//    mock.Setup(foo => foo.DoSomething("ping")).Returns(true);


//    // out arguments
//    var outString = "ack";
//    // TryParse will return true, and the out argument will return "ack", lazy evaluated
//    mock.Setup(foo => foo.TryParse("ping", out outString)).Returns(true);


//    // ref arguments
//    var instance = new Bar();
//    // Only matches if the ref argument to the invocation is the same instance
//    mock.Setup(foo => foo.Submit(ref instance)).Returns(true);


//    // access invocation arguments when returning a value
//    mock.Setup(x => x.DoSomethingStringy(It.IsAny<string>()))
//		.Returns((string s) => s.ToLower());
//    // Multiple parameters overloads available


//    // throwing when invoked with specific parameters
//    mock.Setup(foo => foo.DoSomething("reset")).Throws<InvalidOperationException>();
//mock.Setup(foo => foo.DoSomething("")).Throws(new ArgumentException("command"));


//// lazy evaluating return value
//var count = 1;
//    mock.Setup(foo => foo.GetCount()).Returns(() => count);


//    // async methods (see below for more about async):
//    mock.Setup(foo => foo.DoSomethingAsync().Result).Returns(true);

//}
