﻿/////////////////////////////////////////////////////////////////////////////////
// paint.net                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, and contributors.                  //
// All Rights Reserved.                                                        //
/////////////////////////////////////////////////////////////////////////////////

using System;

namespace PaintDotNet.Imaging
{
    public interface IBitmapSource<TPixel>
        : IBitmapSource
          where TPixel : unmanaged, INaturalPixelInfo<TPixel>
    {
    }
}
