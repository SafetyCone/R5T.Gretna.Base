using System;
using System.IO;

using R5T.Francia;
using R5T.Philippi;
using R5T.Sparta;


namespace R5T.Gretna
{
    public class ImageFileReadInfo : IDisposable
    {
        #region IDisposable

        private bool zDisposed = false; // To detect redundant calls.


        public void Dispose()
        {
            this.Dispose(true);
        }

        // Remove the virtual call if the class is sealed (or has no plans for subclassing, in which case this should be communicated by sealing the class).
        protected virtual void Dispose(bool disposing)
        {
            if (!this.zDisposed)
            {
                if (disposing)
                {
                    this.Stream.Dispose();
                }
            }

            this.zDisposed = true;
        }

        #endregion

        
        public ImageFileIdentity Identity { get; set; }
        public Stream Stream { get; set; }
        public FileName FileName { get; set; }
        public FileFormat FileFormat { get; set; }
    }
}
