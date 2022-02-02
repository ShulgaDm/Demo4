//using NUnit.Framework;
//using OpenCartTests.Data;
//using OpenCartTests.Pages;
//using OpenCartTests.Tools;

//namespace OpenCartTests.Tests.Yurii_Kanafotskyi
//{
//    public class CurrencyTests : TestRunner
//    {
//        protected override string OpenCartURL { get => "http://3.85.17.240"; }

//        User user;

//        [OneTimeSetUp]
//        public void BeforeAllMethods()
//        {
//            user = User.CreateBuilder()
//                .SetFirstName("Yurii")
//                .SetLastName("Hoidyk")
//                .SetEMail("email@email.com")
//                .SetTelephone("0637866103")
//                .SetPassword("123456")
//                .Build();
//        }

//        [Test]
//        public void HomePageFirstProductPriceDependingOnCurrency()
//        {
//            string expected = new HomePage(driver).GetFeaturedFirstProductPrice();

//            _ = new HomePage(driver).ChangeCurrencyOnHomePage()
//                                    .GetURL();

//            string actual = new HomePage(driver).GetFeaturedFirstProductPrice();

//            Assert.AreNotEqual(expected, actual);
//        }

//        [Test]
//        public void ProductPagePriceChangingDependingOnCurrency()
//        {
//            _ = new HomePage(driver).GetFirstProductDetails();

//            string expected = new ProductDetailsPage(driver).GetPriceText();

//            _ = new ProductDetailsPage(driver).ChangeCurrencyOnDetailsPage()
//                                              .GetURL();

//            string actual = new ProductDetailsPage(driver).GetPriceText();

//            Assert.AreNotEqual(expected, actual);
//        }

//        //[Test]
//        public void WishListPriceChangingDependingOnCurrency()
//        {
//            _ = new HomePage(driver).GoToLoginPage()
//                                    .SuccessfullLogin(user)
//                                    .GoToHomePage()
//                                    .GetFirstProductDetails()
//                                    .GetURL();

//            _ = new ProductDetailsPage(driver).AddToWishList();

//            _ = new WishListPage(driver).GoToWishPage()
//                                        .GetURL();

//            string expected = new WishListPage(driver).GetWishListFirstProductPrice();

//            _ = new WishListPage(driver).ChangeCurrencyOnWishListPage()
//                                        .GetURL();

//            string actual = new WishListPage(driver).GetWishListFirstProductPrice();

//            Assert.AreNotEqual(expected, actual);
//        }
//    }
//}