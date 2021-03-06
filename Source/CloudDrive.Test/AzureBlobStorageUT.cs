﻿using CloudDrive.Common;
using CloudDrive.Storage.AzureBlob;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Threading.Tasks;

namespace CloudDrive.Test
{
    [TestClass]
    public class AzureBlobStorageUT : BaseUT
    {
        private AzureBlobStorageClient storage { get; set; }

        [TestInitialize]
        public void Init()
        {
            storage = new AzureBlobStorageClient(AppSettings.Instance.AzureBlobConnectionString);
        }

        //

        [TestMethod]
        public async Task RootContainerCreationTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public async Task SyncSpecificFolderTest()
        {
            string folderPath = "C:\\Temp\\Sync";

            if (Directory.Exists(folderPath))
            {
                foreach (var file in Directory.GetFiles(folderPath))
                {
                    var fileName = Path.GetFileName(file);
                    var fileData = File.ReadAllBytes(file);
                    await storage.UploadAsync(fileData, fileName);
                }

                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}