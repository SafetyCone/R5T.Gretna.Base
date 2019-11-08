using System;
using System.IO;

using R5T.Francia;
using R5T.Philippi;
using R5T.Sparta;


namespace R5T.Gretna.Base
{
    public interface IImageFileRepository
    {
        ImageFileIdentity AddImage(Stream imageFileStream, FileName imageFileName, FileFormat fileFormat);

        bool Exists(ImageFileIdentity imageFileIdentity);

        Stream GetImageFileStream(ImageFileIdentity imageFileIdentity);
        FileName GetImageFileName(ImageFileIdentity imageFileIdentity);
        FileFormat GetImageFileFormat(ImageFileIdentity imageFileIdentity);

        ImageFileReadInfo GetReadInfo(ImageFileIdentity imageFileIdentity);

        void Delete(ImageFileIdentity imageFileIdentity);
    }
}
