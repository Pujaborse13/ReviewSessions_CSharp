using ReviewSession_4;

namespace TextProject
{

    
    public class Tests
    {
        private UserRegistration ur;
        [SetUp]
        public void Setup()
        {
            ur = new UserRegistration();
        }


        [Test]
        public void ValidUserName()
        {
            string name1 = "Puja Borse";  //T
            string name2 = "Puja Borse 13"; //F

            bool result1 = ur.ValidateUserName(name1);
            bool result2 = ur.ValidateUserName(name2);

            Assert.IsTrue(result1);
            //Assert.IsTrue(result2);

        }


        [Test]
        public void ValidEmailId()
        {
            string email1 = "pujaborse13@gmail.com";  //T
            string email2 = "PujaBorse@^134@gmail.com";  //F

            bool result1 = ur.ValidateEmail(email1);
            bool result2 = ur.ValidateEmail(email2);

            Assert.IsTrue(result1);
            //Assert.IsTrue(result2);

        }


        [Test]
        public void ValidAge()
        {
            string age1 = "19";
            string age2 = "100";

            bool result1 = ur.ValidateAge(age1);  //T
            bool result2 = ur.ValidateAge(age2);   //F

            Assert.IsTrue(result1);
            //Assert.IsTrue(result2);
               
        }
    }
}