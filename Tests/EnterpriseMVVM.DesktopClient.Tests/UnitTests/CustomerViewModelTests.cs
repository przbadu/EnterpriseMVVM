namespace EnterpriseMVVM.DesktopClient.Tests.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ViewModels;
    using Windows;

    [TestClass]
    public class CustomerViewModelTests
    {
        [TestMethod]
        public void IsViewModel()
        {
            Assert.IsTrue(typeof(CustomerViewModel).BaseType == typeof(ViewModel));
        }

        [TestMethod]
        public void ValidationErrorWhenCustomerNameExceeds3Characters()
        {
            var viewModel = new CustomerViewModel
            {
                CustomerName = "1234567890 abcdefghijklmno jkloiqw"
            };

            Assert.IsNotNull(viewModel["CustomerName"]);
        }

        [TestMethod]
        public void ValidationErrorWhenCustomerNameIsNotGreaterThanOrEqual8Characters()
        {
            var viewModel = new CustomerViewModel
            {
                CustomerName = "1234567"
            };
            Assert.IsNotNull(viewModel["CustomerName"]);
        }

        [TestMethod]
        public void ValidationErrorWhenCustomerNameIsNull()
        {
            var viewModel = new CustomerViewModel();
            Assert.IsNotNull(viewModel["CustomerName"]);
        }

        [TestMethod]
        public void ValidationSuccessWhenCustomerNameIsValid()
        {
            var viewModel = new CustomerViewModel { CustomerName = "123456 abcdef" };
            Assert.IsNull(viewModel["CustomerName"]);
        }
    }
}
