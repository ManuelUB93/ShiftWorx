using ShiftWorx.Models;
using System.Reflection.Metadata;

namespace ShiftWorx.Models
{    
    public class FileAttachment : LifeCycleEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Container { get; set; }
        public string FileExt { get; set; }
        public string BlobId { get; set; }
        public string Uri { get; set; }
        public string UploadedBy { get; set; }
        public double Size { get; set; }

        //public string? fp_filename { get; set; }
        public int? fp_core_id { get; set; }

        public string BlobName => $"{BlobId}.{FileExt}";
        public string ContentType
        {
            get
            {
                string contentType = "";
                switch (FileExt)
                {
                    case "pdf":
                        contentType = "application/pdf";
                        break;
                    case "doc":
                    case "docx":
                        contentType = "application/msword";
                        break;
                    case "txt":
                        contentType = "text/plain";
                        break;
                    case "html":
                        contentType = "text/html";
                        break;
                    case "png":
                        contentType = "image/png";
                        break;
                    case "jpeg":
                    case "jpg":
                    case "jfif":
                        contentType = "image/jpeg";
                        break;
                    case "gif":
                        contentType = "image/gif";
                        break;
                    case "svg":
                        contentType = "image/svg+xml";
                        break;
                }
                return contentType;
            }
        }

        //public string GetBlobUri(BlobStorageHelper blob)
        //{
        //    Uri = blob.GetBlobSasUri(Container, BlobName);
        //    return Uri;
        //}
    }
}
