namespace ArrayTests
{
    public class ArrayTests

    {
        [Fact]
        public void Array_Count_Test()
        {
            var array = new Array.Array();
            array.Add("Erma");
            array.Add("Ecrin");


            int count = array.Count;


            Assert.Equal(2, count); // (beklenen,gerçek) değer
        }
    }
}