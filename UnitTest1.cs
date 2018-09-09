using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CallMe.Service;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Collections.Generic;
using CallMe.Models;

namespace UnitTestCallMe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_jsonDeserialize()
        {
            CommonFunctions CF = new CommonFunctions();
            //string msg = @"{id: '1',Message: 'Just 4 test'}";
            string msg = "{'_id': 1, '_msg': 'Test Message'}";
            myMessage myJson = CF.jsonDeserialize(msg);
            myJson.main();
            Debug.Assert( (myJson is null) == true );
        }

        [TestMethod]
        public void Test_jsonSerialize()
        {
            CommonFunctions CF = new CommonFunctions();
            //string msg = @"{id: '1',Message: 'Just 4 test'}";
            string msg = "{'_id': 1, '_msg': 'Test Message'}";
            myMessage myJson = CF.jsonDeserialize(msg);
            myJson.main();

            string strJson = CF.jsonSerialize(myJson);

            Debug.Assert((strJson is null) == true);
        }

    }
}
