using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.RetryPolicies;
using ShiftWorx.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftWorx.Helpers
{
    public class BlobStorageHelper
    {
        public async Task<string> UploadStorageBlobFileAsync(MemoryStream memoryStream, FileAttachment fileAttachment)
        {
            // Retrieve storage account information from connection string
            CloudStorageAccount storageAccount = CreateStorageAccountFromConnectionString();

            // Create a blob client for interacting with the blob service.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Create a container for organizing blobs within the storage account.
            CloudBlobContainer container = blobClient.GetContainerReference(fileAttachment.Container);
            try
            {
                BlobRequestOptions requestOptions = new BlobRequestOptions() { RetryPolicy = new NoRetry() };
                await container.CreateIfNotExistsAsync(requestOptions, null);
                // configure container for public access
                var permissions = await container.GetPermissionsAsync();
                permissions.PublicAccess = BlobContainerPublicAccessType.Blob;
                await container.SetPermissionsAsync(permissions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // List all the blobs in container
            BlobContinuationToken blobContinuationToken = null;
            do
            {
                var results = await container.ListBlobsSegmentedAsync(null, blobContinuationToken);
                // Get the value of the continuation token returned by the listing call.
                blobContinuationToken = results.ContinuationToken;
                foreach (IListBlobItem item in results.Results)
                {
                    if (item.Uri.ToString().Contains(fileAttachment.BlobId))
                    {
                        return item.Uri.AbsoluteUri;
                    }
                }
            } while (blobContinuationToken != null); // Loop while the continuation token is not null.

            // Referencing the file to the new container
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(fileAttachment.BlobId);

            if (!string.IsNullOrEmpty(fileAttachment.FileExt))
            {
                if (string.IsNullOrEmpty(fileAttachment.BlobId))
                {
                    blockBlob = container.GetBlockBlobReference(fileAttachment.Container + "." + fileAttachment.FileExt);
                }
                else
                {
                    blockBlob = container.GetBlockBlobReference(fileAttachment.BlobId + "." + fileAttachment.FileExt);
                }
                //blockBlob = container.GetBlockBlobReference(blobId + "." + ext);
                blockBlob.Properties.ContentType = fileAttachment.ContentType;
            }

            int blockSize = 1024 * 1024;

            long fileSize = memoryStream.Length;

            //block count is the number of blocks + 1 for the last one
            int blockCount = (int)((float)fileSize / (float)blockSize) + 1;

            //List of block ids; the blocks will be committed in the order of this list
            List<string> blockIDs = new List<string>();

            //starting block number - 1
            int blockNumber = 0;

            try
            {
                int bytesRead = 0; //number of bytes read so far
                long bytesLeft = fileSize; //number of bytes left to read and upload

                //do until all of the bytes are uploaded
                while (bytesLeft > 0)
                {
                    blockNumber++;
                    int bytesToRead;
                    if (bytesLeft >= blockSize)
                    {
                        //more than one block left, so put up another whole block
                        bytesToRead = blockSize;
                    }
                    else
                    {
                        //less than one block left, read the rest of it
                        bytesToRead = (int)bytesLeft;
                    }

                    //create a blockID from the block number, add it to the block ID list
                    //the block ID is a base64 string
                    string blockId =
                    Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(string.Format("BlockId{0}",
                    blockNumber.ToString("0000000"))));
                    blockIDs.Add(blockId);
                    //set up new buffer with the right size, and read that many bytes into it
                    byte[] bytes = new byte[bytesToRead];
                    memoryStream.Read(bytes, 0, bytesToRead);

                    //upload the block
                    await blockBlob.PutBlockAsync(blockId, new MemoryStream(bytes), null);

                    //increment/decrement counters
                    bytesRead += bytesToRead;
                    bytesLeft -= bytesToRead;
                }

                //commit the blocks
                await blockBlob.PutBlockListAsync(blockIDs);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Exception thrown = {0}", ex);
            }

            return blockBlob.Uri.AbsoluteUri;
        }

        public async Task<string> UploadByteArrayAsync(byte[] binaryData, FileAttachment fileAttachment)
        {
            // Retrieve storage account information from connection string
            CloudStorageAccount storageAccount = CreateStorageAccountFromConnectionString();

            // Create a blob client for interacting with the blob service.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Create a container for organizing blobs within the storage account.
            CloudBlobContainer container = blobClient.GetContainerReference(fileAttachment.Container);
            try
            {
                BlobRequestOptions requestOptions = new BlobRequestOptions() { RetryPolicy = new NoRetry() };
                await container.CreateIfNotExistsAsync(requestOptions, null);
                // configure container for public access
                var permissions = await container.GetPermissionsAsync();
                permissions.PublicAccess = BlobContainerPublicAccessType.Blob;
                await container.SetPermissionsAsync(permissions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // List all the blobs in container
            BlobContinuationToken blobContinuationToken = null;
            do
            {
                var results = await container.ListBlobsSegmentedAsync(null, blobContinuationToken);
                // Get the value of the continuation token returned by the listing call.
                blobContinuationToken = results.ContinuationToken;
                foreach (IListBlobItem item in results.Results)
                {
                    if (item.Uri.ToString().Contains(fileAttachment.BlobId))
                    {
                        return item.Uri.AbsoluteUri;
                    }
                }
            } while (blobContinuationToken != null); // Loop while the continuation token is not null.

            try
            {
                BlobRequestOptions requestOptions = new BlobRequestOptions() { RetryPolicy = new NoRetry() };
                await container.CreateIfNotExistsAsync(requestOptions, null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { }
            // Referencing the file to the new container
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(fileAttachment.BlobName);

            blockBlob.Properties.ContentType = fileAttachment.ContentType;
            //Upload the Document
            await blockBlob.UploadFromByteArrayAsync(binaryData, 0, binaryData.Length);
            return blockBlob.Uri.AbsoluteUri;
        }


        public CloudStorageAccount CreateStorageAccountFromConnectionString()
        {
            CloudStorageAccount storageAccount;
            try
            {
                storageAccount = CloudStorageAccount.Parse(Environment.GetEnvironmentVariable("AzureStorageAccount"));
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.ToString());
                Console.ReadLine();
                throw;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.ToString());
                Console.ReadLine();
                throw;
            }

            return storageAccount;
        }

        /// <summary>
        /// provide the secured uri for each file which is valid for 24 hours
        /// </summary>
        /// <param name="containerName"></param>
        /// <param name="blobName">{BlobId}.{FileExt}</param>
        /// <returns></returns>
        public string GetBlobSasUri(string containerName, string blobName)
        {
            if (string.IsNullOrEmpty(containerName) || string.IsNullOrEmpty(blobName))
                return "";

            CloudStorageAccount storageAccount = CreateStorageAccountFromConnectionString();
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(containerName);
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);

            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy
            {
                SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5),
                SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24),
                Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write
            };

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blockBlob.GetSharedAccessSignature(sasConstraints);

            //Return the URI string for the container, including the SAS token.
            return blockBlob.Uri + sasBlobToken;
        }

        public async Task DownloadStorageBlobFileUAsync(string container, string blobName)
        {

            MemoryStream memoryStream = new MemoryStream();

            var UriSAS = GetBlobSasUri(container, blobName);

            CloudBlockBlob blob = new CloudBlockBlob(new Uri(UriSAS));

            await blob.DownloadToStreamAsync(memoryStream);
        }

        public async Task<byte[]> ViewStorageBlobFile(string container, string blobName, string docType)
        {

            if (!string.IsNullOrEmpty(docType))
            {
                blobName = blobName + "." + docType;
            }

            var UriSAS = GetBlobSasUri(container, blobName);

            // Referencing the file to the new container
            CloudBlockBlob blob = new CloudBlockBlob(new Uri(UriSAS));

            MemoryStream memoryStream = new MemoryStream();
            try
            {
                //Download a blob to your file system
                await blob.DownloadToStreamAsync(memoryStream);

                return memoryStream.ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task DeleteBlobInContainer(string containerName, string blobName)
        {
            CloudStorageAccount storageAccount = CreateStorageAccountFromConnectionString();
            // Create a blob client for interacting with the blob service.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            // Create a container for organizing blobs within the storage account.
            CloudBlobContainer container = blobClient.GetContainerReference(containerName);

            CloudBlockBlob blob = container.GetBlockBlobReference(blobName);
            await blob.DeleteIfExistsAsync();
        }        
    }
}
