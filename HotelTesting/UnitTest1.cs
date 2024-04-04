using Hotel;

namespace HotelTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var h = new HotelIgor();
            h.reservedButton.Checked = true;
            Assert.True(h.guestsBox.Items.Count>0);
        }
        public void Test2()
        {
            var h = new HotelIgor();
        }
    }
}