using System.Resources;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();

            //Act
            bool result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCacelledBy_UserCancelling_ReturnsTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();

            //Act
            bool result = reservation.CanBeCancelledBy(reservation.MadeBy = new User());

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            //Arrange
            Reservation reservation = new Reservation();
            User userMadeReservation = new User();
            reservation.MadeBy = userMadeReservation;
            User anotherUser = new User();

            //Act
            bool result = reservation.CanBeCancelledBy(anotherUser);

            //Assert
            Assert.IsFalse(result);

        }
    }
}