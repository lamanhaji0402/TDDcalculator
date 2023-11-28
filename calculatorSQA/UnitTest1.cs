namespace calculatorSQA
{
    public class Tests
    {
        private Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void OnePlusOneFail()
        {
            Assert.AreEqual(4,cal.add(1,1));
        }

        [Test]
        public void OnePlusOnePass()
        {
            Assert.AreEqual(2, cal.add(1, 1));
        }
        [Test]
        public void OnePlusZeroPass()
        {
            Assert.AreEqual(1, cal.add(1, 0));
        }
        [Test]
        public void OnePlusZeroFail()
        {
            Assert.AreEqual(0, cal.add(1, 0));
        }
        [Test]
        public void OnePlusNegativeOnePass()
        {
            Assert.AreEqual(0, cal.add(1, -1));
        }
        [Test]
        public void OnePlusNegativeOneFail()
        {
            Assert.AreEqual(2, cal.add(1, -1));
        }
        [Test]
        public void OutOfIntegerPositiveLimitFailForAdd()
        {
            Assert.AreEqual(2147483648, cal.add(2147483647, 1));
            /*gives exception that value cant be returned as integer*/
        }
        [Test]
        public void OutOfIntegerNegativeLimitFailForAdd()
        {
            Assert.AreEqual(-2147483649, cal.add(-2147483648, -1));
            /*gives exception that value cant be returned as integer*/
        }
        [Test]
        public void OneSubtractOnePass()
        {
            Assert.AreEqual(0, cal.subtraction(1, 1));
        }
        [Test]
        public void OneSubtractOneFail()
        {
            Assert.AreEqual(2, cal.subtraction(1, 1));
        }
        [Test]
        public void OneSubtractNegativeOnePass()
        {
            Assert.AreEqual(2, cal.subtraction(1, -1));
        }
        [Test]
        public void OneSubtractNegativeOneFail()
        {
            Assert.AreEqual(0, cal.subtraction(1, -1));
        }
        [Test]
        public void NegativeOneSubtractNegativeOnePass()
        {
            Assert.AreEqual(0, cal.subtraction(-1, -1));
        }
        [Test]
        public void NegativeOneSubtractNegativeOneFail()
        {
            Assert.AreEqual(-2, cal.subtraction(-1, -1));
        }

        [Test]
        public void OutOfIntegerPositiveLimitFailForSubtract()
        {
            Assert.AreEqual(2147483648, cal.add(2147483647, 1));
            /*gives exception that value cant be returned as integer*/
        }
        [Test]
        public void OutOfIntegerNegativeLimitFailForSubtract()
        {
            Assert.AreEqual(-2147483649, cal.add(-2147483648, -1));
            /*gives exception that value cant be returned as integer*/
        }
        [Test]
        public void AddDoubleFail()
        {
            Assert.AreEqual(6.2, cal.add(2.1,4.1));
        }
        [Test]
        public void DivideByZeroPass()
        {
            Assert.Throws<ArgumentException>(() => cal.division(2, 0));
        }
        [Test]
        public void DivideByBigNumFail()
        {
            Assert.AreEqual(0, cal.division(2, 995958943));
        }
        [Test]
        public void DivideByBigNumPass()
        {
            Assert.AreEqual(2.00811501E-09f, cal.division(2, 995958943));
        }
        [Test]
        public void DivideByFloatPass()
        {
            Assert.AreEqual(1.52941167f, cal.division(5.2f, 3.4f));
        }
        [Test]
        public void DivideByFloatFail()
        {
            Assert.AreEqual(0, cal.division(5.2f, 3.4f));
        }

        [Test]
        public void MultiplyFloatsPass()
        {
            double tolerance = 0.0001;
            Assert.AreEqual(17.68, cal.multiply(5.2f, 3.4f),tolerance);
        }
        [Test]
        public void Multiply()
        {
            Assert.AreEqual(79488952611897344.0d, cal.multiply(883909, 89928883929));
        }




    }
}