using System;
using System.IO;
using System.Threading.Tasks;

using R5T.Francia;
using R5T.Philippi;
using R5T.Sparta;

using R5T.T0064;


namespace R5T.Gretna
{
    [ServiceDefinitionMarker]
    public interface IImageFileRepository : IServiceDefinition
    {
        Task<ImageFileIdentity> AddImage(Stream imageFileStream, FileName imageFileName, FileFormat fileFormat);

        Task<bool> Exists(ImageFileIdentity imageFileIdentity);

        Task<Stream> GetImageFileStream(ImageFileIdentity imageFileIdentity);
        Task<FileName> GetImageFileName(ImageFileIdentity imageFileIdentity);
        Task<FileFormat> GetImageFileFormat(ImageFileIdentity imageFileIdentity);

        Task SetImageData(ImageFileIdentity imageFileIdentity, Stream imageFileStream);

        Task<ImageFileReadInfo> GetReadInfo(ImageFileIdentity imageFileIdentity);

        Task Delete(ImageFileIdentity imageFileIdentity);
    }
}
