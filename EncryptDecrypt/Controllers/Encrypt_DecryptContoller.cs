using Encr_Decr.ViewModel;
using KTSequencingAPI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Encr_Decr.Controllers
{

    public class Encrypt_DecryptContoller : ControllerBase
    {
        private static string keyString = "E546C8DF278CD5931069B522E695D4F2";
        [HttpPost("encrypt")]
        public ActionResult<string> Encrypt([FromBody] EncrDecrVM DecryptedString)
        {
            string encryptedValue = EncryptOrDecrypt.EncryptString(DecryptedString.Value, keyString);
            return Ok(encryptedValue);
        }

        // POST api/crypto/decrypt
        [HttpPost("decrypt")]
        public ActionResult<string> Decrypt([FromBody] EncrDecrVM EncryptString)
        {
            string decryptedValue = EncryptOrDecrypt.DecryptString(EncryptString.Value, keyString);
            return Ok(decryptedValue);
        }
    }
}
