using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naizari.Images
{
    public interface IImageSetProvider
    {
        IImageSet GetImageSet(ImageSetParameters parameters);
    }
}
