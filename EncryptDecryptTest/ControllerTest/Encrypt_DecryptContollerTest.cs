using AutoFixture.Xunit2;
using Encr_Decr.Controllers;
using Encr_Decr.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encr_DecrTest.ContollerTest
{
    public class Encrypt_DecryptContollerTest
    {
        [Theory]
        [AutoData]
        public void Encrypt_ReturnsOkResult_WithEncryptedValue(string value)
        {
            // Arrange
            var controller = new Encrypt_DecryptContoller();
            var data = new EncrDecrVM
            {
                Value = value
            };

            // Act
            var result = controller.Encrypt(data);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.IsType<string>(okResult.Value);
        }

        [Fact]
        public void Decrypt_ReturnsDecryptedValue()
        {
            // Arrange
            var controller = new Encrypt_DecryptContoller();
            var data = new EncrDecrVM() { Value = "Rqcd3qNw0/LhYzIMsD8ofSgn5vGysgIXBJENxUWKDVs=" };

            // Act
            var result = controller.Decrypt(data);

            // Assert
            Assert.IsType<ActionResult<string>>(result);
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var decryptedValue = Assert.IsType<string>(okResult.Value);
            Assert.Equal("This is a test s", decryptedValue);
        }

    }
}
