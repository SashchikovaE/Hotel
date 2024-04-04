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
        [Fact]
        public void Test2()
        {
            var h = new HotelIgor();
            h.availableButton.Checked = true;
            Assert.True(h.guestsBox.Items.Count > 0);
        }
        [Fact]
        public void Test3()
        {
            var h = new HotelIgor();
            h.occupiedButton.Checked = true;
            Assert.True(h.guestsBox.Items.Count > 0);
        }
        [Fact]
        public void Test4()
        {
            var h = new HotelIgor();
            h.areDischargedButton.Checked = true;
            Assert.True(h.guestsBox.Items.Count > 0);
        }
    }
}