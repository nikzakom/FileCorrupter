using NUnit.Framework;

namespace FileCorrupter.Tests
{
    [TestFixture]
    public class FileProccessingTests
    {
        [SetUp]
        public void Setup()
        {

        }

        private static byte[] CreateAndInitByteArray(int length, byte value)
        {
            byte[] array = new byte[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
            return array;
        }

        [Test]
        public void InputAndOutputArraysLengthIsEqualTest()
        {
            MainForm form = new MainForm();

            byte[] inputArray = CreateAndInitByteArray(1024, 0x10);

            var outputArray = form.CorruptFile(inputArray);

            Assert.AreEqual(inputArray.Length, outputArray.Length);
        }

        [Test]
        // file size < offset
        [TestCase(10)]
        // filse size > offset
        [TestCase(1024)]
        // file size = offset
        [TestCase(16)]
        public void CorruptFileWithDifferentSizeTest(int fileSize)
        {
            MainForm form = new MainForm();
            byte replacementByte = 0xFF;
            int offset = 16;

            if (fileSize <= offset)
            {
                offset = fileSize / 4;
            }

            byte[] inputArray = CreateAndInitByteArray(fileSize, 0x10);

            var outputArray = form.CorruptFile(inputArray);

            for (int i = 0; i < offset; i++)
            {
                Assert.AreEqual(outputArray[i], replacementByte);
            }

            // byte with idx [offset + 1] should not be changed
            Assert.AreEqual(outputArray[offset + 1], 0x10);
        }

    }
}