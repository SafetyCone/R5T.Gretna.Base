using System;
using System.IO;
using System.Threading.Tasks;

using R5T.Francia;
using R5T.Philippi;
using R5T.Sparta;


namespace R5T.Gretna
{
    public interface IImageFileRepository
    {
        Task<ImageFileIdentity> AddImage(Stream imageFileStream, FileName imageFileName, FileFormat fileFormat);

        Task<bool> Exists(ImageFileIdentity imageFileIdentity);

        Task<Stream> GetImageFileStream(ImageFileIdentity imageFileIdentity);
        Task<FileName> GetImageFileName(ImageFileIdentity imageFileIdentity);
        Task<FileFormat> GetImageFileFormat(ImageFileIdentity imageFileIdentity);

        Task<ImageFileReadInfo> GetReadInfo(ImageFileIdentity imageFileIdentity);

        Task Delete(ImageFileIdentity imageFileIdentity);
    }
}
