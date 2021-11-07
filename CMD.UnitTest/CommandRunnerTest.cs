using CMD.Core;
using NUnit.Framework;

namespace CMD.UnitTest
{
    public class CommandRunnerTest
    {
        private CommandRunner _commandRunner;

        [OneTimeSetUp]
        public void Setup()
        {
            var translator = new CommandTranslator();
            _commandRunner = new CommandRunner(translator);
        }

        [Test]
        public void Robot_EmitGreetings()
        {
            //Arrange
            object expected = "Boa tarde", actual;
            var strCommand = "Robot EmitGreetings";

            //Act
            actual = _commandRunner.Run(strCommand);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calc_Subtract()
        {
            //Arrange
            object expected = 5, actual;
            var strCommand = "Calc Subtract 8 3";

            //Act
            actual = _commandRunner.Run(strCommand);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Encrypter_Encrypt()
        {
            //Arrange
            object expected = "amor", actual;
            var strCommand = "Encrypter Encrypt roma";

            //Act
            actual = _commandRunner.Run(strCommand);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}