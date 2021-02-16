using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        // Visual studio has its own built in test runner (nto related to  [fact])
        [Fact]
        public void BookCalculatesStats()
        {
            // arrange section
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act secion - invoke a method to do something
            // var avgResult = book.printAvg();
            // var lowResult = book.printLow();
            // var highResult = book.pringHigh();
            var result = book.GetStatistics();

            // Assert section - where you assert what was calcluated in the app
            Assert.Equal(85.6 ,result.Average, 1);
            Assert.Equal(90.5 ,result.High,1);
            Assert.Equal(77.3 ,result.Low,1);
        //    the third argument is the precision of the decimal (1 means a number to one decimal point)
        }
    }
}
